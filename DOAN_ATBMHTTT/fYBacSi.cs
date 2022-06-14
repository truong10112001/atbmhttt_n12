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
    public partial class fYBacSi : Form
    {
        OracleConnection con;
        public fYBacSi(OracleConnection con0)
        {
            con = con0;
            InitializeComponent();
        }

        private void fYBacSi_Load(object sender, EventArgs e)
        {

        }

        private void buttonfYBacSiUser_Click(object sender, EventArgs e)
        {
            fThongTinNhanVien f = new fThongTinNhanVien(con);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonfYBacSi_BN_Click(object sender, EventArgs e)
        {
            fYBacSi_Tim f = new fYBacSi_Tim(con);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
