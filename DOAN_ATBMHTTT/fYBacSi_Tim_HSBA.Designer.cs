
namespace DOAN_ATBMHTTT
{
    partial class fYBacSi_Tim_HSBA
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
            this.dataGridViewHSBA = new System.Windows.Forms.DataGridView();
            this.dataGridViewHSBA_DV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHSBA
            // 
            this.dataGridViewHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHSBA.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewHSBA.Name = "dataGridViewHSBA";
            this.dataGridViewHSBA.RowHeadersWidth = 51;
            this.dataGridViewHSBA.RowTemplate.Height = 24;
            this.dataGridViewHSBA.Size = new System.Drawing.Size(607, 209);
            this.dataGridViewHSBA.TabIndex = 0;
            this.dataGridViewHSBA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHSBA_CellClick);
            // 
            // dataGridViewHSBA_DV
            // 
            this.dataGridViewHSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHSBA_DV.Location = new System.Drawing.Point(12, 294);
            this.dataGridViewHSBA_DV.Name = "dataGridViewHSBA_DV";
            this.dataGridViewHSBA_DV.RowHeadersWidth = 51;
            this.dataGridViewHSBA_DV.RowTemplate.Height = 24;
            this.dataGridViewHSBA_DV.Size = new System.Drawing.Size(607, 233);
            this.dataGridViewHSBA_DV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "HSBA_DV của HSBA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "HSBA";
            // 
            // fYBacSi_Tim_HSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(631, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHSBA_DV);
            this.Controls.Add(this.dataGridViewHSBA);
            this.Name = "fYBacSi_Tim_HSBA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HSBA";
            this.Load += new System.EventHandler(this.fYBacSi_Tim_HSBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA_DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHSBA;
        private System.Windows.Forms.DataGridView dataGridViewHSBA_DV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}