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
    public partial class fNewPassword : Form
    {
        OracleConnection con;
        string user = "";
        public fNewPassword(OracleConnection con0, string username)
        {
            con = con0;
            user = username;
            InitializeComponent();
        }

        private void fNewPassword_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                string newPassword = textBoxNewPassword.Text.ToString();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "ALTER USER " + user + " IDENTIFIED BY " + newPassword;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("Success!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!");
            }
            
            this.Close();
        }
    }
}
