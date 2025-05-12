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
    }
}
