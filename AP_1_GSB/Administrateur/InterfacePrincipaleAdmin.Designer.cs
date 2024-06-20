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
            this.listViewTypeFraisForfait = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUtilisateur = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Identifiant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewTypeFraisForfait
            // 
            this.listViewTypeFraisForfait.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.montant});
            this.listViewTypeFraisForfait.FullRowSelect = true;
            this.listViewTypeFraisForfait.GridLines = true;
            this.listViewTypeFraisForfait.HideSelection = false;
            this.listViewTypeFraisForfait.Location = new System.Drawing.Point(840, 78);
            this.listViewTypeFraisForfait.Name = "listViewTypeFraisForfait";
            this.listViewTypeFraisForfait.Size = new System.Drawing.Size(208, 267);
            this.listViewTypeFraisForfait.TabIndex = 0;
            this.listViewTypeFraisForfait.UseCompatibleStateImageBehavior = false;
            this.listViewTypeFraisForfait.View = System.Windows.Forms.View.Details;
            // 
            // type
            // 
            this.type.Text = "Type de frais";
            this.type.Width = 130;
            // 
            // montant
            // 
            this.montant.Text = "Montant";
            this.montant.Width = 177;
            // 
            // listViewUtilisateur
            // 
            this.listViewUtilisateur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom,
            this.Identifiant,
            this.Role});
            this.listViewUtilisateur.FullRowSelect = true;
            this.listViewUtilisateur.GridLines = true;
            this.listViewUtilisateur.HideSelection = false;
            this.listViewUtilisateur.Location = new System.Drawing.Point(75, 78);
            this.listViewUtilisateur.Name = "listViewUtilisateur";
            this.listViewUtilisateur.Size = new System.Drawing.Size(269, 267);
            this.listViewUtilisateur.TabIndex = 1;
            this.listViewUtilisateur.UseCompatibleStateImageBehavior = false;
            this.listViewUtilisateur.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Identifiant
            // 
            this.Identifiant.Text = "Identifiant";
            this.Identifiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Role
            // 
            this.Role.Text = "Role";
            this.Role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Role.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des utilisateurs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(837, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liste des types de frais :";
            // 
            // InterfacePrincipaleAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 874);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewUtilisateur);
            this.Controls.Add(this.listViewTypeFraisForfait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfacePrincipaleAdmin";
            this.Text = "InteracePrincipaleAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTypeFraisForfait;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader montant;
        private System.Windows.Forms.ListView listViewUtilisateur;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Identifiant;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}