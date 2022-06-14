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
            con.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=XE)(SERVER=dedicated)));User Id=" + textBoxfLoginUsername.Text + ";Password=" + textBoxfLoginPassword.Text + ";";
            
            try
            {
                con.Open();
                string query = "select GRANTED_ROLE from USER_ROLE_PRIVS where USERNAME=(select user from dual)";
                OracleDataAdapter da = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (textBoxfLoginUsername.Text == "system")
                    {
                        fManager f = new fManager(con);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();

                    }

                    else if (dt.Rows[0]["GRANTED_ROLE"].ToString() == "THANH_TRA")
                    {
                        fThanhTra f = new fThanhTra(con);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if (dt.Rows[0]["GRANTED_ROLE"].ToString() == "Y_BACSI")
                    {
                        fYBacSi f = new fYBacSi(con);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if (dt.Rows[0]["GRANTED_ROLE"].ToString() == "NGHIEN_CUU")
                    {
                        fNghienCuu f = new fNghienCuu(con);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if (dt.Rows[0]["GRANTED_ROLE"].ToString() == "BENH_NHAN")
                    {
                        fBenhNhan f = new fBenhNhan(con);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if (dt.Rows[0]["GRANTED_ROLE"].ToString() == "NGHIEP_VU")
                    {
                        fNhanVien_NghiepVu f = new fNhanVien_NghiepVu(con);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
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
