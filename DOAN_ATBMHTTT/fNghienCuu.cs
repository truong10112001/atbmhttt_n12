using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace DOAN_ATBMHTTT
{
    public partial class fNghienCuu : Form
    {
        OracleConnection con;
        public fNghienCuu(OracleConnection con0)
        {
            con = con0;
            InitializeComponent();
        }

        private void buttonfNghienCuuUser_Click(object sender, EventArgs e)
        {
            fThongTinNhanVien f = new fThongTinNhanVien(con);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonfNghienCuuHSBA_Click(object sender, EventArgs e)
        {
            fNghienCuu_HSBA f = new fNghienCuu_HSBA(con);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
