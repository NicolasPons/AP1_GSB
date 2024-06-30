namespace AP_1_GSB.Comptable
{
    partial class InterfacePrincipaleComptable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfacePrincipaleComptable));
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridVisiteur = new System.Windows.Forms.DataGridView();
            this.NomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridFiche = new System.Windows.Forms.DataGridView();
            this.DateFiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantFiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiche)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(71, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sélectionner un utilisateur : ";
            // 
            // DataGridVisiteur
            // 
            this.DataGridVisiteur.AllowUserToAddRows = false;
            this.DataGridVisiteur.AllowUserToDeleteRows = false;
            this.DataGridVisiteur.AllowUserToResizeColumns = false;
            this.DataGridVisiteur.AllowUserToResizeRows = false;
            this.DataGridVisiteur.BackgroundColor = System.Drawing.Color.White;
            this.DataGridVisiteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridVisiteur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridVisiteur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridVisiteur.ColumnHeadersHeight = 30;
            this.DataGridVisiteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomVisiteur,
            this.PrenomVisiteur,
            this.EmailVisiteur,
            this.IdVisiteur});
            this.DataGridVisiteur.EnableHeadersVisualStyles = false;
            this.DataGridVisiteur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridVisiteur.Location = new System.Drawing.Point(65, 149);
            this.DataGridVisiteur.MultiSelect = false;
            this.DataGridVisiteur.Name = "DataGridVisiteur";
            this.DataGridVisiteur.ReadOnly = true;
            this.DataGridVisiteur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridVisiteur.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridVisiteur.RowHeadersVisible = false;
            this.DataGridVisiteur.RowHeadersWidth = 47;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridVisiteur.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridVisiteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridVisiteur.Size = new System.Drawing.Size(381, 228);
            this.DataGridVisiteur.TabIndex = 21;
            this.DataGridVisiteur.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridVisiteur_CellMouseClick);
            this.DataGridVisiteur.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridVisiteur_MouseClick);
            // 
            // NomVisiteur
            // 
            this.NomVisiteur.Frozen = true;
            this.NomVisiteur.HeaderText = "Nom";
            this.NomVisiteur.MinimumWidth = 6;
            this.NomVisiteur.Name = "NomVisiteur";
            this.NomVisiteur.ReadOnly = true;
            this.NomVisiteur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomVisiteur.Width = 150;
            // 
            // PrenomVisiteur
            // 
            this.PrenomVisiteur.Frozen = true;
            this.PrenomVisiteur.HeaderText = "Prénom";
            this.PrenomVisiteur.MinimumWidth = 6;
            this.PrenomVisiteur.Name = "PrenomVisiteur";
            this.PrenomVisiteur.ReadOnly = true;
            this.PrenomVisiteur.Width = 115;
            // 
            // EmailVisiteur
            // 
            this.EmailVisiteur.Frozen = true;
            this.EmailVisiteur.HeaderText = "Email";
            this.EmailVisiteur.MinimumWidth = 6;
            this.EmailVisiteur.Name = "EmailVisiteur";
            this.EmailVisiteur.ReadOnly = true;
            this.EmailVisiteur.Width = 115;
            // 
            // IdVisiteur
            // 
            this.IdVisiteur.HeaderText = "IdVisiteur";
            this.IdVisiteur.MinimumWidth = 6;
            this.IdVisiteur.Name = "IdVisiteur";
            this.IdVisiteur.ReadOnly = true;
            this.IdVisiteur.Width = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(541, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sélectionner une fiche : ";
            // 
            // DataGridFiche
            // 
            this.DataGridFiche.AllowUserToAddRows = false;
            this.DataGridFiche.AllowUserToDeleteRows = false;
            this.DataGridFiche.AllowUserToResizeColumns = false;
            this.DataGridFiche.AllowUserToResizeRows = false;
            this.DataGridFiche.BackgroundColor = System.Drawing.Color.White;
            this.DataGridFiche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridFiche.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFiche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridFiche.ColumnHeadersHeight = 30;
            this.DataGridFiche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateFiche,
            this.Etat,
            this.MontantFiche,
            this.IdFiche});
            this.DataGridFiche.EnableHeadersVisualStyles = false;
            this.DataGridFiche.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridFiche.Location = new System.Drawing.Point(545, 149);
            this.DataGridFiche.MultiSelect = false;
            this.DataGridFiche.Name = "DataGridFiche";
            this.DataGridFiche.ReadOnly = true;
            this.DataGridFiche.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFiche.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridFiche.RowHeadersVisible = false;
            this.DataGridFiche.RowHeadersWidth = 47;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFiche.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridFiche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridFiche.Size = new System.Drawing.Size(443, 208);
            this.DataGridFiche.TabIndex = 23;
            // 
            // DateFiche
            // 
            this.DateFiche.Frozen = true;
            this.DateFiche.HeaderText = "Date";
            this.DateFiche.MinimumWidth = 6;
            this.DateFiche.Name = "DateFiche";
            this.DateFiche.ReadOnly = true;
            this.DateFiche.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateFiche.Width = 190;
            // 
            // Etat
            // 
            this.Etat.Frozen = true;
            this.Etat.HeaderText = "Etat";
            this.Etat.MinimumWidth = 6;
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            this.Etat.Width = 160;
            // 
            // MontantFiche
            // 
            this.MontantFiche.Frozen = true;
            this.MontantFiche.HeaderText = "Montant";
            this.MontantFiche.MinimumWidth = 6;
            this.MontantFiche.Name = "MontantFiche";
            this.MontantFiche.ReadOnly = true;
            this.MontantFiche.Width = 115;
            // 
            // IdFiche
            // 
            this.IdFiche.Frozen = true;
            this.IdFiche.HeaderText = "IdFiche";
            this.IdFiche.MinimumWidth = 6;
            this.IdFiche.Name = "IdFiche";
            this.IdFiche.ReadOnly = true;
            this.IdFiche.Width = 74;
            // 
            // InterfacePrincipaleComptable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.DataGridFiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridVisiteur);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfacePrincipaleComptable";
            this.Text = "abel";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFiche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailVisiteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridFiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantFiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFiche;
    }
}