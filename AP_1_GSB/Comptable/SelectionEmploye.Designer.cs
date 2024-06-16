namespace AP_1_GSB.Comptable
{
    partial class SelectionEmploye
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewAffichageUtilisateurs = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez rechercher un utilisateur pour agir sur ces fiches";
            // 
            // listViewAffichageUtilisateurs
            // 
            this.listViewAffichageUtilisateurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom});
            this.listViewAffichageUtilisateurs.FullRowSelect = true;
            this.listViewAffichageUtilisateurs.GridLines = true;
            this.listViewAffichageUtilisateurs.HideSelection = false;
            this.listViewAffichageUtilisateurs.Location = new System.Drawing.Point(53, 85);
            this.listViewAffichageUtilisateurs.Name = "listViewAffichageUtilisateurs";
            this.listViewAffichageUtilisateurs.Size = new System.Drawing.Size(1043, 461);
            this.listViewAffichageUtilisateurs.TabIndex = 1;
            this.listViewAffichageUtilisateurs.UseCompatibleStateImageBehavior = false;
            this.listViewAffichageUtilisateurs.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 123;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 195;
            // 
            // AffichageComptable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 918);
            this.Controls.Add(this.listViewAffichageUtilisateurs);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AffichageComptable";
            this.Text = "abel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewAffichageUtilisateurs;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
    }
}