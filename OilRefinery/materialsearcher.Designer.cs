namespace OilRefinery
{
    partial class materialsearcher
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
            this.salemonthclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.materialdata = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materialdata)).BeginInit();
            this.SuspendLayout();
            // 
            // salemonthclose
            // 
            this.salemonthclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.salemonthclose.FlatAppearance.BorderSize = 0;
            this.salemonthclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salemonthclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salemonthclose.ForeColor = System.Drawing.Color.White;
            this.salemonthclose.Location = new System.Drawing.Point(308, 320);
            this.salemonthclose.Name = "salemonthclose";
            this.salemonthclose.Size = new System.Drawing.Size(113, 32);
            this.salemonthclose.TabIndex = 55;
            this.salemonthclose.Text = "Close";
            this.salemonthclose.UseVisualStyleBackColor = false;
            this.salemonthclose.Click += new System.EventHandler(this.salemonthclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 45);
            this.label1.TabIndex = 54;
            this.label1.Text = "Results";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialdata
            // 
            this.materialdata.BackgroundColor = System.Drawing.SystemColors.Control;
            this.materialdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.materialdata.Location = new System.Drawing.Point(20, 57);
            this.materialdata.Name = "materialdata";
            this.materialdata.Size = new System.Drawing.Size(445, 208);
            this.materialdata.TabIndex = 73;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Plant Name";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Quantity";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Date";
            this.Column12.Name = "Column12";
            // 
            // materialsearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 361);
            this.Controls.Add(this.materialdata);
            this.Controls.Add(this.salemonthclose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "materialsearcher";
            this.Text = "materialsearcher";
            ((System.ComponentModel.ISupportInitialize)(this.materialdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salemonthclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView materialdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}