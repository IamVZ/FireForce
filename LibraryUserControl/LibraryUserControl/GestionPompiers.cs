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
    public partial class GestionPompiers : UserControl
    {
        public GestionPompiers()
        {
            InitializeComponent();
        }

        private void GestionPompiers_Load(object sender, EventArgs e)
        {
            grpInfoExtend.Visible = false;
        }

        private void btnExtendedInfo_Click(object sender, EventArgs e)
        {
            grpInfoExtend.Visible = true;
            btnExtendedInfo.Visible = false;
        }
    }
}
