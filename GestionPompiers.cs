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
        private DataSet ds;

        public GestionPompiers()
        {
            InitializeComponent();
        }

        public GestionPompiers(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }

        private void GestionPompiers_Load(object sender, EventArgs e)
        {
            grpInfoExtend.Visible = false;

            cmbCaserne.DataSource = ds.Tables["Caserne"];
            cmbCaserne.DisplayMember = "nom";
            cmbCaserne.ValueMember = "id";

            cmbCaserne.SelectedIndexChanged += cmbCaserne_SelectedIndexChanged;
        }

        private void cmbCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ds == null || !ds.Tables.Contains("Affectation") || !ds.Tables.Contains("Pompier"))
                return;

            // Безпечне приведення типу
            if (!(cmbCaserne.SelectedValue is int idCaserne))
            {
                if (int.TryParse(cmbCaserne.SelectedValue?.ToString(), out int id))
                    idCaserne = id;
                else
                    return;
            }

            cmbPompiers.Items.Clear();

            // Вибір усіх поточних affectations для казарми
            var affectations = ds.Tables["Affectation"]
                .Select($"idCaserne = {idCaserne} AND dateFin IS NULL");

            foreach (DataRow aff in affectations)
            {
                int matricule = Convert.ToInt32(aff["matriculePompier"]);
                var pompiers = ds.Tables["Pompier"].Select($"matricule = {matricule}");

                if (pompiers.Length > 0)
                {
                    string nom = pompiers[0]["nom"].ToString();
                    string prenom = pompiers[0]["prenom"].ToString();
                    cmbPompiers.Items.Add($"{prenom} {nom}");
                }
            }

            if (cmbPompiers.Items.Count == 0)
            {
                cmbPompiers.Items.Add("(Aucun pompier trouvé)");
            }
        }

        private void btnExtendedInfo_Click(object sender, EventArgs e)
        {
            btnExtendedInfo.Visible = false;
            grpInfoExtend.Visible = true;
        }
    }
}
