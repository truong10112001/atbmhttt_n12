
namespace DOAN_ATBMHTTT
{
    partial class fManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRoleOfUser = new System.Windows.Forms.ListBox();
            this.dataGridViewPrivilegeUser = new System.Windows.Forms.DataGridView();
            this.buttonRemoveUserFromRole = new System.Windows.Forms.Button();
            this.buttonAddUsertoRole = new System.Windows.Forms.Button();
            this.buttonRemovePrivilegeUser = new System.Windows.Forms.Button();
            this.buttonAddPrivilegeUser = new System.Windows.Forms.Button();
            this.listBoxColumnUser = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditPasswordUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxRole = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonAddRole = new System.Windows.Forms.Button();
            this.buttonDeleteRole = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxColumnRole = new System.Windows.Forms.ListBox();
            this.dataGridViewPrivilegeRole = new System.Windows.Forms.DataGridView();
            this.buttonDeletePrivilegeRole = new System.Windows.Forms.Button();
            this.buttonAddPrivilegeRole = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrivilegeUser)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabRole.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrivilegeRole)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUser);
            this.tabControl.Controls.Add(this.tabRole);
            this.tabControl.Location = new System.Drawing.Point(-4, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1413, 711);
            this.tabControl.TabIndex = 5;
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.Color.LightCyan;
            this.tabUser.Controls.Add(this.panel2);
            this.tabUser.Controls.Add(this.panel4);
            this.tabUser.Controls.Add(this.panel1);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(1405, 682);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listBoxRoleOfUser);
            this.panel2.Controls.Add(this.dataGridViewPrivilegeUser);
            this.panel2.Controls.Add(this.buttonRemoveUserFromRole);
            this.panel2.Controls.Add(this.buttonAddUsertoRole);
            this.panel2.Controls.Add(this.buttonRemovePrivilegeUser);
            this.panel2.Controls.Add(this.buttonAddPrivilegeUser);
            this.panel2.Controls.Add(this.listBoxColumnUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(401, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 596);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Roles Of User";
            // 
            // listBoxRoleOfUser
            // 
            this.listBoxRoleOfUser.FormattingEnabled = true;
            this.listBoxRoleOfUser.ItemHeight = 16;
            this.listBoxRoleOfUser.Location = new System.Drawing.Point(511, 59);
            this.listBoxRoleOfUser.Name = "listBoxRoleOfUser";
            this.listBoxRoleOfUser.Size = new System.Drawing.Size(184, 68);
            this.listBoxRoleOfUser.TabIndex = 16;
            // 
            // dataGridViewPrivilegeUser
            // 
            this.dataGridViewPrivilegeUser.AllowUserToAddRows = false;
            this.dataGridViewPrivilegeUser.AllowUserToDeleteRows = false;
            this.dataGridViewPrivilegeUser.AllowUserToResizeColumns = false;
            this.dataGridViewPrivilegeUser.AllowUserToResizeRows = false;
            this.dataGridViewPrivilegeUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrivilegeUser.Location = new System.Drawing.Point(34, 146);
            this.dataGridViewPrivilegeUser.Name = "dataGridViewPrivilegeUser";
            this.dataGridViewPrivilegeUser.RowHeadersWidth = 51;
            this.dataGridViewPrivilegeUser.RowTemplate.Height = 24;
            this.dataGridViewPrivilegeUser.Size = new System.Drawing.Size(462, 436);
            this.dataGridViewPrivilegeUser.TabIndex = 15;
            this.dataGridViewPrivilegeUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrivilegeUser_CellContentClick);
            // 
            // buttonRemoveUserFromRole
            // 
            this.buttonRemoveUserFromRole.Location = new System.Drawing.Point(489, 8);
            this.buttonRemoveUserFromRole.Name = "buttonRemoveUserFromRole";
            this.buttonRemoveUserFromRole.Size = new System.Drawing.Size(148, 45);
            this.buttonRemoveUserFromRole.TabIndex = 14;
            this.buttonRemoveUserFromRole.Text = "Loại User khỏi Role";
            this.buttonRemoveUserFromRole.UseVisualStyleBackColor = true;
            this.buttonRemoveUserFromRole.Click += new System.EventHandler(this.buttonRemoveUserFromRole_Click);
            // 
            // buttonAddUsertoRole
            // 
            this.buttonAddUsertoRole.Location = new System.Drawing.Point(338, 8);
            this.buttonAddUsertoRole.Name = "buttonAddUsertoRole";
            this.buttonAddUsertoRole.Size = new System.Drawing.Size(145, 45);
            this.buttonAddUsertoRole.TabIndex = 13;
            this.buttonAddUsertoRole.Text = "Gán User vào Role";
            this.buttonAddUsertoRole.UseVisualStyleBackColor = true;
            this.buttonAddUsertoRole.Click += new System.EventHandler(this.buttonAddUsertoRole_Click);
            // 
            // buttonRemovePrivilegeUser
            // 
            this.buttonRemovePrivilegeUser.Location = new System.Drawing.Point(177, 8);
            this.buttonRemovePrivilegeUser.Name = "buttonRemovePrivilegeUser";
            this.buttonRemovePrivilegeUser.Size = new System.Drawing.Size(155, 45);
            this.buttonRemovePrivilegeUser.TabIndex = 12;
            this.buttonRemovePrivilegeUser.Text = "Thu hồi Quyền";
            this.buttonRemovePrivilegeUser.UseVisualStyleBackColor = true;
            this.buttonRemovePrivilegeUser.Click += new System.EventHandler(this.buttonRemovePrivilegeUser_Click);
            // 
            // buttonAddPrivilegeUser
            // 
            this.buttonAddPrivilegeUser.Location = new System.Drawing.Point(23, 9);
            this.buttonAddPrivilegeUser.Name = "buttonAddPrivilegeUser";
            this.buttonAddPrivilegeUser.Size = new System.Drawing.Size(148, 45);
            this.buttonAddPrivilegeUser.TabIndex = 11;
            this.buttonAddPrivilegeUser.Text = "Thêm Quyền";
            this.buttonAddPrivilegeUser.UseVisualStyleBackColor = true;
            this.buttonAddPrivilegeUser.Click += new System.EventHandler(this.buttonAddPrivilegeUser_Click);
            // 
            // listBoxColumnUser
            // 
            this.listBoxColumnUser.FormattingEnabled = true;
            this.listBoxColumnUser.ItemHeight = 16;
            this.listBoxColumnUser.Location = new System.Drawing.Point(501, 242);
            this.listBoxColumnUser.Name = "listBoxColumnUser";
            this.listBoxColumnUser.Size = new System.Drawing.Size(194, 340);
            this.listBoxColumnUser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Privilege";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.buttonAddUser);
            this.panel4.Controls.Add(this.buttonDeleteUser);
            this.panel4.Controls.Add(this.buttonEditPasswordUser);
            this.panel4.Location = new System.Drawing.Point(17, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 596);
            this.panel4.TabIndex = 3;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(14, 9);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(116, 60);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Thêm User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(14, 93);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(116, 63);
            this.buttonDeleteUser.TabIndex = 1;
            this.buttonDeleteUser.Text = "Xóa User";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonEditPasswordUser
            // 
            this.buttonEditPasswordUser.Location = new System.Drawing.Point(16, 187);
            this.buttonEditPasswordUser.Name = "buttonEditPasswordUser";
            this.buttonEditPasswordUser.Size = new System.Drawing.Size(114, 60);
            this.buttonEditPasswordUser.TabIndex = 2;
            this.buttonEditPasswordUser.Text = "Sửa mật khẩu User";
            this.buttonEditPasswordUser.UseVisualStyleBackColor = true;
            this.buttonEditPasswordUser.Click += new System.EventHandler(this.buttonEditPasswordUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.listBoxUser);
            this.panel1.Location = new System.Drawing.Point(153, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 596);
            this.panel1.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(3, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(68, 29);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "User";
            // 
            // listBoxUser
            // 
            this.listBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.ItemHeight = 25;
            this.listBoxUser.Location = new System.Drawing.Point(8, 39);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(210, 554);
            this.listBoxUser.TabIndex = 0;
            this.listBoxUser.SelectedIndexChanged += new System.EventHandler(this.listBoxUser_SelectedIndexChanged);
            // 
            // tabRole
            // 
            this.tabRole.BackColor = System.Drawing.Color.LightCyan;
            this.tabRole.Controls.Add(this.panel6);
            this.tabRole.Controls.Add(this.panel5);
            this.tabRole.Controls.Add(this.panel3);
            this.tabRole.Location = new System.Drawing.Point(4, 25);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRole.Size = new System.Drawing.Size(1405, 682);
            this.tabRole.TabIndex = 1;
            this.tabRole.Text = "Role";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.listBoxRole);
            this.panel6.Location = new System.Drawing.Point(148, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(232, 596);
            this.panel6.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 29);
            this.label12.TabIndex = 3;
            this.label12.Text = "Role";
            // 
            // listBoxRole
            // 
            this.listBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRole.FormattingEnabled = true;
            this.listBoxRole.ItemHeight = 25;
            this.listBoxRole.Location = new System.Drawing.Point(13, 42);
            this.listBoxRole.Name = "listBoxRole";
            this.listBoxRole.Size = new System.Drawing.Size(211, 554);
            this.listBoxRole.TabIndex = 2;
            this.listBoxRole.SelectedIndexChanged += new System.EventHandler(this.listBoxRole_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.buttonAddRole);
            this.panel5.Controls.Add(this.buttonDeleteRole);
            this.panel5.Location = new System.Drawing.Point(12, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(138, 596);
            this.panel5.TabIndex = 6;
            // 
            // buttonAddRole
            // 
            this.buttonAddRole.Location = new System.Drawing.Point(14, 9);
            this.buttonAddRole.Name = "buttonAddRole";
            this.buttonAddRole.Size = new System.Drawing.Size(92, 60);
            this.buttonAddRole.TabIndex = 0;
            this.buttonAddRole.Text = "Thêm Role";
            this.buttonAddRole.UseVisualStyleBackColor = true;
            this.buttonAddRole.Click += new System.EventHandler(this.buttonAddRole_Click);
            // 
            // buttonDeleteRole
            // 
            this.buttonDeleteRole.Location = new System.Drawing.Point(14, 93);
            this.buttonDeleteRole.Name = "buttonDeleteRole";
            this.buttonDeleteRole.Size = new System.Drawing.Size(92, 63);
            this.buttonDeleteRole.TabIndex = 1;
            this.buttonDeleteRole.Text = "Xóa Role";
            this.buttonDeleteRole.UseVisualStyleBackColor = true;
            this.buttonDeleteRole.Click += new System.EventHandler(this.buttonDeleteRole_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.listBoxColumnRole);
            this.panel3.Controls.Add(this.dataGridViewPrivilegeRole);
            this.panel3.Controls.Add(this.buttonDeletePrivilegeRole);
            this.panel3.Controls.Add(this.buttonAddPrivilegeRole);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(401, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(709, 596);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Column";
            // 
            // listBoxColumnRole
            // 
            this.listBoxColumnRole.FormattingEnabled = true;
            this.listBoxColumnRole.ItemHeight = 16;
            this.listBoxColumnRole.Location = new System.Drawing.Point(503, 244);
            this.listBoxColumnRole.Name = "listBoxColumnRole";
            this.listBoxColumnRole.Size = new System.Drawing.Size(188, 324);
            this.listBoxColumnRole.TabIndex = 14;
            // 
            // dataGridViewPrivilegeRole
            // 
            this.dataGridViewPrivilegeRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrivilegeRole.Location = new System.Drawing.Point(23, 126);
            this.dataGridViewPrivilegeRole.Name = "dataGridViewPrivilegeRole";
            this.dataGridViewPrivilegeRole.RowHeadersWidth = 51;
            this.dataGridViewPrivilegeRole.RowTemplate.Height = 24;
            this.dataGridViewPrivilegeRole.Size = new System.Drawing.Size(454, 442);
            this.dataGridViewPrivilegeRole.TabIndex = 13;
            this.dataGridViewPrivilegeRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrivilegeRole_CellClick);
            // 
            // buttonDeletePrivilegeRole
            // 
            this.buttonDeletePrivilegeRole.Location = new System.Drawing.Point(152, 9);
            this.buttonDeletePrivilegeRole.Name = "buttonDeletePrivilegeRole";
            this.buttonDeletePrivilegeRole.Size = new System.Drawing.Size(136, 45);
            this.buttonDeletePrivilegeRole.TabIndex = 12;
            this.buttonDeletePrivilegeRole.Text = "Xóa Quyền";
            this.buttonDeletePrivilegeRole.UseVisualStyleBackColor = true;
            this.buttonDeletePrivilegeRole.Click += new System.EventHandler(this.buttonDeletePrivilegeRole_Click);
            // 
            // buttonAddPrivilegeRole
            // 
            this.buttonAddPrivilegeRole.Location = new System.Drawing.Point(23, 9);
            this.buttonAddPrivilegeRole.Name = "buttonAddPrivilegeRole";
            this.buttonAddPrivilegeRole.Size = new System.Drawing.Size(123, 45);
            this.buttonAddPrivilegeRole.TabIndex = 11;
            this.buttonAddPrivilegeRole.Text = "Thêm Quyền";
            this.buttonAddPrivilegeRole.UseVisualStyleBackColor = true;
            this.buttonAddPrivilegeRole.Click += new System.EventHandler(this.buttonAddPrivilegeRole_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Privilege";
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 697);
            this.Controls.Add(this.tabControl);
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.fManager_Load);
            this.tabControl.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrivilegeUser)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabRole.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrivilegeRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonEditPasswordUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ListBox listBoxColumnUser;
        private System.Windows.Forms.Button buttonRemoveUserFromRole;
        private System.Windows.Forms.Button buttonAddUsertoRole;
        private System.Windows.Forms.Button buttonRemovePrivilegeUser;
        private System.Windows.Forms.Button buttonAddPrivilegeUser;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonAddRole;
        private System.Windows.Forms.Button buttonDeleteRole;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDeletePrivilegeRole;
        private System.Windows.Forms.Button buttonAddPrivilegeRole;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxRole;
        private System.Windows.Forms.DataGridView dataGridViewPrivilegeUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRoleOfUser;
        private System.Windows.Forms.DataGridView dataGridViewPrivilegeRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxColumnRole;
    }
}