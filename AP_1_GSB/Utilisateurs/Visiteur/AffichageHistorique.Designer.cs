namespace AP_1_GSB.Visiteur
{
    partial class AffichageHistorique
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageHistorique));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.DataGridHistorique = new System.Windows.Forms.DataGridView();
            this.DateFiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantFiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorique)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(342, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historique de vos fiches de frais";
            // 
            // BtnRetour
            // 
            this.BtnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.BtnRetour.FlatAppearance.BorderSize = 0;
            this.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetour.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.BtnRetour.ForeColor = System.Drawing.Color.White;
            this.BtnRetour.Image = global::AP_1_GSB.Properties.Resources.icons8_retour_25;
            this.BtnRetour.Location = new System.Drawing.Point(754, 600);
            this.BtnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(138, 48);
            this.BtnRetour.TabIndex = 2;
            this.BtnRetour.Text = "   Retour";
            this.BtnRetour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRetour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRetour.UseVisualStyleBackColor = false;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // DataGridHistorique
            // 
            this.DataGridHistorique.AllowUserToAddRows = false;
            this.DataGridHistorique.AllowUserToDeleteRows = false;
            this.DataGridHistorique.AllowUserToResizeColumns = false;
            this.DataGridHistorique.AllowUserToResizeRows = false;
            this.DataGridHistorique.BackgroundColor = System.Drawing.Color.White;
            this.DataGridHistorique.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridHistorique.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridHistorique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridHistorique.ColumnHeadersHeight = 30;
            this.DataGridHistorique.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateFiche,
            this.dataGridViewTextBoxColumn1,
            this.MontantFiche,
            this.IdFiche});
            this.DataGridHistorique.EnableHeadersVisualStyles = false;
            this.DataGridHistorique.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridHistorique.Location = new System.Drawing.Point(265, 114);
            this.DataGridHistorique.MultiSelect = false;
            this.DataGridHistorique.Name = "DataGridHistorique";
            this.DataGridHistorique.ReadOnly = true;
            this.DataGridHistorique.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridHistorique.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridHistorique.RowHeadersVisible = false;
            this.DataGridHistorique.RowHeadersWidth = 47;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridHistorique.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridHistorique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridHistorique.Size = new System.Drawing.Size(442, 203);
            this.DataGridHistorique.TabIndex = 24;
            // 
            // DateFiche
            // 
            this.DateFiche.Frozen = true;
            this.DateFiche.HeaderText = "Date";
            this.DateFiche.MinimumWidth = 6;
            this.DateFiche.Name = "DateFiche";
            this.DateFiche.ReadOnly = true;
            this.DateFiche.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateFiche.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Etat";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // MontantFiche
            // 
            this.MontantFiche.Frozen = true;
            this.MontantFiche.HeaderText = "Montant";
            this.MontantFiche.MinimumWidth = 6;
            this.MontantFiche.Name = "MontantFiche";
            this.MontantFiche.ReadOnly = true;
            this.MontantFiche.Width = 90;
            // 
            // IdFiche
            // 
            this.IdFiche.Frozen = true;
            this.IdFiche.HeaderText = "IdFiche";
            this.IdFiche.MinimumWidth = 6;
            this.IdFiche.Name = "IdFiche";
            this.IdFiche.ReadOnly = true;
            this.IdFiche.Width = 115;
            // 
            // AffichageHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.DataGridHistorique);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AffichageHistorique";
            this.Text = "AffichageHistorique";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.DataGridView DataGridHistorique;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantFiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFiche;
    }
}