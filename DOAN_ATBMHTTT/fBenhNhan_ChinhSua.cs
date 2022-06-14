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
    public partial class fBenhNhan_ChinhSua : Form
    {
        OracleConnection con;
        string field;
        public fBenhNhan_ChinhSua(OracleConnection con0, string field0)
        {
            con = con0;
            field = field0;
            InitializeComponent();
        }

        private void fBenhNhan_ChinhSua_Load(object sender, EventArgs e)
        {

        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (con == null || con.State == ConnectionState.Closed)
                    con.Open();
                
                string query = "update system.BENHNHAN set " + field + " = '" + textBoxNewInfo.Text + "' where MABN = (select user from dual)";
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Sussessed");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
