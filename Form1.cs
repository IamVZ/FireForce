using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryUserControl;

namespace caserneWAVZ
{
    public partial class Form1 : Form
    {
        private GestionPompiers ucGP;

        public Form1()
        {
            InitializeComponent();
            MesDatas.ChargerTables();
        }

        private void btnGP_Click(object sender, EventArgs e)
        {   
            panel1.Visible = false;
            ucTableauDeBordCase1.Visible = false;
            btnGP.Visible = false;


            if (ucGP == null)
            {
                ucGP = new GestionPompiers(MesDatas.DsGlobal);
                ucGP.Location = new Point(330, 12);
                this.Controls.Add(ucGP);

                ucGP.Disposed += (s, args) =>
                {
                    ucGP = null;
                };
            }
        }
    }
}