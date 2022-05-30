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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //fManager f = new fManager();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=XE)(SERVER=dedicated)));User Id=" + textBoxfLoginUsername.Text.ToString() + ";Password=" + textBoxfLoginPassword.Text.ToString() + ";";
            
            con.Open();

            if (textBoxfLoginUsername.Text == "system")
            {
                fManager f = new fManager(con);
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
            else
            {
                fThanhTra f = new fThanhTra(con);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


    }
}
