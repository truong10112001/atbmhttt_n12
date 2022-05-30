
namespace DOAN_ATBMHTTT
{
    partial class fAddRoleOfUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddRole = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxWGO = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role";
            // 
            // textBoxAddRole
            // 
            this.textBoxAddRole.Location = new System.Drawing.Point(122, 33);
            this.textBoxAddRole.Name = "textBoxAddRole";
            this.textBoxAddRole.Size = new System.Drawing.Size(335, 22);
            this.textBoxAddRole.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(409, 63);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxWGO
            // 
            this.checkBoxWGO.AutoSize = true;
            this.checkBoxWGO.Location = new System.Drawing.Point(122, 65);
            this.checkBoxWGO.Name = "checkBoxWGO";
            this.checkBoxWGO.Size = new System.Drawing.Size(134, 21);
            this.checkBoxWGO.TabIndex = 3;
            this.checkBoxWGO.Text = "with grant option";
            this.checkBoxWGO.UseVisualStyleBackColor = true;
            // 
            // fAddRoleOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 98);
            this.Controls.Add(this.checkBoxWGO);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAddRole);
            this.Controls.Add(this.label1);
            this.Name = "fAddRoleOfUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddRoleOfUser";
            this.Load += new System.EventHandler(this.fAddRoleOfUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddRole;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxWGO;
    }
}