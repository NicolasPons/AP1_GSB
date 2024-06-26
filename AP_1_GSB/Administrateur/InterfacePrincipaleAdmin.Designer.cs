namespace AP_1_GSB.Administrateur
{
    partial class InterfacePrincipaleAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfacePrincipaleAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridUtilisateurs = new System.Windows.Forms.DataGridView();
            this.DataGridTypeFrais = new System.Windows.Forms.DataGridView();
            this.TypeFrais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTypeFrais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUtilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTypeFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(143, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des utilisateurs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(656, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liste des types de frais :";
            // 
            // DataGridUtilisateurs
            // 
            this.DataGridUtilisateurs.AllowUserToAddRows = false;
            this.DataGridUtilisateurs.AllowUserToDeleteRows = false;
            this.DataGridUtilisateurs.AllowUserToResizeColumns = false;
            this.DataGridUtilisateurs.AllowUserToResizeRows = false;
            this.DataGridUtilisateurs.BackgroundColor = System.Drawing.Color.White;
            this.DataGridUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridUtilisateurs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridUtilisateurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridUtilisateurs.ColumnHeadersHeight = 30;
            this.DataGridUtilisateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomVisiteur,
            this.PrenomVisiteur,
            this.EmailVisiteur,
            this.Role,
            this.IdUtilisateur});
            this.DataGridUtilisateurs.EnableHeadersVisualStyles = false;
            this.DataGridUtilisateurs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridUtilisateurs.Location = new System.Drawing.Point(12, 138);
            this.DataGridUtilisateurs.MultiSelect = false;
            this.DataGridUtilisateurs.Name = "DataGridUtilisateurs";
            this.DataGridUtilisateurs.ReadOnly = true;
            this.DataGridUtilisateurs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridUtilisateurs.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridUtilisateurs.RowHeadersVisible = false;
            this.DataGridUtilisateurs.RowHeadersWidth = 47;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridUtilisateurs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridUtilisateurs.Size = new System.Drawing.Size(483, 185);
            this.DataGridUtilisateurs.TabIndex = 22;
            // 
            // DataGridTypeFrais
            // 
            this.DataGridTypeFrais.AllowUserToAddRows = false;
            this.DataGridTypeFrais.AllowUserToDeleteRows = false;
            this.DataGridTypeFrais.AllowUserToResizeColumns = false;
            this.DataGridTypeFrais.AllowUserToResizeRows = false;
            this.DataGridTypeFrais.BackgroundColor = System.Drawing.Color.White;
            this.DataGridTypeFrais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridTypeFrais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTypeFrais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridTypeFrais.ColumnHeadersHeight = 30;
            this.DataGridTypeFrais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeFrais,
            this.MontantDataGrid,
            this.IdTypeFrais});
            this.DataGridTypeFrais.EnableHeadersVisualStyles = false;
            this.DataGridTypeFrais.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridTypeFrais.Location = new System.Drawing.Point(625, 138);
            this.DataGridTypeFrais.MultiSelect = false;
            this.DataGridTypeFrais.Name = "DataGridTypeFrais";
            this.DataGridTypeFrais.ReadOnly = true;
            this.DataGridTypeFrais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTypeFrais.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridTypeFrais.RowHeadersVisible = false;
            this.DataGridTypeFrais.RowHeadersWidth = 47;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridTypeFrais.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridTypeFrais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridTypeFrais.Size = new System.Drawing.Size(268, 185);
            this.DataGridTypeFrais.TabIndex = 23;
            this.DataGridTypeFrais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTypeFrais_CellContentClick);
            // 
            // TypeFrais
            // 
            this.TypeFrais.Frozen = true;
            this.TypeFrais.HeaderText = "Type de frais";
            this.TypeFrais.MinimumWidth = 6;
            this.TypeFrais.Name = "TypeFrais";
            this.TypeFrais.ReadOnly = true;
            this.TypeFrais.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TypeFrais.Width = 150;
            // 
            // MontantDataGrid
            // 
            this.MontantDataGrid.Frozen = true;
            this.MontantDataGrid.HeaderText = "Montant";
            this.MontantDataGrid.MinimumWidth = 6;
            this.MontantDataGrid.Name = "MontantDataGrid";
            this.MontantDataGrid.ReadOnly = true;
            this.MontantDataGrid.Width = 115;
            // 
            // IdTypeFrais
            // 
            this.IdTypeFrais.HeaderText = "IdTypeFrais";
            this.IdTypeFrais.MinimumWidth = 6;
            this.IdTypeFrais.Name = "IdTypeFrais";
            this.IdTypeFrais.ReadOnly = true;
            this.IdTypeFrais.Width = 115;
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
            // Role
            // 
            this.Role.Frozen = true;
            this.Role.HeaderText = "Rôle";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 115;
            // 
            // IdUtilisateur
            // 
            this.IdUtilisateur.HeaderText = "IdUtilisateur";
            this.IdUtilisateur.MinimumWidth = 6;
            this.IdUtilisateur.Name = "IdUtilisateur";
            this.IdUtilisateur.ReadOnly = true;
            this.IdUtilisateur.Width = 115;
            // 
            // InterfacePrincipaleAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.DataGridTypeFrais);
            this.Controls.Add(this.DataGridUtilisateurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfacePrincipaleAdmin";
            this.Text = "InteracePrincipaleAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUtilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTypeFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridUtilisateurs;
        private System.Windows.Forms.DataGridView DataGridTypeFrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeFrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTypeFrais;
    }
}