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
using LibraryUserControl;
using NewMission;

namespace caserneWAVZ
{
    public partial class frmFireForce : Form
    {
        private LibraryUserControl.TableauDeBord tableauDeBord;
        private ucStatistique Statistique;
        private ucNewMission ucNM;
        private ucGestionEngin ucEngin;
        private ucGestionPersonnel ucPersonnel;

        public frmFireForce()
        {
            InitializeComponent();
            MesDatas.FillDs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnTab_Click_1(btnTab1, EventArgs.Empty);
            pbLogo.Image = Properties.Resources.logo;
        }

        private void btnNewMission_Click(object sender, EventArgs e)
        {
            // Enlève de l'écran le tableau de bord si il est dejà présent
            if (tableauDeBord != null)
            {
                this.Controls.Remove(tableauDeBord);
                tableauDeBord.Dispose();
                tableauDeBord = null;
                btnTab1.BackColor = Color.FromArgb(90, 0, 0);
                btnTab1.Font = new Font(btnTab1.Font.FontFamily, 16, btnTab1.Font.Style);
            }
            // Enlève l'onglet Engin si jamais il est dejà présent à l'écran
            if (ucEngin != null)
            {
                this.Controls.Remove(ucEngin);
                ucEngin.Dispose();
                ucEngin = null;
                btnEngin.BackColor = Color.FromArgb(90, 0, 0);
                btnEngin.Font = new Font(btnEngin.Font.FontFamily, 16, btnEngin.Font.Style);
            }
            // Enlève l'onglet gestion du personnel si jamais il est dejà présent à l'écran
            if (ucPersonnel != null)
            {
                MettreAjourDS("Pompier");

                this.Controls.Remove(ucPersonnel);
                ucPersonnel.Dispose();
                ucPersonnel = null;
                btnGestionPersonnel.BackColor = Color.FromArgb(90, 0, 0);
                btnGestionPersonnel.Font = new Font(btnGestionPersonnel.Font.FontFamily, 16, btnGestionPersonnel.Font.Style);
            }
            // Enlève de l'écran les statistiques si elles sont dejà présentent
            if (Statistique != null)
            {
                this.Controls.Remove(Statistique);
                Statistique.Dispose();
                Statistique = null;
                btnStatistique.BackColor = Color.FromArgb(90, 0, 0);
                btnStatistique.Font = new Font(btnStatistique.Font.FontFamily, 16, btnStatistique.Font.Style);
            }


            ucNM = new ucNewMission(MesDatas.DsGlobal);
            ucNM.Location = new Point(330, 12);
         
            this.Controls.Add(ucNM);
        }

        public string[] ObtenirInfosMission(int idMission)
        {
            DataTable tblMission = MesDatas.DsGlobal.Tables["Mission"];

            DataRow[] lignes = tblMission.Select($"id = {idMission}");

            if (lignes.Length == 0)
                return null;

            DataRow ligneMission = lignes[0];

            DataRow ligneCaserne = ligneMission.GetParentRow("Mission_Caserne");
            DataRow ligneSinistre = ligneMission.GetParentRow("Mission_Sinistre");

            string nomCaserne = ligneCaserne?["nom"]?.ToString();
            string raisonAppel = "-->" + ligneMission["motifAppel"].ToString();
            string dateMission = "Début : " + ligneMission["dateHeureDepart"].ToString();
            string typeSinistre = ligneSinistre?["libelle"].ToString();
            string ID = "ID mission : " + ligneMission["id"].ToString();
            string natureSinistre = ligneMission["idNatureSinistre"].ToString();

            return new string[] { ID, nomCaserne, dateMission, typeSinistre, raisonAppel,natureSinistre};
        }

        public void MarquerMissionTerminee(int idMission)
        {
            // Met à jour la table en mémoire
            DataTable tblMission = MesDatas.DsGlobal.Tables["Mission"];
            DataRow[] lignes = tblMission.Select($"id = {idMission}");
            if (lignes.Length > 0)
            {
                lignes[0]["terminee"] = true;
            }

            // Requête SQL pour marquer la mission comme terminée
            string requeteMission = @"
            UPDATE Mission 
            SET terminee = 1, dateHeureRetour = @dateHeureRetour 
            WHERE id = @id";

            using (SQLiteCommand cmdMission = new SQLiteCommand(requeteMission, Connexion.Connec))
            {
                cmdMission.Parameters.AddWithValue("@id", idMission);
                cmdMission.Parameters.AddWithValue("@dateHeureRetour", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));


                try
                {
                    int lignesModifiees = cmdMission.ExecuteNonQuery();

                    if (lignesModifiees > 0)
                    {
                        MessageBox.Show($"Mission {idMission} marquée comme terminée dans la base.");

                        //  récupérer les matricules des pompiers mobilisés
                        string requeteMatricules = "SELECT matriculePompier FROM Mobiliser WHERE idMission = @idMission";
                        using (SQLiteCommand cmdMatricules = new SQLiteCommand(requeteMatricules, Connexion.Connec))
                        {
                            cmdMatricules.Parameters.AddWithValue("@idMission", idMission);
                            using (SQLiteDataReader reader = cmdMatricules.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int matricule = reader.GetInt32(0);

                                    // mise à jour du champ "enmission" pour chaque pompier
                                    string requeteMajPompier = "UPDATE Pompier SET EnMission = 0 WHERE matricule = @matricule";
                                    using (SQLiteCommand cmdMajPompier = new SQLiteCommand(requeteMajPompier, Connexion.Connec))
                                    {
                                        cmdMajPompier.Parameters.AddWithValue("@matricule", matricule);
                                        cmdMajPompier.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune mission mise à jour. ID introuvable ?");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour en base : " + ex.Message);
                }

                MarquerEnginDispo(idMission);
            }
        }


        public void MarquerEnginDispo(int idMission)
        {
            //  Mise à jour des engins (via PartirAvec)
            string requeteEngins = @"
    SELECT idCaserne, codeTypeEngin, numeroEngin
    FROM PartirAvec
    WHERE idMission = @idMission";

            using (SQLiteCommand cmdEngins = new SQLiteCommand(requeteEngins, Connexion.Connec))
            {
                cmdEngins.Parameters.AddWithValue("@idMission", idMission);

                using (SQLiteDataReader readerEngins = cmdEngins.ExecuteReader())
                {
                    while (readerEngins.Read())
                    {
                        int idCaserne = readerEngins.GetInt32(0);
                        string codeTypeEngin = readerEngins.GetString(1);
                        int numeroEngin = readerEngins.GetInt32(2);

                        //  Mise à jour en base
                        string requeteMajEngin = @"
                UPDATE Engin 
                SET enMission = 0 
                WHERE idCaserne = @idCaserne AND codeTypeEngin = @codeTypeEngin AND numero = @numeroEngin";

                        using (SQLiteCommand cmdMajEngin = new SQLiteCommand(requeteMajEngin, Connexion.Connec))
                        {
                            cmdMajEngin.Parameters.AddWithValue("@idCaserne", idCaserne);
                            cmdMajEngin.Parameters.AddWithValue("@codeTypeEngin", codeTypeEngin);
                            cmdMajEngin.Parameters.AddWithValue("@numeroEngin", numeroEngin);
                            cmdMajEngin.ExecuteNonQuery();
                        }

                        //  Mise à jour dans le DataSet
                        DataTable tblEngins = MesDatas.DsGlobal.Tables["Engin"];
                        DataRow[] lignesEngin = tblEngins.Select(
                            $"idCaserne = {idCaserne} AND codeTypeEngin = '{codeTypeEngin}' AND numero = {numeroEngin}");

                        if (lignesEngin.Length > 0)
                        {
                            lignesEngin[0]["enMission"] = false;
                        }
                    }
                }
            }

        }


        public List<int> ObtenirMissionsEnCours()
        {
            List<int> ids = new List<int>();
            DataTable missionTable = MesDatas.DsGlobal.Tables["Mission"];

            foreach (DataRow row in missionTable.Rows)
            {
                int terminee = Convert.ToInt32(row["terminee"]);
                if (terminee == 0)
                {
                    ids.Add(Convert.ToInt32(row["id"]));
                }
            }

            return ids;
        }

        public List<int> ObtenirTouteLesMissionsEnCours()
        {
            List<int> ids = new List<int>();
            DataTable missionTable = MesDatas.DsGlobal.Tables["Mission"];

            foreach (DataRow row in missionTable.Rows)
            {
                int terminee = Convert.ToInt32(row["terminee"]);
                ids.Add(Convert.ToInt32(row["id"]));

            }

            return ids;
        }

        private void btnTab_Click_1(object sender, EventArgs e)
        {
            // Si l'onglet nouvelle mission est déjà ouvert, on la rend invisible
            if (ucNM != null)
            {
                MettreAjourDB("Pompier");
                MettreAjourDB("Mission");
                MettreAjourDB("Engin");
                MettreAjourDB("Mobiliser");
                MettreAjourDB("PartirAvec");

                this.Controls.Remove(ucNM);
                ucNM.Dispose();
                ucNM = null;
                btnNewMission.BackColor = Color.FromArgb(90, 0, 0);
                btnNewMission.Font = new Font(btnNewMission.Font.FontFamily, 16, btnNewMission.Font.Style);
            }
            // Enlève l'onglet Engin si jamais il est dejà présent à l'écran
            if (ucEngin != null)
            {
                this.Controls.Remove(ucEngin);
                ucEngin.Dispose();
                ucEngin = null;
                btnEngin.BackColor = Color.FromArgb(90, 0, 0);
                btnEngin.Font = new Font(btnEngin.Font.FontFamily, 16, btnEngin.Font.Style);
            }
            // Enlève l'onglet gestion du personnel si jamais il est dejà présent à l'écran
            if (ucPersonnel != null)
            {
                MettreAjourDS("Pompier");

                this.Controls.Remove(ucPersonnel);
                ucPersonnel.Dispose();
                ucPersonnel = null;
                btnGestionPersonnel.BackColor = Color.FromArgb(90, 0, 0);
                btnGestionPersonnel.Font = new Font(btnGestionPersonnel.Font.FontFamily, 16, btnGestionPersonnel.Font.Style);
            }
            // Enlève de l'écran les statistiques si elles sont dejà présentent
            if (Statistique != null)
            {
                this.Controls.Remove(Statistique);
                Statistique.Dispose();
                Statistique = null;
                btnStatistique.BackColor = Color.FromArgb(90, 0, 0);
                btnStatistique.Font = new Font(btnStatistique.Font.FontFamily, 16, btnStatistique.Font.Style);
            }

            if (tableauDeBord != null)
            {
                
            }
            else
            {
                tableauDeBord = new LibraryUserControl.TableauDeBord(MesDatas.DsGlobal);
                tableauDeBord.GetMissionInfos = ObtenirInfosMission;
                tableauDeBord.ValiderMission = MarquerMissionTerminee;
                tableauDeBord.GetMissionsEnCours = ObtenirMissionsEnCours;
                tableauDeBord.GetAllMission = ObtenirTouteLesMissionsEnCours;
                tableauDeBord.Location = new Point(330, 12);
                btnTab1.BackColor = Color.FromArgb(50, 0, 0);
                btnTab1.Font = new Font(btnTab1.Font.FontFamily, 18, btnTab1.Font.Style);

                this.Controls.Add(tableauDeBord);
                //btnTab1.Enabled = false; // désactive après ajout
                

                // Quand on ferme ou supprime le tableau de bord : le bouton sera réactivé (tu peux appeler cette logique où tu le retires)
                tableauDeBord.Disposed += (s, args) =>
                {
                    tableauDeBord = null;
                    btnTab1.Enabled = true;
                };

                List<int> ids = new List<int>();
                DataTable missionTable = MesDatas.DsGlobal.Tables["Mission"];
                foreach (DataRow row in missionTable.Rows)
                {
                    ids.Add(Convert.ToInt32(row["id"]));
                }

                tableauDeBord.InitialiserCasesAvecMissions(ids);
            }
        }

        private void btnEngin_Click(object sender, EventArgs e)
        {
            // Si l'onglet nouvelle mission est déjà ouvert, on la rend invisible
            if (ucNM != null)
            {
                MettreAjourDB("Pompier");
                MettreAjourDB("Mission");
                MettreAjourDB("Engin");
                MettreAjourDB("Mobiliser");
                MettreAjourDB("PartirAvec");

                this.Controls.Remove(ucNM);
                ucNM.Dispose();
                ucNM = null;
                btnNewMission.BackColor = Color.FromArgb(90, 0, 0);
                btnNewMission.Font = new Font(btnNewMission.Font.FontFamily, 16, btnNewMission.Font.Style);
            }
            // Enlève de l'écran le tableau de bord si il est dejà présent
            if (tableauDeBord != null)
            {
                this.Controls.Remove(tableauDeBord);
                tableauDeBord.Dispose();
                tableauDeBord = null;
                btnTab1.BackColor = Color.FromArgb(90, 0, 0);
                btnTab1.Font = new Font(btnTab1.Font.FontFamily, 16, btnTab1.Font.Style);
            }
            // Enlève l'onglet gestion du personnel si jamais il est dejà présent à l'écran
            if (ucPersonnel != null)
            {
                MettreAjourDS("Pompier");

                this.Controls.Remove(ucPersonnel);
                ucPersonnel.Dispose();
                ucPersonnel = null;
                btnGestionPersonnel.BackColor = Color.FromArgb(90, 0, 0);
                btnGestionPersonnel.Font = new Font(btnGestionPersonnel.Font.FontFamily, 16, btnGestionPersonnel.Font.Style);
            }
            // Enlève de l'écran les statistiques si elles sont dejà présentent
            if (Statistique != null)
            {
                this.Controls.Remove(Statistique);
                Statistique.Dispose();
                Statistique = null;
                btnStatistique.BackColor = Color.FromArgb(90, 0, 0);
                btnStatistique.Font = new Font(btnStatistique.Font.FontFamily, 16, btnStatistique.Font.Style);
            }
            ucEngin = new ucGestionEngin(MesDatas.DsGlobal)
            {
                Location = new Point(330, 12)
            };

            this.Controls.Add(ucEngin);
        }

        private void btnTab1_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(50, 0, 0);
            btn.Font = new Font(btn.Font.FontFamily, 18, btn.Font.Style);
        }

        private void btnTab1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (tableauDeBord != null && btn == btnTab1)
            {
                btn.BackColor = Color.FromArgb(50, 0, 0);
                btn.Font = new Font(btn.Font.FontFamily, 16, btn.Font.Style);
            }
            else if(ucNM != null && btn == btnNewMission)
            {
                btn.BackColor = Color.FromArgb(50, 0, 0);
                btn.Font = new Font(btn.Font.FontFamily, 16, btn.Font.Style);
            }
            else if (ucPersonnel != null && btn == btnGestionPersonnel)
            {
                btn.BackColor = Color.FromArgb(50, 0, 0);
                btn.Font = new Font(btn.Font.FontFamily, 16, btn.Font.Style);
            }
            else if (ucEngin != null && btn == btnEngin)
            {
                btn.BackColor = Color.FromArgb(50, 0, 0);
                btn.Font = new Font(btn.Font.FontFamily, 16, btn.Font.Style);
            }
            else if (Statistique != null && btn == btnStatistique)
            {
                btn.BackColor = Color.FromArgb(50, 0, 0);
                btn.Font = new Font(btn.Font.FontFamily, 16, btn.Font.Style);
            }
            else
            {
                btn.BackColor = Color.FromArgb(90, 0, 0);
                btn.Font = new Font(btn.Font.FontFamily, 16, btn.Font.Style);
            }
        }

        private void btnStatistique_Click(object sender, EventArgs e)
        {
            // Si l'onglet nouvelle mission est déjà ouvert, on la rend invisible
            if (ucNM != null)
            {
                MettreAjourDB("Pompier");
                MettreAjourDB("Mission");
                MettreAjourDB("Engin");
                MettreAjourDB("Mobiliser");
                MettreAjourDB("PartirAvec");

                this.Controls.Remove(ucNM);
                ucNM.Dispose();
                ucNM = null;
                btnNewMission.BackColor = Color.FromArgb(90, 0, 0);
                btnNewMission.Font = new Font(btnNewMission.Font.FontFamily, 16, btnNewMission.Font.Style);
            }
            // Enlève de l'écran le tableau de bord si il est dejà présent
            if (tableauDeBord != null)
            {
                this.Controls.Remove(tableauDeBord);
                tableauDeBord.Dispose();
                tableauDeBord = null;
                btnTab1.BackColor = Color.FromArgb(90, 0, 0);
                btnTab1.Font = new Font(btnTab1.Font.FontFamily, 16, btnTab1.Font.Style);
            }
            // Enlève l'onglet Engin si jamais il est dejà présent à l'écran
            if (ucEngin != null)
            {
                this.Controls.Remove(ucEngin);
                ucEngin.Dispose();
                ucEngin = null;
                btnEngin.BackColor = Color.FromArgb(90, 0, 0);
                btnEngin.Font = new Font(btnEngin.Font.FontFamily, 16, btnEngin.Font.Style);
            }
            // Enlève l'onglet gestion du personnel si jamais il est dejà présent à l'écran
            if (ucPersonnel != null)
            {
                MettreAjourDS("Pompier");

                this.Controls.Remove(ucPersonnel);
                ucPersonnel.Dispose();
                ucPersonnel = null;
                btnGestionPersonnel.BackColor = Color.FromArgb(90, 0, 0);
                btnGestionPersonnel.Font = new Font(btnGestionPersonnel.Font.FontFamily, 16, btnGestionPersonnel.Font.Style);
            }

            Statistique = new ucStatistique(Connexion.Connec);
            Statistique.Location = new Point(330, 12);

            this.Controls.Add(Statistique);
            Statistique.ChargerHabilitation();
            Statistique.ChargerCaserne();
            Statistique.ChargerEnginPlusUtilise();
            Statistique.EnginParHeureUtil();
            Statistique.ChargerNombreIntervention();
            Statistique.ChargerHabilitationLaPlusSolicite();
            
            Statistique.ChargerPompierParHabilitation();
        }

        private void btnGestionPersonnel_Click(object sender, EventArgs e)
        {
            // Si l'onglet nouvelle mission est déjà ouvert, on la rend invisible
            if (ucNM != null)
            {
                MettreAjourDB("Pompier");
                MettreAjourDB("Mission");
                MettreAjourDB("Engin");
                MettreAjourDB("Mobiliser");
                MettreAjourDB("PartirAvec");

                this.Controls.Remove(ucNM);
                ucNM.Dispose();
                ucNM = null;
                btnNewMission.BackColor = Color.FromArgb(90, 0, 0);
                btnNewMission.Font = new Font(btnNewMission.Font.FontFamily, 16, btnNewMission.Font.Style);
            }
            // Enlève de l'écran le tableau de bord si il est dejà présent
            if (tableauDeBord != null)
            {
                this.Controls.Remove(tableauDeBord);
                tableauDeBord.Dispose();
                tableauDeBord = null;
                btnTab1.BackColor = Color.FromArgb(90, 0, 0);
                btnTab1.Font = new Font(btnTab1.Font.FontFamily, 16, btnTab1.Font.Style);
            }
            // Enlève l'onglet Engin si jamais il est dejà présent à l'écran
            if (ucEngin != null)
            {
                this.Controls.Remove(ucEngin);
                ucEngin.Dispose();
                ucEngin = null;
                btnEngin.BackColor = Color.FromArgb(90, 0, 0);
                btnEngin.Font = new Font(btnEngin.Font.FontFamily, 16, btnEngin.Font.Style);
            }
            // Enlève de l'écran les statistiques si elles sont dejà présentent
            if (Statistique != null)
            {
                this.Controls.Remove(Statistique);
                Statistique.Dispose();
                Statistique = null;
                btnStatistique.BackColor = Color.FromArgb(90, 0, 0);
                btnStatistique.Font = new Font(btnStatistique.Font.FontFamily, 16, btnStatistique.Font.Style);
            }
            ucPersonnel = new ucGestionPersonnel(Connexion.Connec, MesDatas.DsGlobal)
            {
                Location = new Point(330, 12)
            };

            this.Controls.Add(ucPersonnel);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        //////////////////////////
        /// Fonction Annexe //////
        //////////////////////////
        ///

        private void MettreAjourDB(string table)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from "+table, Connexion.Connec);
            da.Fill(MesDatas.DsGlobal.Tables[table]);
            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
            da.UpdateCommand = builder.GetUpdateCommand();
            da.InsertCommand = builder.GetInsertCommand();
            da.DeleteCommand = builder.GetDeleteCommand();
            da.Update(MesDatas.DsGlobal.Tables[table]);
        }

        private void MettreAjourDS(string table)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from " + table, Connexion.Connec);
            MesDatas.DsGlobal.Tables[table].Clear();
            da.Fill(MesDatas.DsGlobal.Tables[table]);
        }
    }
}
