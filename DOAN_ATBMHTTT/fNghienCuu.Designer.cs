﻿
namespace DOAN_ATBMHTTT
{
    partial class fNghienCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNghienCuu));
            this.buttonfNghienCuuHSBA = new System.Windows.Forms.Button();
            this.buttonfNghienCuuUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonfNghienCuuHSBA
            // 
            this.buttonfNghienCuuHSBA.BackColor = System.Drawing.Color.Green;
            this.buttonfNghienCuuHSBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfNghienCuuHSBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfNghienCuuHSBA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonfNghienCuuHSBA.Location = new System.Drawing.Point(94, 283);
            this.buttonfNghienCuuHSBA.Name = "buttonfNghienCuuHSBA";
            this.buttonfNghienCuuHSBA.Size = new System.Drawing.Size(186, 106);
            this.buttonfNghienCuuHSBA.TabIndex = 15;
            this.buttonfNghienCuuHSBA.Text = "HSBA";
            this.buttonfNghienCuuHSBA.UseVisualStyleBackColor = false;
            this.buttonfNghienCuuHSBA.Click += new System.EventHandler(this.buttonfNghienCuuHSBA_Click);
            // 
            // buttonfNghienCuuUser
            // 
            this.buttonfNghienCuuUser.BackColor = System.Drawing.Color.Green;
            this.buttonfNghienCuuUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfNghienCuuUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfNghienCuuUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonfNghienCuuUser.Location = new System.Drawing.Point(103, 195);
            this.buttonfNghienCuuUser.Name = "buttonfNghienCuuUser";
            this.buttonfNghienCuuUser.Size = new System.Drawing.Size(163, 37);
            this.buttonfNghienCuuUser.TabIndex = 14;
            this.buttonfNghienCuuUser.Text = "User";
            this.buttonfNghienCuuUser.UseVisualStyleBackColor = false;
            this.buttonfNghienCuuUser.Click += new System.EventHandler(this.buttonfNghienCuuUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // fNghienCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(369, 427);
            this.Controls.Add(this.buttonfNghienCuuHSBA);
            this.Controls.Add(this.buttonfNghienCuuUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fNghienCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fNghienCuu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonfNghienCuuHSBA;
        private System.Windows.Forms.Button buttonfNghienCuuUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}