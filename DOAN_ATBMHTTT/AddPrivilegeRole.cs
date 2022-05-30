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
    public partial class AddPrivilegeRole : Form
    {
        OracleConnection con;
        string user = "";
        public AddPrivilegeRole(OracleConnection con0, string role)
        {
            con = con0;
            user = role;
            InitializeComponent();
        }

        private void AddPrivilegeRole_Load(object sender, EventArgs e)
        {
            comboBoxPrivilegeUser_Load();
            comboBoxTableUser_Load();
        }
        private void comboBoxPrivilegeUser_Load()
        {
            comboBoxPrivilegeUser.Items.Add("SELECT");
            comboBoxPrivilegeUser.Items.Add("UPDATE");
            comboBoxPrivilegeUser.Items.Add("INSERT");
            comboBoxPrivilegeUser.Items.Add("DELETE");
        }
        private void comboBoxTableUser_Load()
        {
            //Ket noi Database lay list ten table
            comboBoxTableUser.Items.Add("HSBA");
            comboBoxTableUser.Items.Add("HSBA_DV");
            comboBoxTableUser.Items.Add("BENHNHAN");
            comboBoxTableUser.Items.Add("CSYT");
            comboBoxTableUser.Items.Add("NHANVIEN");
        }


        private void comboBoxTableUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPrivilegeUser.SelectedIndex >= 0)
            {
                if (comboBoxPrivilegeUser.SelectedItem.ToString() == "INSERT" || comboBoxPrivilegeUser.SelectedItem.ToString() == "DELETE")
                {
                    allColumn.Visible = false;
                    for (int i = 0; i < checkedListBoxColumn.Items.Count; i++)
                    {
                        checkedListBoxColumn.Visible = false;
                    }
                    return;
                }
                string table = comboBoxTableUser.SelectedItem.ToString(); //Lấy tên table từ combobox table user đã chọn
                checkedListBoxColumn_Load(table);
                allColumn.Visible = true;

            }
        }
        private void deleteItem()
        {
            checkedListBoxColumn.Items.Clear();
        }
        private void checkedListBoxColumn_Load(string table)
        {

            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                deleteItem();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = '" + table + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                if (dt.Rows.Count >= 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        checkedListBoxColumn.Items.Add(item["COLUMN_NAME"].ToString());
                    }
                    checkedListBoxColumn.DisplayMember = "COLUMN_NAME";
                }
                checkedListBoxColumn.Visible = true;

            }
            catch (Exception ex)
            {
            }
            

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPrivilegeUser.SelectedIndex < 0 || comboBoxTableUser.SelectedIndex < 0)
                {
                    this.Close();
                    return;
                }
                string table = comboBoxTableUser.SelectedItem.ToString();
                string privilege = comboBoxPrivilegeUser.SelectedItem.ToString();
                if (privilege == "SELECT" || privilege == "UPDATE")
                {
                    if (allColumn.Checked == true)
                    {
                        grantPrivilegesRole(user, privilege, table);
                    }
                    else
                    {

                        List<string> column = new List<string>();
                        foreach (object item in checkedListBoxColumn.CheckedItems)
                        {
                            column.Add(checkedListBoxColumn.GetItemText(item));
                        }
                        grantPrivilegesRole(user, privilege, table, column);
                    }
                }
                else
                {
                    grantPrivilegesRole(user, privilege, table);
                }
            }
            catch (Exception ex)
            {

            }
            this.Close();
        }

        private void createOrReplaceViewSelect(string name, string table, List<string> column)
        {

            OracleCommand cmd = con.CreateCommand();
            string temp = "";
            for (int i = 0; i < column.Count(); i++)
            {
                if (i == 0)
                    temp = column[0];
                else
                    temp = temp + "," + column[i];
            }

            cmd.CommandText = "CREATE OR REPLACE VIEW " + name + "_" + table + " AS SELECT " + temp + " FROM " + table;

            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

        }

        private void grantPrivilegesRole(string role, string privileges, string table)
        {
            if (con == null || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                OracleCommand cmd = con.CreateCommand();

                cmd.CommandText = "GRANT " + privileges + " ON " + table + " TO " + role;

                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("Success!(grantPrivilegesRole)");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!(grantPrivilegesRole)");
            }
        }
        private void grantPrivilegesRole(string role, string privileges, string table, List<string> column)
        {
            if (con == null || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                OracleCommand cmd = con.CreateCommand();
                string temp = "";
                for (int i = 0; i < column.Count(); i++)
                {
                    if (i == 0)
                        temp = column[0];
                    else
                        temp = temp + "," + column[i];
                }
                if (privileges != "SELECT")
                {
                    cmd.CommandText = "GRANT " + privileges + " (" + temp + ") " + " ON " + table + " TO " + role;
                }
                else
                {
                    createOrReplaceViewSelect(role, table, column);
                    cmd.CommandText = "GRANT SELECT ON " + role + "_" + table + " TO " + role;
                }
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("Success!(grantPrivilegesRole)");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!(grantPrivilegesRole)");
            }
        }


        private void allColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (allColumn.Checked == true)
            {
                for (int i = 0; i < checkedListBoxColumn.Items.Count; i++)
                    checkedListBoxColumn.SetItemChecked(i, true);
            }
        }
    }
}
