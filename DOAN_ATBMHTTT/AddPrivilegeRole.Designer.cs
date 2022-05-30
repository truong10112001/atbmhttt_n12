
namespace DOAN_ATBMHTTT
{
    partial class AddPrivilegeRole
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
            this.allColumn = new System.Windows.Forms.CheckBox();
            this.checkedListBoxColumn = new System.Windows.Forms.CheckedListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTableUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrivilegeUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // allColumn
            // 
            this.allColumn.AutoSize = true;
            this.allColumn.Location = new System.Drawing.Point(109, 228);
            this.allColumn.Name = "allColumn";
            this.allColumn.Size = new System.Drawing.Size(96, 21);
            this.allColumn.TabIndex = 18;
            this.allColumn.Text = "All Column";
            this.allColumn.UseVisualStyleBackColor = true;
            this.allColumn.CheckedChanged += new System.EventHandler(this.allColumn_CheckedChanged);
            // 
            // checkedListBoxColumn
            // 
            this.checkedListBoxColumn.FormattingEnabled = true;
            this.checkedListBoxColumn.Location = new System.Drawing.Point(109, 115);
            this.checkedListBoxColumn.Name = "checkedListBoxColumn";
            this.checkedListBoxColumn.Size = new System.Drawing.Size(259, 106);
            this.checkedListBoxColumn.TabIndex = 17;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(293, 255);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Table";
            // 
            // comboBoxTableUser
            // 
            this.comboBoxTableUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableUser.FormattingEnabled = true;
            this.comboBoxTableUser.Location = new System.Drawing.Point(109, 72);
            this.comboBoxTableUser.Name = "comboBoxTableUser";
            this.comboBoxTableUser.Size = new System.Drawing.Size(259, 24);
            this.comboBoxTableUser.TabIndex = 12;
            this.comboBoxTableUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Privilege";
            // 
            // comboBoxPrivilegeUser
            // 
            this.comboBoxPrivilegeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivilegeUser.FormattingEnabled = true;
            this.comboBoxPrivilegeUser.Location = new System.Drawing.Point(109, 23);
            this.comboBoxPrivilegeUser.Name = "comboBoxPrivilegeUser";
            this.comboBoxPrivilegeUser.Size = new System.Drawing.Size(259, 24);
            this.comboBoxPrivilegeUser.TabIndex = 10;
            // 
            // AddPrivilegeRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 298);
            this.Controls.Add(this.allColumn);
            this.Controls.Add(this.checkedListBoxColumn);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTableUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPrivilegeUser);
            this.Name = "AddPrivilegeRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPrivilegeRole";
            this.Load += new System.EventHandler(this.AddPrivilegeRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox allColumn;
        private System.Windows.Forms.CheckedListBox checkedListBoxColumn;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTableUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPrivilegeUser;
    }
}