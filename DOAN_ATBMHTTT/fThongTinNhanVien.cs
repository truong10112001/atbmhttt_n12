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
    public partial class fThongTinNhanVien : Form
    {
        OracleConnection con;
        public fThongTinNhanVien(OracleConnection con0)
        {
            con = con0;
            InitializeComponent();
        }

        private void fThongTinNhanVien_Load(object sender, EventArgs e)
        {
            if (con == null || con.State == ConnectionState.Closed)
                con.Open();
            string q = "select * from system.NHANVIEN where MANV in (select user from dual)";
            OracleDataAdapter da = new OracleDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable NewDTable = new DataTable();

            NewDTable.Columns.Add("Field Name");

           
            NewDTable.Columns.Add("Thông tin");
            

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                DataRow NewRow = NewDTable.NewRow();
                NewRow[0] = dt.Columns[i].Caption;

                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    NewRow[j + 1] = dt.Rows[j][i];
                }

                NewDTable.Rows.Add(NewRow);
            }
            dataGridViewfThongTinNhanVien.DataSource = NewDTable;
        }
    }
}
