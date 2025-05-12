using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace NewMission
{
    public partial class ucNewMission: UserControl
    {
        public DataSet dsMission { get; set; }
        public ucNewMission()
        {
            InitializeComponent();
            
        }

        private void ucNewMission_Load(object sender, EventArgs e)
        {
            // rendre invisible la zone d'affichage des engins et pomiers selectionnés
            grpMobilisationPompier.Visible = false;

            if (dsMission != null)
            {
                // Remplir la date de la mission ainsi que le numéro de la mission
                lblNumMission.Text += (dsMission.Tables["Mission"].Rows.Count + 1).ToString();
                lblDateMission.Text += DateTime.Now.ToString();

                // Remplir la comboBox Nature du sinistre
                BindingSource bsSinistre = new BindingSource();
                bsSinistre.DataSource = dsMission;
                bsSinistre.DataMember = "NatureSinistre";

                cboNatureSinistre.DataSource = bsSinistre;
                cboNatureSinistre.DisplayMember = "libelle";
                cboNatureSinistre.ValueMember = "id";

                // Remplir la comboBox Caserne
                BindingSource bsCaserne = new BindingSource();
                bsCaserne.DataSource = dsMission;
                bsCaserne.DataMember = "Caserne";

                cboCaserneMobiliser.DataSource = bsCaserne;
                cboCaserneMobiliser.DisplayMember = "nom";
                cboCaserneMobiliser.ValueMember = "id";
            }

        }


        private void cboNatureSinistre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboCaserneMobiliser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            // Booleen pour savoir si la mission est valide
            bool IsValid = true;

             ////////////////////////
            // Gestion des Engins //
           ////////////////////////

            int idSinistre = int.Parse(cboNatureSinistre.SelectedValue.ToString());
            int idCaserne = int.Parse(cboCaserneMobiliser.SelectedValue.ToString());
            Dictionary<String, int> EnginNecessaire = new Dictionary<string, int> ();

            // Parcourir la table Necessiter pour remplir le dictionnaire EnginNecessaire
            // et ainsi savoir combien de véhicule par type aura besoin la mission

            foreach(DataRow dr in dsMission.Tables["Necessiter"].Rows)
            {
                if (int.Parse(dr[0].ToString()) == idSinistre)
                {
                    EnginNecessaire[dr[1].ToString()] = int.Parse(dr[2].ToString());
                }
            }

            // Création de la datatable permettant de stocker les engins qui seront mobilisé pour la mission
            DataTable enginMobiliser = new DataTable();
            enginMobiliser.Columns.Add("TypeEngin", typeof(String));
            enginMobiliser.Columns.Add("numéro", typeof(int));
            enginMobiliser.Columns.Add("idCaserne", typeof(int));

            // Parcourir le Dictionnaire et voir si pour chaque clé (type engin)
            // il y a le bon nombre de véhicule disponible dans la caserne selectionné

            DataTable Engin = dsMission.Tables["Engin"].Copy(); 

            foreach (KeyValuePair<String,int> paire in EnginNecessaire)
            {
                int compteurEngin = 0;
                int compteurLigne = 0;
                while (compteurEngin<paire.Value && compteurLigne < Engin.Rows.Count)
                {
                    if (int.Parse(Engin.Rows[compteurLigne][0].ToString()) == idCaserne && Engin.Rows[compteurLigne][1].ToString() == paire.Key && int.Parse(Engin.Rows[compteurLigne][4].ToString()) == 0 && int.Parse(Engin.Rows[compteurLigne][5].ToString()) == 0)
                    {
                        enginMobiliser.Rows.Add(paire.Key, int.Parse(Engin.Rows[compteurLigne][2].ToString()), int.Parse(Engin.Rows[compteurLigne][0].ToString()));
                        Engin.Rows[compteurLigne][4] = 1;
                        compteurEngin++;
                    }
                    compteurLigne++;
                }
                if(compteurEngin != paire.Value)
                {
                    IsValid = false;
                    break;
                }
            }

            dgvEngin.DataSource = enginMobiliser;

            //////////////////////////
            // Gestion des pompiers //
            //////////////////////////

            List<int> matricules = new List<int>();
            List<int> matriculesMobilisee = new List<int>();
            Dictionary<int, int> HabilitaionNecessaire = new Dictionary<int, int>();
            DataTable PompierMobilisee = new DataTable();
            PompierMobilisee.Columns.Add("nom", typeof(String));
            PompierMobilisee.Columns.Add("prenom", typeof(String));

            DataTable Affectation = dsMission.Tables["Affectation"];
            DataTable Pompier = dsMission.Tables["Pompier"];
            DataTable Passer = dsMission.Tables["Passer"];

            // mettre dans la liste "matricules" tous les pompier de la caserne séléctionnée 
            foreach (DataRow dr in Affectation.Rows)
            {
                if (int.Parse(dr[3].ToString()) == int.Parse(cboCaserneMobiliser.SelectedValue.ToString()))
                {
                    matricules.Add(int.Parse(dr[3].ToString()));
                }
            }
            // faire un tri de cette liste pour ne garder uniquement ceux qui sont disponible
            int compteurMatricule = 0;
            int compteurPompierLigne = 0;
            while(compteurMatricule < matricules.Count && compteurPompierLigne < Pompier.Rows.Count)
            {
                if (matricules.Contains(int.Parse(Pompier.Rows[compteurPompierLigne][0].ToString())))
                {
                    if (int.Parse(Pompier.Rows[compteurPompierLigne][9].ToString()) == 1 || int.Parse(Pompier.Rows[compteurPompierLigne][9].ToString()) == 1)
                    {
                        matricules.Remove(int.Parse(Pompier.Rows[compteurPompierLigne][0].ToString()));
                    }
                    compteurMatricule++;
                }
                compteurPompierLigne++;
            }

            // initialisation du dicionnaire contenant toutes les habilitations nécéssaires avec comme valeurs associé
            // le nombre de pompier devant disposer de cette habilitation

            foreach(DataRow data in enginMobiliser.Rows)
            {
                DataRow[] rows = dsMission.Tables["Embarquer"].Select("codeTypeEngin = '" + data[0] + "'");
                foreach(DataRow dr in rows)
                {
                    if (HabilitaionNecessaire.ContainsKey(int.Parse(dr[1].ToString())))
                    {
                        HabilitaionNecessaire[int.Parse(dr[1].ToString())] += int.Parse(dr[2].ToString());
                    }
                    else
                    {
                        HabilitaionNecessaire[int.Parse(dr[1].ToString())] = int.Parse(dr[2].ToString());
                    }
                }
            }

            // Parcourir la table Passer pour mettre le matricule uniquement des pompiers qui seront mobilisé pour la mission dans la liste matriculesMobilisee
            foreach(KeyValuePair<int,int> paire in HabilitaionNecessaire)
            {
                int compteurHabilitation = 0;
                int compteurLigne = 0;
                while(compteurHabilitation < paire.Value && compteurLigne < Passer.Rows.Count)
                {
                    if (matricules.Contains(int.Parse(Passer.Rows[compteurLigne][0].ToString())) && int.Parse(Passer.Rows[compteurLigne][1].ToString()) == paire.Key)
                    {
                        matriculesMobilisee.Add(int.Parse(Passer.Rows[compteurLigne][0].ToString()));
                        compteurHabilitation++;
                    }
                    compteurLigne++;
                }
            }

            foreach(DataRow dr in Pompier.Rows)
            {
                if (matriculesMobilisee.Contains(int.Parse(dr[0].ToString())))
                {
                    PompierMobilisee.Rows.Add(dr[1].ToString(), dr[2].ToString());
                }
            }
            dgvPompierMobilisee.DataSource = PompierMobilisee;


            // Condition de validité de la mission
            if (IsValid)
            {
                grpMobilisationPompier.Visible = true;
            }
            else
            {
                grpMobilisationPompier.Visible = false;
                MessageBox.Show("Engin inssuffisant dans la caserne sécléctionné.\nVeuillez choisir une autre caserne !!", "Engin insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
