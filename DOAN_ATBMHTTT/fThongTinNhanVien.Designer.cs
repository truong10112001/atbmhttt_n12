
namespace DOAN_ATBMHTTT
{
    partial class fThongTinNhanVien
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
            this.dataGridViewfThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewfThongTinNhanVien
            // 
            this.dataGridViewfThongTinNhanVien.ColumnHeadersHeight = 29;
            this.dataGridViewfThongTinNhanVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewfThongTinNhanVien.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewfThongTinNhanVien.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewfThongTinNhanVien.Name = "dataGridViewfThongTinNhanVien";
            this.dataGridViewfThongTinNhanVien.RowHeadersWidth = 51;
            this.dataGridViewfThongTinNhanVien.RowTemplate.Height = 24;
            this.dataGridViewfThongTinNhanVien.Size = new System.Drawing.Size(358, 479);
            this.dataGridViewfThongTinNhanVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER";
            // 
            // fThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(360, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewfThongTinNhanVien);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "fThongTinNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User";
            this.Load += new System.EventHandler(this.fThongTinNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewfThongTinNhanVien;
        private System.Windows.Forms.Label label1;
    }
}