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

            dgv.DataSource = dtChoixPompier;
            // Liaison entre dtChoixPompier et cboChoixPompier
            bsPompier = new BindingSource();
            bsPompier.DataSource = dtChoixPompier;

            cboChoixPompier.DisplayMember = "nomPrenom";
            cboChoixPompier.ValueMember = "matricule";
            cboChoixPompier.DataSource = bsPompier;

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

                // Remplir la combobox du choix du pompier
                RemplirCboPompier();
            }
        }
        private void RemplirCboPompier()
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
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }



            }
            else
            {
                MessageBox.Show("cboChoixCaserne.SelectedValue = null");
            }
        }

        private void cboChoixCaserne_SelectedValueChanged(object sender, EventArgs e)
        {
            if(dsGlobal != null)
            {
                RemplirCboPompier();
                cboChoixPompier.Text = "Choisir un pompier";
            }
        }

        private void cboChoixPompier_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNouveauPompier_Click(object sender, EventArgs e)
        {
            if (cboChoixPompier.SelectedValue != null)
            {
                MessageBox.Show(cboChoixPompier.SelectedValue.ToString());
            }
        }
    }
}
