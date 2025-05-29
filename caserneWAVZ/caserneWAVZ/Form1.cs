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
    public partial class Form1 : Form
    {
        private LibraryUserControl.TableauDeBord tableauDeBord;
        private ucStatistique Statistique;
        private ucNewMission ucNM;

        public Form1()
        {
            InitializeComponent();
            MesDatas.FillDs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewMission_Click(object sender, EventArgs e)
        {



            ucNM = new ucNewMission(MesDatas.DsGlobal);
            ucNM.Location = new Point(330, 12);
         
            this.Controls.Add(ucNM);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Controls.Remove(ucNM);
            ucNM.Dispose();
            ucNM = null;
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


        private void btnTest_Click(object sender, EventArgs e)
        {
            /*
            DataRow[] dr = MesDatas.DsGlobal.Tables["Mission"].Select("idMission = 9");
            DataTable dt = MesDatas.DsGlobal.Tables["Mission"].Clone();
            foreach(DataRow d in dr)
            {
                dt.ImportRow(d);
            }
            dgvTest.DataSource = dt; */

        }

        private void btnTab_Click_1(object sender, EventArgs e)
        {
            // Si le tableau de bord est déjà là, on ne fait rien
            if (tableauDeBord != null)
            {
                btnTab1.Enabled = false; // le désactiver pour montrer qu'on y est déjà
                return;
            }


                tableauDeBord = new LibraryUserControl.TableauDeBord(MesDatas.DsGlobal);
                tableauDeBord.GetMissionInfos = ObtenirInfosMission;
                tableauDeBord.ValiderMission = MarquerMissionTerminee;
                tableauDeBord.GetMissionsEnCours = ObtenirMissionsEnCours;
                tableauDeBord.GetAllMission = ObtenirTouteLesMissionsEnCours;
                tableauDeBord.Location = new Point(330, 12);

                this.Controls.Add(tableauDeBord);
                btnTab1.Enabled = false; // désactive après ajout

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




        private void btnStatistique_Click(object sender, EventArgs e)
        {
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
    }
}
