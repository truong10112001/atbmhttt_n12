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
    public partial class fAddRoleOfUser : Form
    {
        OracleConnection con;
        string user = "";
        public fAddRoleOfUser(OracleConnection con0, string username)
        {
            con = con0;
            user = username;
            InitializeComponent();
        }

        private void fAddRoleOfUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            add_Role(user, textBoxAddRole.Text.ToString(), checkBoxWGO.Checked);
            this.Close();
        }
        void add_Role(string userName, string roleName, bool grantOption)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                string q;
                if (grantOption == true)
                {
                    q = "grant " + roleName + " to " + userName + " with admin option";
                }
                else
                {
                    q = "grant " + roleName + " to " + userName;

                }
                OracleCommand cmd = new OracleCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Role was added to user!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
