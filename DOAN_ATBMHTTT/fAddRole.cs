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
    public partial class fAddRole : Form
    {
        OracleConnection con;
        public fAddRole(OracleConnection con0)
        {
            con = con0;
            
            InitializeComponent();
        }

        private void fAddRole_Load(object sender, EventArgs e)
        {
            
        }
        private void setSession()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "ALTER SESSION SET " + "\"_ORACLE_SCRIPT\"" + "=TRUE";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                setSession();
                string role = textBoxRole.Text.ToString();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "CREATE ROLE " + role;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Success!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            this.Close();
        }
    }
}
