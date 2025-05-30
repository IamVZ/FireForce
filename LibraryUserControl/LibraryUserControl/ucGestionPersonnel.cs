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

namespace LibraryUserControl
{
    public partial class ucGestionPersonnel : UserControl
    {
        private SQLiteConnection connec;
        private DataSet dsGlobal;
        private DataTable dtChoixPompier;
        private BindingSource bsPompier;
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
            dtChoixPompier.Columns.Add("status", typeof(string));
            dtChoixPompier.Columns.Add("codeGrade", typeof(string));
            dtChoixPompier.Columns.Add("portable", typeof(string));
            dtChoixPompier.Columns.Add("enConge", typeof(int));
            dtChoixPompier.Columns.Add("enMission", typeof(int));

            
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

            

            if (dsGlobal != null)
            {
                // Remplir la combobox du choix des casernes avec un bindingSource
                BindingSource bsCaserne = new BindingSource();
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
            }
        }
        private void RemplirCboPompier(int index)
        {
            // Remplir la combobox du choix du pompier
            if(cboChoixCaserne.SelectedValue != null)
            {
                try
                {
                    dtChoixPompier.Rows.Clear();

                    string idCaserne = cboChoixCaserne.SelectedValue.ToString();
                    string requete = "select nom, prenom, matricule, sexe, dateNaissance, dateEmbauche,bip, codeGrade,enConge,enMission,portable from Pompier p join Affectation a\r\nON p.matricule = a.matriculePompier\r\nwhere a.dateFin IS NULL and a.idCaserne = " + idCaserne;
                    SQLiteCommand cd = new SQLiteCommand(requete, connec);
                    SQLiteDataReader dr = cd.ExecuteReader();

                    while (dr.Read())
                    {
                        DataRow row = dtChoixPompier.NewRow();
                        row["nomPrenom"] = dr[0].ToString() + " " + dr[1].ToString();
                        row["nom"] = dr[0].ToString();
                        row["Prenom"] = dr[1].ToString();
                        row["matricule"] = int.Parse(dr[2].ToString());
                        row["sexe"] = dr[3].ToString();
                        row["dateNaissance"] = dr[4].ToString();
                        row["dateEmbauche"] = dr[5].ToString();
                        row["bip"] = dr[6].ToString();
                        row["codeGrade"] = dr[7].ToString();
                        row["enConge"] = dr[8].ToString();
                        row["enMission"] = dr[9].ToString();
                        row["portable"] = dr[10].ToString();
                        dtChoixPompier.Rows.Add(row);
                    }
                    cboChoixPompier.SelectedIndex = index;
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
                cboChoixPompier.Text = "Choisir un pompier";
            }
        }

        private void cboChoixPompier_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNouveauPompier_Click(object sender, EventArgs e)
        {

        }

        private void btnChangerGrade_Click(object sender, EventArgs e)
        {
            try
            {
                string grade = cboGrade.SelectedValue.ToString();
                int matricule = int.Parse(cboChoixPompier.SelectedValue.ToString());
                string requete = "update Pompier\r\nset codeGrade = '"+grade+"'\r\nwhere matricule = " +matricule +";";
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
            pnlLogin.Visible = true;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            btnDeconexion.Visible = false;
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
                    pnlLogin.Visible = false;
                    pnlCarriere.Visible = true;
                    btnPlusInfo.Visible = false;
                    btnDeconexion.Visible = true;
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
            txtMdp.Text = "";
            txtId.Text = "";
        }
    }
}
