﻿namespace OilRefinery
{
    partial class suppliersearcher
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
            this.supplierdata = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdata)).BeginInit();
            this.SuspendLayout();
            // 
            // salemonthclose
            // 
            this.salemonthclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.salemonthclose.FlatAppearance.BorderSize = 0;
            this.salemonthclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salemonthclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salemonthclose.ForeColor = System.Drawing.Color.White;
            this.salemonthclose.Location = new System.Drawing.Point(431, 313);
            this.salemonthclose.Name = "salemonthclose";
            this.salemonthclose.Size = new System.Drawing.Size(113, 32);
            this.salemonthclose.TabIndex = 57;
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
            this.label1.TabIndex = 56;
            this.label1.Text = "Results";
            // 
            // supplierdata
            // 
            this.supplierdata.BackgroundColor = System.Drawing.SystemColors.Control;
            this.supplierdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.supplierdata.Location = new System.Drawing.Point(12, 71);
            this.supplierdata.Name = "supplierdata";
            this.supplierdata.Size = new System.Drawing.Size(541, 208);
            this.supplierdata.TabIndex = 73;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Name";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Contact";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Certificate No";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "City";
            this.Column8.Name = "Column8";
            // 
            // suppliersearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 357);
            this.Controls.Add(this.supplierdata);
            this.Controls.Add(this.salemonthclose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "suppliersearcher";
            this.Text = "suppliersearcher";
            ((System.ComponentModel.ISupportInitialize)(this.supplierdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salemonthclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView supplierdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}