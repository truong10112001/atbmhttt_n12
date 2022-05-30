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
    public partial class fNhanVien_NghiepVu : Form
    {
        OracleConnection con;
        public fNhanVien_NghiepVu()
        {
            InitializeComponent();
        }

        private void buttonfNhanVien_NghiepVuUser_Click(object sender, EventArgs e)
        {
            fThongTinNhanVien f = new fThongTinNhanVien(con);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
