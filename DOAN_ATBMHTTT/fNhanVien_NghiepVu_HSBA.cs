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
    public partial class fNhanVien_NghiepVu_HSBA : Form
    {
        OracleConnection con;
        public fNhanVien_NghiepVu_HSBA(OracleConnection con0)
        {
            con = con0;
            InitializeComponent();
        }

        private void fNhanVien_NghiepVu_HSBA_Load(object sender, EventArgs e)
        {
            dataGridViewHSBA_Load();
        }
        private void dataGridViewHSBA_Load()
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from system.HSBA" +
                        " where MACSYT in (select CSYT from system.NHANVIEN where MANV in (select user from dual))";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewHSBA.DataSource = dt;
        }
        private void dataGridViewHSBA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewHSBA.CurrentRow.Index == -1)
            {
                return;
            }
            string mahsba = dataGridViewHSBA.CurrentRow.Cells["MAHSBA"].Value.ToString();
            dataGridViewHSBA_DV_Load(mahsba);
        }

        private void dataGridViewHSBA_DV_Load(string mahsba)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from system.HSBA_DV where MAHSBA = '" + mahsba + "'";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewHSBA_DV.DataSource = dt;
        }

        private void buttonXoaHSBA_Click(object sender, EventArgs e)
        {
         
            try
            {
                if (dataGridViewHSBA.CurrentRow.Index == -1)
                {
                    return;
                }
                string mahsba = dataGridViewHSBA.CurrentRow.Cells["MAHSBA"].Value.ToString();
                if (con == null || con.State == ConnectionState.Closed)
                    con.Open();
                string query = " delete from system.HSBA where MAHSBA = '" + mahsba + "'";
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Sussessed");
                dataGridViewHSBA_Load();
                dataGridViewHSBA_DV_Load(mahsba);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void buttonXoaHSBA_DV_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dataGridViewHSBA_DV.CurrentRow.Index == -1)
                {
                    return;
                }
                string mahsba = dataGridViewHSBA_DV.CurrentRow.Cells["MAHSBA"].Value.ToString();
                string madv = dataGridViewHSBA_DV.CurrentRow.Cells["MADV"].Value.ToString();

                if (con == null || con.State == ConnectionState.Closed)
                    con.Open();
                string query = " delete from system.HSBA_DV where MAHSBA = '" + mahsba + "' and MADV = '" + madv +"'";
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Sussessed");
                dataGridViewHSBA_DV_Load(mahsba);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void buttonThemHSBA_Click(object sender, EventArgs e)
        {
            fNhanVien_NghiepVu_HSBA_ThemHSBAcs f = new fNhanVien_NghiepVu_HSBA_ThemHSBAcs();
            f.ShowDialog();
        }

        private void buttonThemHSBA_DV_Click(object sender, EventArgs e)
        {
            fNhanVien_NghiepVu_HSBA_ThemHSBA_DV f = new fNhanVien_NghiepVu_HSBA_ThemHSBA_DV();
            f.ShowDialog();
        }
    }
}
