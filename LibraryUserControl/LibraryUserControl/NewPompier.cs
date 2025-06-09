using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Ocsp;

namespace LibraryUserControl
{
    public partial class NewPompier : UserControl
    {
        private SQLiteConnection connec;
        private DataSet dsGlobal;
        private DataTable dtGrade;

        // Element du formulaire :
        private int matricule;
        private string nom;
        private string prenom;
        private string portable;
        private string bip;
        private string sexe = "";
        private string type = "";
        private string dateNaissance;
        private string grade;
        private List<CheckBox> lstHabilitation = new List<CheckBox>();
        private int compteurHabilitation = 0;
        private Dictionary<int, string> dateHabilitation = new Dictionary<int, string>();
        public NewPompier()
        {
            InitializeComponent();
        }
        public NewPompier(SQLiteConnection con, DataSet ds)
        {
            InitializeComponent();
            connec = con;
            dsGlobal = ds;
        }

        private void NewPompier_Load(object sender, EventArgs e)
        {
            pnlDateHabilitation.Visible = false;
            pnlHabilitation.Visible = false;
            btnValider.Visible = false;

            dtGrade = new DataTable();
            dtGrade.Columns.Add("code");
            dtGrade.Columns.Add("libelle");

            string requete = "select code, libelle from Grade";
            SQLiteCommand cd = new SQLiteCommand(requete, connec);
            SQLiteDataReader dr = cd.ExecuteReader();
            while (dr.Read())
            {
                DataRow row = dtGrade.NewRow();
                row["code"] = dr[0];
                row["libelle"] = dr[1];
                dtGrade.Rows.Add(row);
            }
            dr.Close();

            // Remplir la comboBox du choix des grades
            BindingSource bsGrade = new BindingSource();
            bsGrade.DataSource = dsGlobal;
            bsGrade.DataMember = "Grade";

            cboGrade.DisplayMember = "libelle";
            cboGrade.ValueMember = "code";
            cboGrade.DataSource = bsGrade;

            // Remplir la comboBox du choix de la caserne
            BindingSource bsCaserne = new BindingSource();
            bsCaserne.DataSource = dsGlobal;
            bsCaserne.DataMember = "Caserne";

            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";
            cboCaserne.DataSource = bsCaserne;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            // Vérifie si ce contrôle a un parent
            if(pnlHabilitation.Visible == true)
            {
                pnlHabilitation.Visible = false;
            }
            else if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }

        }

        private void rdbMasculin_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                rb.FlatAppearance.BorderSize = 3;
                if (rb.Name == "rdbFeminin")
                {
                    sexe = "f";
                    rb.BackColor = Color.Fuchsia;
                    rb.ForeColor = Color.White;
                }
                else  if(rb.Name == "rdbMasculin")
                {
                    sexe = "m";
                    rb.BackColor = Color.DodgerBlue;
                    rb.ForeColor = Color.White;
                }
                else if(rb.Name == "rdbVolontaire")
                {
                    type = "v";
                    rb.BackColor = Color.DarkGreen;
                    rb.ForeColor = Color.White;
                }
                else
                {
                    type = "p";
                    rb.BackColor = Color.DarkCyan;
                    rb.ForeColor = Color.White;
                }
            }
            else
            {
                rb.FlatAppearance.BorderSize = 0;
                
                if (rb.Name == "rdbFeminin")
                {
                    rb.BackColor = Color.FromArgb(255, 192, 255);
                    rb.ForeColor = Color.Black;
                }
                else if (rb.Name == "rdbMasculin")
                {
                    rb.BackColor = Color.FromArgb(170, 226, 255);
                    rb.ForeColor = Color.Black;

                }
                else if (rb.Name == "rdbVolontaire")
                {
                    rb.BackColor = Color.FromArgb(192, 255, 192);
                    rb.ForeColor = Color.Black;
                }
                else
                {
                    rb.BackColor = Color.FromArgb(150, 224,224);
                    rb.ForeColor = Color.Black;
                }
            }
            rb.FlatAppearance.MouseOverBackColor = rb.BackColor;
            rb.FlatAppearance.MouseDownBackColor = rb.BackColor;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewNom.Text != "" && txtNewPrenom.Text != "" && txtNewMatricule.Text != "" && sexe != "" && type != "")
                {
                    // Mettre à jour la table Pompier
                    string requete = "insert into Pompier (matricule,nom,prenom,sexe,dateNaissance,type,portable,bip,enMission,enConge,codeGrade,dateEmbauche) VALUES(" + txtNewMatricule.Text + ",'" + txtNewNom.Text + "','" + txtNewPrenom.Text + "','" + sexe + "','" + dtpNaissance.Value.ToString("yyyy-MM-dd") + "','" + type + "'," + txtNewPortable.Text + "," + txtNewBip.Text + ",0,0,'" + cboGrade.SelectedValue.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "');\n";
                   
                    // Mettre à jour la table Affectation
                    requete += "insert into Affectation (matriculePompier,dateA,dateFin,idCaserne) VALUES("+txtNewMatricule.Text+",'"+DateTime.Now.ToString("yyyy-MM-dd")+"',NULL,"+cboCaserne.SelectedValue.ToString()+");\n";

                    // Mettre à jour la table Passer
                    if(lstHabilitation.Count > 0)
                    {
                        foreach(KeyValuePair<int,string> paire in dateHabilitation)
                        {
                            requete += "insert into Passer (matriculePompier,idHabilitation,dateObtention) VALUES(" + txtNewMatricule.Text + "," + paire.Key + ",'" + paire.Value + "');\n";
                        }
                    }

                    // Executer la requete
                    SQLiteCommand cd = new SQLiteCommand(requete, connec);
                    cd.ExecuteNonQuery();
                    MessageBox.Show("Vous avez ajouter le pompier : " + txtNewNom.Text + " " + txtNewPrenom.Text + "\nVous l'avez affecter à la caserne : " + cboCaserne.Text);

                    if (this.Parent is ucGestionPersonnel uc)
                    {
                        uc.RemplirCboPompier(0);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez rentrer toutes les informations nécessaire");
                }
            }
            catch(SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Mettre à jour la table Passer
            lstHabilitation.Clear();
            dateHabilitation.Clear();
            foreach (Control ctrl in pnlChkHabilitation.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    if (cb.Checked)
                    {
                        lstHabilitation.Add(cb);
                    }
                }
            }

            if (lstHabilitation.Count > 0)
            {
                pnlDateHabilitation.Visible = true;
                dtpHabilitation.Visible = true;
                btnHabilitation.Visible = true;
                pnlDateHabilitation.BringToFront();
                compteurHabilitation = lstHabilitation.Count-1;
                lblHabilitationDate.Text = lstHabilitation[compteurHabilitation].Text;

            }
        }

        private void btnHabilitation_Click(object sender, EventArgs e)
        {
            if(compteurHabilitation >= 0)
            {
                if(compteurHabilitation == 0)
                {
                    //MessageBox.Show("id habilitation : " + lstHabilitation[compteurHabilitation].Tag.ToString() + "\nDate d'obtention : " + dtpHabilitation.Value.ToString("yyyy-mm-dd") + "\ncompteur : " + compteurHabilitation);
                    dateHabilitation[int.Parse(lstHabilitation[compteurHabilitation].Tag.ToString())] = dtpHabilitation.Value.ToString("yyyy-MM-dd");
                    lblHabilitationDate.Text = "Terminé";
                    dtpHabilitation.Visible = false;
                    btnHabilitation.Visible = false;
                    compteurHabilitation--;
                }
                else
                {
                    //MessageBox.Show("id habilitation : " + lstHabilitation[compteurHabilitation].Tag.ToString() + "\nDate d'obtention : " + dtpHabilitation.Value.ToString("yyyy-mm-dd") + "\ncompteur : " + compteurHabilitation);
                    dateHabilitation[int.Parse(lstHabilitation[compteurHabilitation].Tag.ToString())] = dtpHabilitation.Value.ToString("yyyy-MM-dd");
                    compteurHabilitation--;
                    lblHabilitationDate.Text = lstHabilitation[compteurHabilitation].Text;
                }

            }
            else
            {
                string message = "";
                int c = 1;
                foreach(KeyValuePair<int,string> paire in dateHabilitation)
                {
                    message += "clé "+c+") " + paire.Key.ToString() + "    valeure "+c+") " + paire.Value+"\n\n";
                    c++;
                }
                MessageBox.Show(message);
            }

        }

        private void btnAjouter_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(50, 0, 0);
            btn.Font = new Font(btn.Font.FontFamily, 18, btn.Font.Style);
        }

        private void btnAjouter_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(90, 0, 0);
            btn.Font = new Font(btn.Font.FontFamily, 16, btn.Font.Style);
        }

        private void btnAtribuerHabilitation_Click(object sender, EventArgs e)
        {
            pnlHabilitation.Visible = true;
        }

        private void chkIBNB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                cb.BackColor = Color.LightGreen; 
                cb.ForeColor = Color.Black;
            }
            else
            {
                cb.BackColor = Color.FromArgb(255, 224, 192); 
                cb.ForeColor = Color.Black; 
            }

            if (boolChkCheck())
            {
                btnValider.Visible = true;
            }
            else
            {
                btnValider.Visible = false;
                pnlDateHabilitation.Visible = false;
            }
        }

        private bool boolChkCheck()
        {
            bool chkChecked = false;
            int compteur = 0;
            while (!chkChecked && compteur < pnlChkHabilitation.Controls.Count)
            {
                if(pnlChkHabilitation.Controls[compteur] is CheckBox)
                {
                    CheckBox cb = (CheckBox)pnlChkHabilitation.Controls[compteur];
                    if (cb.Checked)
                    {
                        chkChecked = true;
                    }
                }
                compteur++;
            }
            return chkChecked;
        }
    }
}
