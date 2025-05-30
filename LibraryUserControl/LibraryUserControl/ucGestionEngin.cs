using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUserControl
{
    public partial class ucGestionEngin : UserControl
    {
        private DataSet dsEngin;
        private int idCaserne;
        private BindingSource bsEngin = new BindingSource();
        private DataTable dtEngin;
        private bool load = false;
        private Dictionary<String, Image> imgEngin = new Dictionary<string, Image>();
        public ucGestionEngin()
        {
            InitializeComponent();
        }
        public ucGestionEngin(DataSet ds)
        {
            InitializeComponent();
            dsEngin = ds;
        }

        private void ucGestionEngin_Load(object sender, EventArgs e)
        {
            if(dsEngin != null)
            {
                BindingSource bsCaserne = new BindingSource();
                bsCaserne.DataSource = dsEngin;
                bsCaserne.DataMember = "Caserne";

                cboChoixCaserne.DisplayMember = "nom";
                cboChoixCaserne.ValueMember = "id";
                cboChoixCaserne.DataSource = bsCaserne;
               
                idCaserne = int.Parse(cboChoixCaserne.SelectedValue.ToString());

                dtEngin = new DataTable();
                dtEngin.Columns.Add(new DataColumn("num", typeof(String)));
                dtEngin.Columns.Add(new DataColumn("date", typeof(String)));
                dtEngin.Columns.Add(new DataColumn("dispo", typeof(String)));
                dtEngin.Columns.Add(new DataColumn("image", typeof(Image)));

                bsEngin.DataSource = dtEngin;

                lblNum.DataBindings.Add("Text", bsEngin, "num");
                lblDate.DataBindings.Add("Text", bsEngin, "date");
                lblStat.DataBindings.Add("Text", bsEngin, "dispo");
                pbImgEngin.DataBindings.Add("Image", bsEngin, "image");

                // Remplir le dictionnaire imgEngin contenant une image de chaque engin en fonction de sont nom
                imgEngin["VSAV"] = Properties.Resources.VSAV;
                imgEngin["VSR"] = Properties.Resources.VSR;
                imgEngin["EPA"] = Properties.Resources.EPA;
                imgEngin["FPT"] = Properties.Resources.FPT;
                imgEngin["CCF"] = Properties.Resources.CCF;
                imgEngin["VSS"] = Properties.Resources.VSS;
                imgEngin["BRS"] = Properties.Resources.BRS;
                imgEngin["FCYN"] = Properties.Resources.FCYN;
                imgEngin["VID"] = Properties.Resources.VID;
                imgEngin["VPC"] = Properties.Resources.VPC;

                load = true;

            }
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            if (bsEngin.Position > 0)
            {
                bsEngin.MovePrevious();
                lblCompteur.Text = ((bsEngin.Position) + 1).ToString() + " / " + bsEngin.Count.ToString();
            }
        }

        private void btnDroit_Click(object sender, EventArgs e)
        {
            if (bsEngin.Position < bsEngin.Count - 1)
            {
                bsEngin.MoveNext();
                lblCompteur.Text = ((bsEngin.Position) + 1).ToString() + " / " + bsEngin.Count.ToString();
            }
        }

        private void cboChoixCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboChoixCaserne_SelectedValueChanged(object sender, EventArgs e)
        {
            if (load)
            {
                dtEngin.Clear();
                ChargerElement();
            }
        }

        private void ChargerElement()
        {
            idCaserne = int.Parse(cboChoixCaserne.SelectedValue.ToString());
            DataRow[] drTab = dsEngin.Tables["Engin"].Select("idCaserne =" + idCaserne.ToString());
            foreach (DataRow dr in drTab)
            {
                // Création d'une ligne qui contient toutes les informations nécéssaire
                DataRow row = dtEngin.NewRow();
                row["num"] = dr[0].ToString() + "-" + dr[1] + "-" + dr[2].ToString();
                row["date"] = dr[3];
                row["dispo"] = "Disponible";
                if (int.Parse(dr[4].ToString()) == 1)
                {
                    row["dispo"] = "En Mission";
                }
                if (int.Parse(dr[5].ToString()) == 1)
                {
                    row["dispo"] = "En Panne";
                }
                if (imgEngin.ContainsKey(dr[1].ToString()))
                {
                    row["image"] = imgEngin[dr[1].ToString()];
                }
                dtEngin.Rows.Add(row);
            }
            lblCompteur.Text = "1 / " + bsEngin.Count.ToString();
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            bsEngin.MoveFirst();
            lblCompteur.Text = ((bsEngin.Position) + 1).ToString() + " / " + bsEngin.Count.ToString();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            bsEngin.MoveLast();
            lblCompteur.Text = ((bsEngin.Position)+1).ToString() + " / " + bsEngin.Count.ToString();
        }
    }
}
