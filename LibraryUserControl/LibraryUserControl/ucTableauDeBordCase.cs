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
    public partial class ucTableauDeBordCase : UserControl
    {

        public ucTableauDeBordCase()
        {
            InitializeComponent();
        }

        public void remplirLabel(string info1, string info2, string info3, string info4, string info5)
        {
            lblIDMission.Text = info1;
            lblNomCaserne.Text = info2;
            lblDebut.Text = info3;
            lblCause.Text = info4;
            lblDesc.Text = info5;

            lblIDMission.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            lblNomCaserne.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            lblDebut.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            lblCause.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);

            AjusterTaillePolice(lblIDMission);
            AjusterTaillePolice(lblNomCaserne);
            AjusterTaillePolice(lblDebut);  
            AjusterTaillePolice(lblCause);
            AjusterTaillePolice(lblDesc);
        }

        private void AjusterTaillePolice(Label lbl)
        {
            int largeurMax = lbl.Width;
            int hauteurMax = lbl.Height;

            float taillePolice = Math.Min(largeurMax, hauteurMax) / 10f;

            if (taillePolice < 10)
                taillePolice = 10;
            lbl.Font = new Font("Segoe UI", taillePolice, lbl.Font.Style);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucTableauDeBordCase_Load(object sender, EventArgs e)
        {
            AjusterTaillePolice(lblIDMission);
            AjusterTaillePolice(lblNomCaserne);
            AjusterTaillePolice(lblDebut);
            AjusterTaillePolice(lblCause);
            AjusterTaillePolice(lblDesc);
        }

        public string IDMission
        {
            get { return lblIDMission.Text; }
            set { lblIDMission.Text = value; }
        }

        public string NomCaserne
        {
            get { return lblNomCaserne.Text; }
            set { lblNomCaserne.Text = value; }
        }

        public string Debut
        {
            get { return lblDebut.Text; }
            set { lblDebut.Text = value; }
        }

        public string Cause
        {
            get { return lblCause.Text; }
            set { lblCause.Text = value; }
        }

        public string Description
        {
            get { return lblDesc.Text; }
            set { lblDesc.Text = value; }


        }

        public Image ImageMission
        {
            get { return pbMission.Image; }
            set { pbMission.Image = value; }
        }

        private void pbMission_Click(object sender, EventArgs e)
        {

        }
    }
}
