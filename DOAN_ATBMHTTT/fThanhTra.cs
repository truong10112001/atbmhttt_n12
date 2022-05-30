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
    public partial class fThanhTra : Form
    {
        OracleConnection con;
        public fThanhTra(OracleConnection con0)
        {
            con = con0;
            InitializeComponent();
            
        }

        private void fThanhTra_Load(object sender, EventArgs e)
        {

        }

        private void buttonfThanhTraUser_Click(object sender, EventArgs e)
        {
            fThongTinNhanVien f = new fThongTinNhanVien(con);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonfThanhTraNhanVien_Click(object sender, EventArgs e)
        {
            fThanhTra_Select f = new fThanhTra_Select(con,"NHANVIEN");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonfThanhTraHSBA_Click(object sender, EventArgs e)
        {
            fThanhTra_Select f = new fThanhTra_Select(con,"HSBA");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonfThanhTraCSYT_Click(object sender, EventArgs e)
        {
            fThanhTra_Select f = new fThanhTra_Select(con, "CSYT");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonfThanhTraBenhNhan_Click(object sender, EventArgs e)
        {
            fThanhTra_Select f = new fThanhTra_Select(con, "BENHNHAN");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonfThanhTraHSBA_DV_Click(object sender, EventArgs e)
        {
            fThanhTra_Select f = new fThanhTra_Select(con, "HSBA_DV");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
