using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThi
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void MenuItem_TT_Click(object sender, EventArgs e)
        {
            TTSV frm_ttsv = new TTSV();
            frm_ttsv.MdiParent = this;
            frm_ttsv.Show();
        }

        private void quảnLýSinhViênTheoDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSV frm_dssv = new DanhSachSV();
            frm_dssv.MdiParent = this;
            frm_dssv.Show();
        }
    }
}
