
namespace DOAN_ATBMHTTT
{
    partial class fThanhTra_Select
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
            this.dataGridViewfThanhTra_Select = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfThanhTra_Select)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewfThanhTra_Select
            // 
            this.dataGridViewfThanhTra_Select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfThanhTra_Select.Location = new System.Drawing.Point(4, 54);
            this.dataGridViewfThanhTra_Select.Name = "dataGridViewfThanhTra_Select";
            this.dataGridViewfThanhTra_Select.RowHeadersWidth = 51;
            this.dataGridViewfThanhTra_Select.RowTemplate.Height = 24;
            this.dataGridViewfThanhTra_Select.Size = new System.Drawing.Size(710, 528);
            this.dataGridViewfThanhTra_Select.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // fThanhTra_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(715, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewfThanhTra_Select);
            this.Name = "fThanhTra_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fThanhTra_Select";
            this.Load += new System.EventHandler(this.fThanhTra_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfThanhTra_Select)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewfThanhTra_Select;
        private System.Windows.Forms.Label label1;
    }
}