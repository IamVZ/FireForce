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
    public partial class ucGestionPersonnel : UserControl
    {
        private SQLiteConnection connec;
        private DataSet dsGlobal;
        private NewPompier nouveauPompier;
        private DataTable dtChoixPompier;
        private BindingSource bsPompier;
        private BindingSource bsCaserne;
        private Dictionary<string, Image> imgGrade = new Dictionary<string, Image>();
        private string idCaserne;
        private int matriculePompier;
        private bool isConnect = false;
        private string status;

        public ucGestionPersonnel()
        {
            InitializeComponent();
        }
        public ucGestionPersonnel(SQLiteConnection con, DataSet ds)
        {
            InitializeComponent();
            connec = con;
            dsGlobal = ds;
        }

        private void ucGestionPersonnel_Load(object sender, EventArgs e)
        {
            pnlCarriere.Visible = false;
            pnlLogin.Visible = false;
            btnDeconexion.Visible = false;

            nouveauPompier = new NewPompier(connec, dsGlobal);
            nouveauPompier.Location = new Point(0, 133);

            // Initialisation des images de grades
            imgGrade["SAP"] = Properties.Resources.SAP;
            imgGrade["SAP1"] = Properties.Resources.SAP1;
            imgGrade["SGT"] = Properties.Resources.SGT;
            imgGrade["SCH"] = Properties.Resources.SCH;
            imgGrade["CPL"] = Properties.Resources.CPL;
            imgGrade["CCH"] = Properties.Resources.CCH;
            imgGrade["ADJ"] = Properties.Resources.ADJ;
            imgGrade["ADC"] = Properties.Resources.ADC;
            imgGrade["LTN"] = Properties.Resources.LTN;
            imgGrade["CNE"] = Properties.Resources.CNE;
            imgGrade["CDT"] = Properties.Resources.CDT;
            imgGrade["LCL"] = Properties.Resources.LCL;
            imgGrade["COL"] = Properties.Resources.COL;

            // Initialisation de la datatable contenant tous les pompiers pouvant être sélectionné dans la cbo
            dtChoixPompier = new DataTable();
            dtChoixPompier.Columns.Add("nomPrenom", typeof(string));
            dtChoixPompier.Columns.Add("matricule", typeof(int));
            dtChoixPompier.Columns.Add("nom", typeof(string));
            dtChoixPompier.Columns.Add("prenom", typeof(string));
            dtChoixPompier.Columns.Add("bip", typeof(int));
            dtChoixPompier.Columns.Add("sexe", typeof(string));
            dtChoixPompier.Columns.Add("dateEmbauche", typeof(string));
            dtChoixPompier.Columns.Add("dateNaissance", typeof(string));
            dtChoixPompier.Columns.Add("codeGrade", typeof(string));
            dtChoixPompier.Columns.Add("portable", typeof(string));
            dtChoixPompier.Columns.Add("status", typeof(string));
            dtChoixPompier.Columns.Add("type", typeof(string));
            dtChoixPompier.Columns.Add("enMission", typeof(int));
            dtChoixPompier.Columns.Add("enConge", typeof(int));


            // Liaison entre dtChoixPompier et cboChoixPompier
            bsPompier = new BindingSource();
            bsPompier.DataSource = dtChoixPompier;

            cboChoixPompier.DisplayMember = "nomPrenom";
            cboChoixPompier.ValueMember = "matricule";
            cboChoixPompier.DataSource = bsPompier;

            // Liaison entre les labels et la base de donnée
            lblNom.DataBindings.Add("Text", bsPompier, "nom");
            lblPrenom.DataBindings.Add("Text", bsPompier, "prenom");
            lblSexe.DataBindings.Add("Text", bsPompier, "sexe");
            lblDateNaissance.DataBindings.Add("Text", bsPompier, "dateNaissance");
            lblDateEmbauche.DataBindings.Add("Text", bsPompier, "dateEmbauche");
            lblBip.DataBindings.Add("Text", bsPompier, "bip");
            lblGrade.DataBindings.Add("Text", bsPompier, "codeGrade");
            lblTel.DataBindings.Add("Text", bsPompier, "portable");
            lblType.DataBindings.Add("Text", bsPompier, "type");
            lblMat.DataBindings.Add("Text", bsPompier, "matricule");

            // Ajout de l'évenement currentChanged
            bsPompier.CurrentChanged += BsPompier_CurrentChanged;


            if (dsGlobal != null)
            {
                // Remplir la combobox du choix des casernes avec un bindingSource
                bsCaserne = new BindingSource();
                bsCaserne.DataSource = dsGlobal;
                bsCaserne.DataMember = "Caserne";
                cboChoixCaserne.DisplayMember = "nom";
                cboChoixCaserne.ValueMember = "id";
                cboChoixCaserne.DataSource = bsCaserne;

                // Remplir la combobox du choix des grades
                BindingSource bsGrade = new BindingSource();
                bsGrade.DataSource = dsGlobal;
                bsGrade.DataMember = "Grade";
                cboGrade.DisplayMember = "libelle";
                cboGrade.ValueMember = "code";
                cboGrade.DataSource = bsGrade;

                // Remplir la combobox du choix du pompier
                RemplirCboPompier(0);

                matriculePompier = int.Parse(cboChoixPompier.SelectedValue.ToString());


            }
        }
        private void BsPompier_CurrentChanged(object sender, EventArgs e)
        {
            // Actualiser l'image
            if (imgGrade.ContainsKey(lblGrade.Text))
            {
                pbImgGrade.Image = imgGrade[lblGrade.Text];
            }
        }

        public void RemplirCboPompier(int index)
        {
            // Remplir la combobox du choix du pompier
            if(cboChoixCaserne.SelectedValue != null)
            {
                try
                {
                    dtChoixPompier.Rows.Clear();

                    idCaserne = cboChoixCaserne.SelectedValue.ToString();
                    string requete = "select nom, prenom, matricule, sexe, dateNaissance, dateEmbauche,bip, codeGrade,enConge,enMission,portable,type from Pompier p join Affectation a\r\nON p.matricule = a.matriculePompier\r\nwhere a.dateFin IS NULL and a.idCaserne = " + idCaserne;
                    SQLiteCommand cd = new SQLiteCommand(requete, connec);
                    SQLiteDataReader dr = cd.ExecuteReader();

                    while (dr.Read())
                    {
                        DataRow row = dtChoixPompier.NewRow();
                        row["nomPrenom"] = dr[0].ToString() + " " + dr[1].ToString();
                        row["nom"] = dr[0].ToString();
                        row["Prenom"] = dr[1].ToString();
                        row["enMission"] = int.Parse(dr[9].ToString());
                        row["enConge"] = int.Parse(dr[8].ToString());
                        row["matricule"] = int.Parse(dr[2].ToString());
                        row["dateNaissance"] = dr[4].ToString();
                        row["dateEmbauche"] = dr[5].ToString();
                        row["bip"] = dr[6].ToString();
                        row["codeGrade"] = dr[7].ToString();
                        row["portable"] = dr[10].ToString();

                        // Gestion de l'affichage pour le type de Pompier (pro/vol) + pour le sexe du Pompier (masculin/féminin)
                        if (dr[11].ToString() == "v" && dr[3].ToString() == "m")
                        {
                            row["type"] = "Volontaire";
                            row["sexe"] = "Masculin";
                        }
                        else if(dr[11].ToString() == "v" && dr[3].ToString() == "f")
                        {
                            row["type"] = "Volontaire";
                            row["sexe"] = "Féminin";
                        }
                        else if (dr[3].ToString() == "m")
                        {
                            row["type"] = "Professionnel";
                            row["sexe"] = "Masculin";
                        }
                        else
                        {
                            row["type"] = "Professionnelle";
                            row["sexe"] = "Féminin";
                        }
                            

                        dtChoixPompier.Rows.Add(row);
                    }

                    cboChoixPompier.SelectedIndex = index;

                    // Actualiser l'image
                    pbImgGrade.Image = imgGrade[lblGrade.Text];

                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void cboChoixCaserne_SelectedValueChanged(object sender, EventArgs e)
        {
            if(dsGlobal != null)
            {
                RemplirCboPompier(0);
                if (isConnect)
                {
                    cboAffectation.SelectedIndex = cboChoixCaserne.SelectedIndex;
                }
            }
        }

        private void cboChoixPompier_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboChoixPompier.SelectedValue != null)
            {

                matriculePompier = int.Parse(cboChoixPompier.SelectedValue.ToString());
                if (isConnect)
                {
                    // Mettre à jour la ListBox des habilitations
                    RemplirLsbHabilitation();
                    // Mettre à jour la ListBox des affectations passées
                    RemplirLsbAffectation();
                    // Mettre à jour la ComboBox des choix de status du Pompier
                    MettreAJourCboStatus();
                }
                pbImgGrade.Image = imgGrade[lblGrade.Text];
            }
        }

        private void btnNouveauPompier_Click(object sender, EventArgs e)
        {
            NewPompier np = new NewPompier(connec, dsGlobal);
            np.Location = new Point(0, 105);
            this.Controls.Add(np);
            np.BringToFront();
        }

        private void btnChangerGrade_Click(object sender, EventArgs e)
        {
            try
            {
                string grade = cboGrade.SelectedValue.ToString();
                string requete = "update Pompier\r\nset codeGrade = '"+grade+"'\r\nwhere matricule = " + matriculePompier +";";
                SQLiteCommand cd = new SQLiteCommand(requete, connec);
                cd.ExecuteNonQuery();
                MessageBox.Show("Mise à jour avec succès !\n" + cboChoixPompier.Text + " est désormais --> " + grade);
                int index = cboChoixPompier.SelectedIndex;
                RemplirCboPompier(index);
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnPlusInfo_Click(object sender, EventArgs e)
        {
            cacherControl();
            pnlLogin.Visible = true;

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            MontrerControl();
            pnlLogin.Visible = false;
            btnDeconexion.Visible = false;
            pnlCarriere.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                string requete = "select * from Admin";
                SQLiteCommand cd = new SQLiteCommand(requete, connec);
                SQLiteDataReader dr = cd.ExecuteReader();
                bool mdpIsValid = false;
                bool idIsValid = false;
                while(dr.Read() && !mdpIsValid)
                {
                    if(txtId.Text == dr[1].ToString() && txtMdp.Text == dr[2].ToString())
                    {
                        mdpIsValid = true;
                    }
                    else if(txtId.Text == dr[1].ToString())
                    {
                        idIsValid = true;
                    }
                }
                // traitement des résultats après parcours de la base
                if (mdpIsValid)
                {
                    MontrerControl();
                    isConnect = true;
                    pnlLogin.Visible = false;
                    btnPlusInfo.Visible = false;
                    btnDeconexion.Visible = true;

                    // Remplir la comboBox du choix de la caserne de ratachement
                    BindingSource bsAffectation = new BindingSource();
                    bsAffectation.DataSource = dsGlobal;
                    bsAffectation.DataMember = "Caserne";
                    cboAffectation.DisplayMember = "nom";
                    cboAffectation.ValueMember = "id";
                    cboAffectation.DataSource = bsAffectation;
                    cboAffectation.SelectedIndex = cboChoixCaserne.SelectedIndex;

                    // Remplir la ListBox des habilitations
                    RemplirLsbHabilitation();

                    // Remplir la ListBox des affectations passées
                    RemplirLsbAffectation();

                    // Remplir la comboBox du choix du status du pompier
                    cboStatus.Items.Add("Disponible");
                    cboStatus.Items.Add("en congé");

                    MettreAJourCboStatus();

                }
                else if(idIsValid)
                {
                    MessageBox.Show("Mot de passe incorrect");
                    txtMdp.Text = "";
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect");
                    txtMdp.Text = "";
                    txtId.Text = "";
                }
            }
            catch(SystemException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bntDeconexion_Click(object sender, EventArgs e)
        {
            pnlCarriere.Visible = false;
            btnPlusInfo.Visible = true;
            btnDeconexion.Visible = false;
            txtMdp.Text = "";
            txtId.Text = "";
        }

        /////////////////////////
        //// Fonction Annexe ////
        /////////////////////////
        
        
        private void RemplirLsbHabilitation()
        {
            lsbHabilitation.Items.Clear();
            string requete = "SELECT libelle from Habilitation join Passer\r\non Habilitation.id = Passer.idHabilitation\r\nWHERE Passer.matriculePompier = " + matriculePompier;
            SQLiteCommand cd = new SQLiteCommand(requete, connec);
            SQLiteDataReader dr = cd.ExecuteReader();

            while (dr.Read())
            {
                lsbHabilitation.Items.Add(dr[0]);
            }
        }

        private void RemplirLsbAffectation()
        {
            lsbAffectationPassees.Items.Clear();
            string requete = "SELECT dateA, nom from Affectation a join Caserne c\r\non a.idCaserne = c.id\r\nWHERE a.matriculePompier = " + matriculePompier + " and a.dateFin is not NULL";
            SQLiteCommand cd = new SQLiteCommand(requete, connec);
            SQLiteDataReader dr = cd.ExecuteReader();

            while (dr.Read())
            {
                lsbAffectationPassees.Items.Add(dr[0] + "-" + dr[1]);
            }
        }

        private void MettreAJourCboStatus()
        {
            if (estEnMission())
            {
                cboStatus.Text = "En mission";
                status = cboStatus.Text;
                cboStatus.Enabled = false;
            }
            else if (estEnConge())
            {
                cboStatus.Enabled = true;
                cboStatus.SelectedIndex = 1;
                cboStatus.Text = "En congé";
                status = cboStatus.Text;
            }
            else
            {
                cboStatus.Enabled = true;
                cboStatus.SelectedIndex = 0;
                cboStatus.Text = "Disponible";
                status = cboStatus.Text;

            }
        }

        private bool estEnMission()
        {
            DataRow[] enMission = dtChoixPompier.Select("matricule = " + matriculePompier);
            return int.Parse(enMission[0][12].ToString()) == 1?true : false;
        }
        private bool estEnConge()
        {
            DataRow[] enMission = dtChoixPompier.Select("matricule = " + matriculePompier);
            return int.Parse(enMission[0][13].ToString()) == 1 ? true : false;
        }

        private void cacherControl()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = false;
            }
        }
        private void MontrerControl()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = true;
            }
        }

        ////////////////////////////////////////////////////////////////////

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            string requete = "";
            try
            {
                // Vérifier si des informations ont changé avant d'effectuer une nouvelle requête
                string message = "";
                
                SQLiteCommand cd;
                if (idCaserne != cboAffectation.SelectedValue.ToString())
                {
                    string dateAJD = DateTime.Now.ToString("yyyy-MM-dd");
                    try
                    {
                        requete = "insert into Affectation (matriculePompier,dateA,idCaserne) VALUES (" + matriculePompier + ",'" + dateAJD + "','" + int.Parse(cboAffectation.SelectedValue.ToString()) + "');\r\n\r\nUPDATE Affectation\r\nSET dateFin = '" + dateAJD + "'\r\nWHERE matriculePompier = " + matriculePompier + " and dateA != '"+dateAJD+"' and dateFin is NULL;";
                        cd = new SQLiteCommand(requete, connec);
                        cd.ExecuteNonQuery();
                        message += cboChoixPompier.Text + " a été muté vers la caserne : " + cboAffectation.Text+"\n";
                        // supprime le pompier de la datatable
                        DataRow[] deleteRow = dtChoixPompier.Select("matricule =" + matriculePompier);
                        dtChoixPompier.Rows.Remove(deleteRow[0]);
                        cboAffectation.SelectedIndex = cboChoixCaserne.SelectedIndex;
                    }
                    catch
                    {
                        message += cboChoixPompier.Text + " n'a pas put être muté vers la caserne : " + cboAffectation.Text + " car vous ne pouvez muter un même Pompier qu'une seule fois par jour\n";
                    }
                }
                if (cboStatus.Text != status)
                {
                    
                    if (cboStatus.SelectedIndex == 0)
                    {
                        requete = "update Pompier\r\nset enConge = 0\r\nwhere matricule = " + matriculePompier + ";";
                        cd = new SQLiteCommand(requete, connec);
                        cd.ExecuteNonQuery();

                        // Mettre à jour la datatable
                        DataRow[] dr = dtChoixPompier.Select("matricule = " + matriculePompier);
                        dr[0][13] = 0;

                        message += cboChoixPompier.Text + " est désormais disponible";
                    }
                    else
                    {
                        requete = "update Pompier\r\nset enConge = 1\r\nwhere matricule = " + matriculePompier + ";";
                        cd = new SQLiteCommand(requete, connec);
                        cd.ExecuteNonQuery();

                        // Mettre à jour la datatable
                        DataRow[] dr = dtChoixPompier.Select("matricule = " + matriculePompier);
                        dr[0][13] = 1;

                        message += cboChoixPompier.Text + " est désormais en congé";

                    }
                }
                if(message != "")
                {
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Aucune information n' été modifié !!");
                }
            }
            catch(SQLiteException err)
            {
                MessageBox.Show(err.Message + "\n\n" + requete);
            }
            
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            RemplirCboPompier(0);
        }

        private void txtMdp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnValider_Click(btnValider, EventArgs.Empty);
            }
        }

        private void btnNouveauPompier_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(50, 0, 0);
            if(btn == btnActualiser || btn == btnDeconexion || btn == btnNouveauPompier || btn == btnRetour || btn == btnValider)
            {
                btn.Font = new Font(btn.Font.FontFamily, 18, btn.Font.Style);
            }
            else
            {
                btn.Font = new Font(btn.Font.FontFamily, 16, btn.Font.Style);
            }
        }

        private void btnNouveauPompier_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(90, 0, 0);
            if (btn == btnActualiser || btn == btnDeconexion || btn == btnNouveauPompier || btn == btnRetour || btn == btnValider)
            {
                btn.Font = new Font(btn.Font.FontFamily, 16, btn.Font.Style);
            }
            else
            {
                btn.Font = new Font(btn.Font.FontFamily, 14, btn.Font.Style);
            }
        }
    }
}
