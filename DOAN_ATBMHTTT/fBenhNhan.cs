using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_ATBMHTTT
{
    public partial class fBenhNhan : Form
    {
        public fBenhNhan()
        {
            InitializeComponent();
        }

        private void fBenhNhan_Load(object sender, EventArgs e)
        {

        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            fBenhNhan_ChinhSua f = new fBenhNhan_ChinhSua();
            f.ShowDialog();
        }
    }
}
