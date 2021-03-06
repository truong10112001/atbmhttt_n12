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
    public partial class fYBacSi_Tim_HSBA : Form
    {
        OracleConnection con;
        string mabn;
        public fYBacSi_Tim_HSBA(OracleConnection con0, string mabn0)
        {
            con = con0;
            mabn = mabn0;
            InitializeComponent();
        }

        private void fYBacSi_Tim_HSBA_Load(object sender, EventArgs e)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from system.HSBA where MABS in (select user from dual) and MABN = '"+ mabn + "'";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewHSBA.DataSource = dt;
        }

        private void dataGridViewHSBA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewHSBA.CurrentRow.Index == -1)
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
