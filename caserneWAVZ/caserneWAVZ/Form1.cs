using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewMission;

namespace caserneWAVZ
{
    public partial class Form1 : Form
    {
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
            ucNM = new ucNewMission();
            ucNM.dsMission = MesDatas.DsGlobal;
            ucNM.Location = new Point(210, 12);
            
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
            string raisonAppel = "-->" +ligneMission["motifAppel"].ToString();
            string dateMission = "Début : " + ligneMission["dateHeureDepart"].ToString();
            string typeSinistre = ligneSinistre?["libelle"].ToString();
            string ID = "ID mission : " + ligneMission["id"].ToString();
 

            return new string[] {ID, nomCaserne, dateMission,typeSinistre,raisonAppel };
        }

    }
}
