using caserneWAVZ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUserControl
{
    public partial class GestionPompiers : UserControl
    {
        DataSet ds;

        public DataSet Ds { get => ds; set => ds = value; }
        public GestionPompiers()
        {
            InitializeComponent();
            ChargerCaserne();
            ChargerPompiers();
        }



        private void GestionPompiers_Load(object sender, EventArgs e)
        {
            grpInfoExtend.Visible = false;
        }

        Dictionary<string, int> caserneDict = new Dictionary<string, int>();

        

        private void ChargerCaserne()
        {
            try
            {
                SQLiteConnection conn = Connexion.Connec;
                SQLiteCommand cmd = new SQLiteCommand("SELECT nom, id FROM Caserne", conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                cmbCaserne.Items.Clear();

                while (reader.Read())
                {
                    cmbCaserne.Items.Add(reader["nom"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des casernes : " + ex.Message);
            }
        }

        private void ChargerPompiers(){
            try
            {
                SQLiteConnection conn = Connexion.Connec;
                SQLiteCommand cmd = new SQLiteCommand("SELECT p.matricule, p.nom, p.prenom, a.idCaserne, c.nom AS nomCaserne FROM Pompier p JOIN Affectation a ON p.matricule = a.matriculePompier JOIN Caserne c ON a.idCaserne = c.id ORDER BY c.nom, p.matricule;", conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                cmbPompiers.Items.Clear();


                while (reader.Read())
                {
                    string nom_prenom = reader["nom"].ToString() + " " + reader["prenom"].ToString();
                    cmbPompiers.Items.Add(nom_prenom);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des pompiers : " + ex.Message);
            }
        }

        private void btnExtendedInfo_Click(object sender, EventArgs e)
        {
            grpInfoExtend.Visible = true;
            btnExtendedInfo.Visible = false;
        }

        public void lblRetour_Click(object sender, EventArgs e)
        {
            RetourClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler RetourClicked;

        public Label LblRetour => lblRetour;

    }
}
