using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace DOAN_ATBMHTTT
{
    public partial class fManager : Form
    {
        OracleConnection con;

        public fManager(OracleConnection con0)
        {
            con = con0;
            InitializeComponent();
        }

        private void fManager_Load(object sender, EventArgs e)
        {

            ListBoxUser_Load();
            ListBoxRole_Load();

        }
        //TabUser

        //----------ListBoxUser load, listBoxUser_SelectedIndexChanged, load privilege of user---------
        private void ListBoxUser_Load()
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "SELECT username FROM dba_users WHERE TRUNC(created) > (SELECT MIN(TRUNC(created)) FROM dba_users)";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                listBoxUser.DataSource = dt;
                listBoxUser.DisplayMember = "USERNAME";
            }

        }

        private void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBoxUser.GetItemText(listBoxUser.SelectedItem);
            privilege_Load(text, true);
            listBoxRoleOfUser_Load(text);
        }

        private void privilege_Load(string name, bool isUser)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q;
            if (isUser == true)
            {
                q = "((SELECT TABLE_NAME, PRIVILEGE  FROM DBA_TAB_PRIVS WHERE GRANTEE IN (SELECT granted_role FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + name + "')) union (SELECT TABLE_NAME, PRIVILEGE FROM dba_tab_privs WHERE grantee = '" + name + "')) union (SELECT DISTINCT TABLE_NAME,PRIVILEGE FROM DBA_COL_PRIVS WHERE GRANTEE = '" + name + "')";
            }
            else
            {
                q = "(SELECT TABLE_NAME, PRIVILEGE  FROM ROLE_TAB_PRIVS WHERE role = '" + name + "') union (SELECT DISTINCT TABLE_NAME,PRIVILEGE FROM DBA_COL_PRIVS WHERE GRANTEE = '" + name + "')";
            }
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 0)
            {
                if (isUser == true)
                    dataGridViewPrivilegeUser.DataSource = dt;
                else
                    dataGridViewPrivilegeRole.DataSource = dt;
            }

        }



        //-------------Add, Delete User, new password------------------

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            fAddUser f_add_user = new fAddUser(con);
            f_add_user.ShowDialog();
            ListBoxUser_Load();
        }

        private void setSession()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "ALTER SESSION SET " + "\"_ORACLE_SCRIPT\"" + "=TRUE";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

        }
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            string user = listBoxUser.GetItemText(listBoxUser.SelectedItem);
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                setSession();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "DROP USER " + user;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("Success!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!");
            }
            ListBoxUser_Load();

        }
        private void buttonEditPasswordUser_Click(object sender, EventArgs e)
        {
            fNewPassword f_new_pass = new fNewPassword(con ,listBoxUser.GetItemText(listBoxUser.SelectedItem));
            f_new_pass.ShowDialog();
        }



        //----------Load column of table privilege of user, load role of user -----------
        void listBoxRoleOfUser_Load(string userName)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + userName + "'";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 0)
            {
                listBoxRoleOfUser.DataSource = dt;
                listBoxRoleOfUser.DisplayMember = "GRANTED_ROLE";
            }
        }


        void Load_Privilege_Column(string name, bool isUser, string privilege, string tablename)
        {


            if (tablename != "BENHNHAN" && tablename != "NHANVIEN" && tablename != "HSBA" && tablename != "CSYT" && tablename != "HSBA_DV")
            {
                if (con == null || con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = '" + tablename + "'";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    if (isUser)
                    {
                        listBoxColumnUser.DataSource = dt;
                        listBoxColumnUser.DisplayMember = "COLUMN_NAME";
                    }
                    else
                    {
                        listBoxColumnRole.DataSource = dt;
                        listBoxColumnRole.DisplayMember = "COLUMN_NAME";
                    }


                }
                catch (Exception ex)
                {

                }

            }
            else if (privilege == "SELECT")
            {
                if (con == null || con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = '" + tablename + "'";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    if (isUser)
                    {
                        listBoxColumnUser.DataSource = dt;
                        listBoxColumnUser.DisplayMember = "COLUMN_NAME";
                    }
                    else
                    {
                        listBoxColumnRole.DataSource = dt;
                        listBoxColumnRole.DisplayMember = "COLUMN_NAME";
                    }

                }
                catch (Exception ex)
                {

                }

            }
            else if (privilege == "UPDATE")
            {
                if (con == null || con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    if (checkPrivilege(name, "UPDATE", tablename))
                    {
                        if (con == null || con.State == ConnectionState.Closed)
                            con.Open();
                        try
                        {
                            OracleCommand cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = '" + tablename + "'";
                            cmd.CommandType = CommandType.Text;
                            OracleDataReader dr = cmd.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            if (isUser)
                            {
                                listBoxColumnUser.DataSource = dt;
                                listBoxColumnUser.DisplayMember = "COLUMN_NAME";
                            }
                            else
                            {
                                listBoxColumnRole.DataSource = dt;
                                listBoxColumnRole.DisplayMember = "COLUMN_NAME";
                            }

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else
                    {
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandText = "SELECT COLUMN_NAME  FROM DBA_COL_PRIVS WHERE GRANTEE ='" + name + "' AND TABLE_NAME = '" + tablename + "'";
                        cmd.CommandType = CommandType.Text;
                        OracleDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        if (isUser)
                        {
                            listBoxColumnUser.DataSource = dt;
                            listBoxColumnUser.DisplayMember = "COLUMN_NAME";
                        }
                        else
                        {
                            listBoxColumnRole.DataSource = dt;
                            listBoxColumnRole.DisplayMember = "COLUMN_NAME";
                        }
                    }

                }
                catch (Exception ex)
                {

                }

            }

        }
        private bool checkPrivilege(string name, string privilege, string tablename)
        {
            string temp = null;

            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT privilege from DBA_TAB_PRIVS Where grantee = '" + name + "' and privilege='" + privilege + "' AND TABLE_NAME ='" + tablename + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    temp = dr[0].ToString();
                }
                if (temp == privilege)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {

            }

            return false;
        }

        private void dataGridViewPrivilegeUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string table = dataGridViewPrivilegeUser.CurrentRow.Cells["TABLE_NAME"].Value.ToString();
            string privilege = dataGridViewPrivilegeUser.CurrentRow.Cells["PRIVILEGE"].Value.ToString();
            if (privilege == "INSERT" || privilege == "DELETE")
            {
                DataTable dt = new DataTable();
                listBoxColumnUser.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                listBoxColumnUser.DataSource = dt;
                string name = listBoxUser.GetItemText(listBoxUser.SelectedItem);
                Load_Privilege_Column(name, true, privilege, table);
            }
        }


        //-------------ButtonPrivilege-------------------
        private void buttonAddPrivilegeUser_Click(object sender, EventArgs e)
        {
            AddPrivilegeUser f = new AddPrivilegeUser(con, listBoxUser.GetItemText(listBoxUser.SelectedItem));
            f.ShowDialog();
            privilege_Load(listBoxUser.GetItemText(listBoxUser.SelectedItem), true);
        }

        private void buttonRemovePrivilegeUser_Click(object sender, EventArgs e)
        {
            string table = dataGridViewPrivilegeUser.CurrentRow.Cells["TABLE_NAME"].Value.ToString();
            string privilege = dataGridViewPrivilegeUser.CurrentRow.Cells["PRIVILEGE"].Value.ToString();
            revokePrivilege(listBoxUser.GetItemText(listBoxUser.SelectedItem), table, privilege);
            privilege_Load(listBoxUser.GetItemText(listBoxUser.SelectedItem), true);
        }

        private void buttonAddUsertoRole_Click(object sender, EventArgs e)
        {
            fAddRoleOfUser f_add_role_of_user = new fAddRoleOfUser(con,listBoxUser.GetItemText(listBoxUser.SelectedItem));
            f_add_role_of_user.ShowDialog();
            listBoxRoleOfUser_Load(listBoxUser.GetItemText(listBoxUser.SelectedItem));
            privilege_Load(listBoxUser.GetItemText(listBoxUser.SelectedItem), true);
        }

        private void buttonRemoveUserFromRole_Click(object sender, EventArgs e)
        {
            string role = listBoxRoleOfUser.GetItemText(listBoxRoleOfUser.SelectedItem);
            string user = listBoxUser.GetItemText(listBoxUser.SelectedItem);
            Delete_Role(user, role);
            listBoxRoleOfUser_Load(user);
            privilege_Load(user, true);
        }
        void Delete_Role(string userName, string roleName)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                string q = "revoke " + roleName + " from " + userName;
                OracleCommand cmd = new OracleCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }
        private void revokePrivilege(string user, string table, string privilege)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "REVOKE " + privilege + " ON " + table + " FROM " + user;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("Success!(revokePrivilegesUser)");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!(revokePrivilegesUser)");
            }

        }

        //------------------------------ROLE------------------------------
        //Load listBoxRole, listBoxRole_SelectedIndexChanged
        private void ListBoxRole_Load()
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "select ROLE from dba_roles";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 0)
            {
                listBoxRole.DataSource = dt;
                listBoxRole.DisplayMember = "ROLE";
            }
        }

        private void listBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBoxRole.GetItemText(listBoxRole.SelectedItem);
            privilege_Load(text, false);
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            fAddRole f_add_role = new fAddRole(con);
            f_add_role.ShowDialog();
            ListBoxRole_Load();
        }

        private void buttonDeleteRole_Click(object sender, EventArgs e)
        {
            string role = listBoxRole.GetItemText(listBoxRole.SelectedItem); ;
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                setSession();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "DROP ROLE " + role;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("Success!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!");
            }
            ListBoxRole_Load();
        }

        private void buttonAddPrivilegeRole_Click(object sender, EventArgs e)
        {
            AddPrivilegeRole f = new AddPrivilegeRole(con,listBoxRole.GetItemText(listBoxRole.SelectedItem));
            f.ShowDialog();
            privilege_Load(listBoxRole.GetItemText(listBoxRole.SelectedItem), false);
        }

        private void buttonDeletePrivilegeRole_Click(object sender, EventArgs e)
        {
            string table = dataGridViewPrivilegeRole.CurrentRow.Cells["TABLE_NAME"].Value.ToString();
            string privilege = dataGridViewPrivilegeRole.CurrentRow.Cells["PRIVILEGE"].Value.ToString();
            revokePrivilege(listBoxRole.GetItemText(listBoxRole.SelectedItem), table, privilege);
            privilege_Load(listBoxRole.GetItemText(listBoxRole.SelectedItem), false);
        }

        private void dataGridViewPrivilegeRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string table = dataGridViewPrivilegeRole.CurrentRow.Cells["TABLE_NAME"].Value.ToString();
            string privilege = dataGridViewPrivilegeRole.CurrentRow.Cells["PRIVILEGE"].Value.ToString();
            if (privilege == "INSERT" || privilege == "DELETE")
            {
                DataTable dt = new DataTable();
                listBoxColumnRole.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                listBoxColumnRole.DataSource = dt;
                string name = listBoxRole.GetItemText(listBoxRole.SelectedItem);
                Load_Privilege_Column(name, false, privilege, table);
            }
        }
    }
}
