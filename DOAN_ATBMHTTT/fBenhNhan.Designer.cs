
namespace DOAN_ATBMHTTT
{
    partial class fBenhNhan
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
            this.dataGridViewfBenhNhan = new System.Windows.Forms.DataGridView();
            this.buttonChinhSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewfBenhNhan
            // 
            this.dataGridViewfBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfBenhNhan.Location = new System.Drawing.Point(2, 69);
            this.dataGridViewfBenhNhan.Name = "dataGridViewfBenhNhan";
            this.dataGridViewfBenhNhan.RowHeadersWidth = 51;
            this.dataGridViewfBenhNhan.RowTemplate.Height = 24;
            this.dataGridViewfBenhNhan.Size = new System.Drawing.Size(400, 430);
            this.dataGridViewfBenhNhan.TabIndex = 0;
            // 
            // buttonChinhSua
            // 
            this.buttonChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChinhSua.Location = new System.Drawing.Point(12, 12);
            this.buttonChinhSua.Name = "buttonChinhSua";
            this.buttonChinhSua.Size = new System.Drawing.Size(128, 44);
            this.buttonChinhSua.TabIndex = 1;
            this.buttonChinhSua.Text = "Chỉnh sửa";
            this.buttonChinhSua.UseVisualStyleBackColor = false;
            this.buttonChinhSua.Click += new System.EventHandler(this.buttonChinhSua_Click);
            // 
            // fBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(410, 511);
            this.Controls.Add(this.buttonChinhSua);
            this.Controls.Add(this.dataGridViewfBenhNhan);
            this.Name = "fBenhNhan";
            this.Text = "fBenhNhan";
            this.Load += new System.EventHandler(this.fBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewfBenhNhan;
        private System.Windows.Forms.Button buttonChinhSua;
    }
}