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
    public partial class fThanhTra_Select : Form
    {
        string table_name;
        OracleConnection con;
        public fThanhTra_Select(OracleConnection con0, string table_name0)
        {
            table_name = table_name0;
            con = con0;
            InitializeComponent();
            label1.Text = table_name;
        }

        private void fThanhTra_Select_Load(object sender, EventArgs e)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "SELECT * FROM system." + table_name;
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewfThanhTra_Select.DataSource = dt;
        }
    }
}
