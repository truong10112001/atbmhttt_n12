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
    public partial class fNghienCuu_HSBA : Form
    {
        OracleConnection con;

        public fNghienCuu_HSBA(OracleConnection con0)
        {
            con = con0;
            InitializeComponent();
        }

        private void fNghienCuu_HSBA_Load(object sender, EventArgs e)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from system.HSBA" +
                        " where MAKHOA in (select CHUYENKHOA from system.NHANVIEN where MANV in (select user from dual))" +
                        " and MACSYT in (select CSYT from system.NHANVIEN where MANV in (select user from dual))";
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
    }
}
