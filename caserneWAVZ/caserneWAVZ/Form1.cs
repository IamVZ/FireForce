using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caserneWAVZ
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MesDatas.ChargerTables();
            int idTest = 1;
            string[] info = ObtenirInfosMission(idTest);
            string info1 = info[0];
            string info2 = info[1];
            string info3 = info[2];
            string info4 = info[3];
            string info5 = info[4];
            ucTableauDeBordCase1.remplirLabel(info1, info2, info3, info4, info5);
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
            string raisonAppel = "-->" +ligneMission["motifAppel"].ToString();
            string dateMission = "Début : " + ligneMission["dateHeureDepart"].ToString();
            string typeSinistre = ligneSinistre?["libelle"].ToString();
            string ID = "ID mission : " + ligneMission["id"].ToString();
 

            return new string[] {ID, nomCaserne, dateMission,typeSinistre,raisonAppel };
        }

    }
}
