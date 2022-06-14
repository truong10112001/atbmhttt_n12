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
    public partial class fYBacSi_Tim : Form
    {
        OracleConnection con;
        public fYBacSi_Tim(OracleConnection con0)
        {
            con = con0;
            InitializeComponent();
        }

        private void fYBacSi_Tim_Load(object sender, EventArgs e)
        {
            dataGridViewBenhNhan_Load();
        }
        private void dataGridViewBenhNhan_Load()
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from system.BENHNHAN";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBenhNhan.DataSource = dt;
        }

        private void buttonTimCMND_Click(object sender, EventArgs e)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from system.BENHNHAN where CMND = '"+ textBoxCMND.Text +"'";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBenhNhan.DataSource = dt;
        }

        private void buttonTimMABN_Click(object sender, EventArgs e)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from system.BENHNHAN where MABN = '" + textBoxBenhNhan.Text + "'";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBenhNhan.DataSource = dt;
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            dataGridViewBenhNhan_Load();
        }

        private void buttonHSBA_Click(object sender, EventArgs e)
        {
            if (dataGridViewBenhNhan.CurrentRow.Index == -1)
            {
                MessageBox.Show("ERROR");
                return;
            }
            string mabn = dataGridViewBenhNhan.CurrentRow.Cells["MABN"].Value.ToString();
            if(mabn == "")
            {
                MessageBox.Show("ERROR");
                return;
            }
            fYBacSi_Tim_HSBA f = new fYBacSi_Tim_HSBA(con, mabn);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
