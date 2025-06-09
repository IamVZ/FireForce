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
        private DataSet dsMission;
        private bool IsValid = true;
        private DataTable PompierCopy;
        private DataTable EnginCopy;
        private DataTable Mobilise;
        private List<DataRow> PartirAvec = new List<DataRow>();
        private List<DataRow> Mobiliser = new List<DataRow>();
        private DataRow NewMission;
        private String dateHeure;
        private int numMission;
        private int idSinistre;
        private int idCaserne;

        public ucNewMission()
        {
            InitializeComponent();
            
        }
        public ucNewMission(DataSet dsP)
        {
            InitializeComponent();
            this.dsMission = dsP;

        }


        private void ucNewMission_Load(object sender, EventArgs e)
        {
            // rendre invisible la zone d'affichage des engins et pomiers selectionnés
            grpMobilisationPompier.Visible = false;

            if (dsMission != null)
            {
                // Remplir la date de la mission ainsi que le numéro de la mission
                numMission = dsMission.Tables["Mission"].Rows.Count + 1;
                lblNumMission.Text = "Mission n° " + numMission.ToString();
                dateHeure = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                lblDateMission.Text = "Déclenchée le : " + dateHeure;


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
            if (IsValid && PompierCopy != null && EnginCopy != null)
            {   
                // Mettre à jour la table Pompier
                for(int i=0; i<PompierCopy.Rows.Count;i++)
                {
                    if (PompierCopy.Rows[i][8] != dsMission.Tables["Pompier"].Rows[i][8])
                    {
                        dsMission.Tables["Pompier"].Rows[i][8] = PompierCopy.Rows[i][8];
                    }
                }
                // Mettre à jour la table Engin
                for (int i = 0; i < EnginCopy.Rows.Count; i++)
                {
                    if (EnginCopy.Rows[i][4] != dsMission.Tables["Engin"].Rows[i][4])
                    {
                        dsMission.Tables["Engin"].Rows[i][4] = EnginCopy.Rows[i][4];
                    }
                }

                // Mettre à jour la table Mobiliser
                for (int i = 0; i < Mobiliser.Count; i++)
                {
                    dsMission.Tables["Mobiliser"].Rows.Add(Mobiliser[i]);
                }
                Mobiliser.Clear();

                // Mettre à jour la table PartirAvec
                for (int i=0;i<PartirAvec.Count;i++)
                {
                    dsMission.Tables["PartirAvec"].Rows.Add(PartirAvec[i]);
                }
                PartirAvec.Clear();

                // Créer la mission
                NewMission = dsMission.Tables["Mission"].NewRow();
                NewMission[0] = dsMission.Tables["Mission"].Rows.Count + 1;
                NewMission[1] = dateHeure;
                NewMission[3] = txtMotif.Text;
                NewMission[4] = txtRue.Text;
                NewMission[5] = txtCP.Text;
                NewMission[6] = txtVille.Text;
                NewMission[7] = 0;
                NewMission[9] = idSinistre;
                NewMission[10] = idCaserne;
                dsMission.Tables["Mission"].Rows.Add(NewMission);

                // Mettre à jour la date pour les prochaines missions
                dateHeure = DateTime.Now.ToString();
                lblDateMission.Text = "Déclenchée le : " + dateHeure;

                // Mettre à jour le numéro de la mission
                numMission = dsMission.Tables["Mission"].Rows.Count + 1;
                lblNumMission.Text = "Mission n° " + numMission.ToString();

                // Mettre à jour le formulaire de création de nouvelle mission
                txtMotif.Text = "";
                txtRue.Text = "";
                txtVille.Text = "";
                txtCP.Text = "";
                grpMobilisationPompier.Visible = false;
                cboNatureSinistre.SelectedIndex = 0;
                cboCaserneMobiliser.SelectedIndex = 0;
                MessageBox.Show("La mission a bien été enregistré");
            }   
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {



            ////////////////////////
            // Gestion des Engins //
            ////////////////////////

            idSinistre = int.Parse(cboNatureSinistre.SelectedValue.ToString());
            idCaserne = int.Parse(cboCaserneMobiliser.SelectedValue.ToString());
            Dictionary<String, int> EnginNecessaire = new Dictionary<string, int>();
            

            // Parcourir la table Necessiter pour remplir le dictionnaire EnginNecessaire
            // et ainsi savoir combien de véhicule par type aura besoin la mission

            foreach (DataRow dr in dsMission.Tables["Necessiter"].Rows)
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

            foreach (KeyValuePair<String, int> paire in EnginNecessaire)
            {
                int compteurEngin = 0;
                int compteurLigne = 0;
                while (compteurEngin < paire.Value && compteurLigne < Engin.Rows.Count)
                {
                    if (int.Parse(Engin.Rows[compteurLigne][0].ToString()) == idCaserne && Engin.Rows[compteurLigne][1].ToString() == paire.Key && int.Parse(Engin.Rows[compteurLigne][4].ToString()) == 0 && int.Parse(Engin.Rows[compteurLigne][5].ToString()) == 0)
                    {
                        enginMobiliser.Rows.Add(paire.Key, int.Parse(Engin.Rows[compteurLigne][2].ToString()), int.Parse(Engin.Rows[compteurLigne][0].ToString()));
                        Engin.Rows[compteurLigne][4] = 1;
                        compteurEngin++;
                        DataRow dr = dsMission.Tables["PartirAvec"].NewRow();
                        dr[0] = idCaserne;
                        dr[1] = paire.Key;
                        dr[2] = int.Parse(Engin.Rows[compteurLigne][2].ToString());
                        dr[3] = dsMission.Tables["Mission"].Rows.Count + 1;
                        PartirAvec.Add(dr);
                    }
                    compteurLigne++;
                }
                if (compteurEngin != paire.Value)
                {
                    IsValid = false;
                    PartirAvec.Clear();
                    break;
                }
            }

            dgvEngin.DataSource = enginMobiliser;

            //////////////////////////
            // Gestion des pompiers //
            //////////////////////////

            List<int> matricules = new List<int>();
            List<int> matriculesMobilisee = new List<int>();
            Mobiliser.Clear();
            Dictionary<int, int> HabilitaionNecessaire = new Dictionary<int, int>();
            DataTable PompierMobilisee = new DataTable();
            PompierMobilisee.Columns.Add("matricule", typeof(int));
            PompierMobilisee.Columns.Add("habilitation", typeof(int));
            PompierMobilisee.Columns.Add("nom", typeof(String));
            PompierMobilisee.Columns.Add("prenom", typeof(String));

            DataTable Affectation = dsMission.Tables["Affectation"];
            DataTable Pompier = dsMission.Tables["Pompier"].Copy();
            DataTable Passer = dsMission.Tables["Passer"];

            // mettre dans la liste "matricules" tous les pompier de la caserne séléctionnée (VALIDER)
            foreach (DataRow dr in Affectation.Rows)
            {
                if (int.Parse(dr[3].ToString()) == int.Parse(cboCaserneMobiliser.SelectedValue.ToString()))
                {
                    matricules.Add(int.Parse(dr[0].ToString()));
                }
            }


            // faire un tri de cette liste pour ne garder uniquement ceux qui sont disponible (VALIDER)
            int compteurMatricule = 0;
            int compteurPompierLigne = 0;
            while (compteurMatricule < matricules.Count && compteurPompierLigne < Pompier.Rows.Count)
            {
                if (matricules.Contains(int.Parse(Pompier.Rows[compteurPompierLigne][0].ToString())))
                {
                    if (int.Parse(Pompier.Rows[compteurPompierLigne][8].ToString()) == 1 || int.Parse(Pompier.Rows[compteurPompierLigne][9].ToString()) == 1)
                    {
                        matricules.Remove(int.Parse(Pompier.Rows[compteurPompierLigne][0].ToString()));
                    }
                    compteurMatricule++;
                }
                compteurPompierLigne++;
            }



            // initialisation du dicionnaire contenant toutes les habilitations nécéssaires avec comme valeurs associé
            // le nombre de pompier devant disposer de cette habilitation  (VALIDER)

            foreach (DataRow data in enginMobiliser.Rows)
            {
                DataRow[] rows = dsMission.Tables["Embarquer"].Select("codeTypeEngin = '" + data[0] + "'");
                foreach (DataRow dr in rows)
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

            // Classer dans l'ordre les compétences qui sont le moins utilisé à celles qui sont le plus utilisé

            List<int[]> priority = new List<int[]>();
            int compteurPrio = 0;
            int compteurHabilitationLigne = 0;
            foreach (KeyValuePair<int, int> paire in HabilitaionNecessaire)
            {
                while (compteurHabilitationLigne < Passer.Rows.Count)
                {
                    if (matricules.Contains(int.Parse(Passer.Rows[compteurHabilitationLigne][0].ToString())) && int.Parse(Passer.Rows[compteurHabilitationLigne][1].ToString()) == paire.Key)
                    {
                        compteurPrio++;
                    }
                    compteurHabilitationLigne++;
                }
                priority.Add(new int[] { paire.Key, compteurPrio });
                compteurPrio = 0;
                compteurHabilitationLigne = 0;
            }

            // trier la list priorty en fonction du deuxième élément de chaque tableau de la list
            for (int i = 0; i < priority.Count - 1; i++)
            {
                int indexMin = i;

                for (int j = i + 1; j < priority.Count; j++)
                {
                    if (priority[j][1] < priority[indexMin][1])
                    {
                        indexMin = j;
                    }
                }
                int[] temp = priority[i];
                priority[i] = priority[indexMin];
                priority[indexMin] = temp;
            }


            // Parcourir la table Passer pour mettre le matricule uniquement des pompiers qui seront mobilisé pour la mission dans la liste matriculesMobilisee
            foreach (int[] tab in priority)
            {
                int compteurHabilitation = 0;
                int compteurLigne = 0;
                while (compteurHabilitation < HabilitaionNecessaire[tab[0]] && compteurLigne < Passer.Rows.Count)
                {
                    DataRow[] drPompier = Pompier.Select("matricule = " + int.Parse(Passer.Rows[compteurLigne][0].ToString()));
                    if (matricules.Contains(int.Parse(Passer.Rows[compteurLigne][0].ToString())) && int.Parse(Passer.Rows[compteurLigne][1].ToString()) == tab[0] && int.Parse(drPompier[0][8].ToString()) == 0)
                    {
                        matriculesMobilisee.Add(int.Parse(Passer.Rows[compteurLigne][0].ToString()));
                        drPompier[0][8] = 1;
                        compteurHabilitation++;

                        // Ajouter la ligne dans le dataGridView
                        PompierMobilisee.Rows.Add(drPompier[0][0] , tab[0], drPompier[0][1].ToString(), drPompier[0][2].ToString());

                        // Créer la ligne qui sera mise dans la table Mobiliser
                        DataRow dr = dsMission.Tables["Mobiliser"].NewRow();
                        dr[0] = drPompier[0][0];
                        dr[1] = dsMission.Tables["Mission"].Rows.Count + 1;
                        dr[2] = tab[0];
                        Mobiliser.Add(dr);
                    }
                    compteurLigne++;
                }
                if (compteurHabilitation != HabilitaionNecessaire[tab[0]])
                {
                    MessageBox.Show("Attention personnel insuffisant pour cette mission", "manque de personnel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                    this.PompierCopy = Pompier;
                }
            }

            dgvPompierMobilisee.DataSource = PompierMobilisee;


            // Condition de visibilité de la consultation des engins et pompiers qui serait éventuellement mobilisé
            if (IsValid)
            {
                grpMobilisationPompier.Visible = true;
                this.EnginCopy = Engin;
            }
            else
            {
                grpMobilisationPompier.Visible = false;
                MessageBox.Show("Engin inssuffisant dans la caserne sécléctionné.\nVeuillez choisir une autre caserne !!", "Engin insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        
    }
}
