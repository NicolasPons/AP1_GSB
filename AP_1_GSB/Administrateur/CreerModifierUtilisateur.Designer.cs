namespace AP_1_GSB.Administrateur
{
    partial class CreerModifierUtilisateur
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label identifiantLabel;
            System.Windows.Forms.Label mdpLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreerModifierUtilisateur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblModifierUtilisateur = new System.Windows.Forms.Label();
            this.lblCreerUtilisateur = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.identifiantTextBox = new System.Windows.Forms.TextBox();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fichesFraisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            identifiantLabel = new System.Windows.Forms.Label();
            mdpLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichesFraisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // identifiantLabel
            // 
            identifiantLabel.AutoSize = true;
            identifiantLabel.Location = new System.Drawing.Point(7, 134);
            identifiantLabel.Name = "identifiantLabel";
            identifiantLabel.Size = new System.Drawing.Size(56, 13);
            identifiantLabel.TabIndex = 5;
            identifiantLabel.Text = "Identifiant:";
            // 
            // mdpLabel
            // 
            mdpLabel.AutoSize = true;
            mdpLabel.Location = new System.Drawing.Point(32, 157);
            mdpLabel.Name = "mdpLabel";
            mdpLabel.Size = new System.Drawing.Size(31, 13);
            mdpLabel.TabIndex = 7;
            mdpLabel.Text = "Mdp:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(246, 130);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 9;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(232, 156);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 11;
            prenomLabel.Text = "Prenom:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(246, 186);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(32, 13);
            roleLabel.TabIndex = 13;
            roleLabel.Text = "Role:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(28, 186);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Controls.Add(this.lblModifierUtilisateur);
            this.panel1.Controls.Add(this.lblCreerUtilisateur);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 98);
            this.panel1.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(480, 13);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(28, 33);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // lblModifierUtilisateur
            // 
            this.lblModifierUtilisateur.AutoSize = true;
            this.lblModifierUtilisateur.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifierUtilisateur.ForeColor = System.Drawing.Color.White;
            this.lblModifierUtilisateur.Location = new System.Drawing.Point(129, 38);
            this.lblModifierUtilisateur.Name = "lblModifierUtilisateur";
            this.lblModifierUtilisateur.Size = new System.Drawing.Size(263, 23);
            this.lblModifierUtilisateur.TabIndex = 1;
            this.lblModifierUtilisateur.Text = "Modification d\'un utilisateur";
            // 
            // lblCreerUtilisateur
            // 
            this.lblCreerUtilisateur.AutoSize = true;
            this.lblCreerUtilisateur.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreerUtilisateur.ForeColor = System.Drawing.Color.White;
            this.lblCreerUtilisateur.Location = new System.Drawing.Point(145, 38);
            this.lblCreerUtilisateur.Name = "lblCreerUtilisateur";
            this.lblCreerUtilisateur.Size = new System.Drawing.Size(227, 23);
            this.lblCreerUtilisateur.TabIndex = 0;
            this.lblCreerUtilisateur.Text = "Creation d\'un utilisateur";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(184, 231);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(94, 42);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // identifiantTextBox
            // 
            this.identifiantTextBox.AccessibleDescription = "";
            this.identifiantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "Identifiant", true));
            this.identifiantTextBox.Location = new System.Drawing.Point(74, 131);
            this.identifiantTextBox.Name = "identifiantTextBox";
            this.identifiantTextBox.Size = new System.Drawing.Size(121, 20);
            this.identifiantTextBox.TabIndex = 6;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataSource = typeof(AP_1_GSB.Data.Models.Utilisateur);
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "Mdp", true));
            this.mdpTextBox.Location = new System.Drawing.Point(74, 157);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.Size = new System.Drawing.Size(121, 20);
            this.mdpTextBox.TabIndex = 8;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(294, 127);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomTextBox.TabIndex = 10;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(294, 153);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(121, 20);
            this.prenomTextBox.TabIndex = 12;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "Role", true));
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.utilisateurBindingSource, "Role", true));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Visiteur",
            "Comptable",
            "Administrateur"});
            this.roleComboBox.Location = new System.Drawing.Point(294, 183);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 21);
            this.roleComboBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(74, 183);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // fichesFraisBindingSource
            // 
            this.fichesFraisBindingSource.DataMember = "FichesFrais";
            this.fichesFraisBindingSource.DataSource = this.utilisateurBindingSource2;
            // 
            // utilisateurBindingSource2
            // 
            this.utilisateurBindingSource2.DataSource = typeof(AP_1_GSB.Data.Models.Utilisateur);
            // 
            // utilisateurBindingSource3
            // 
            this.utilisateurBindingSource3.DataSource = typeof(AP_1_GSB.Data.Models.Utilisateur);
            // 
            // utilisateurBindingSource1
            // 
            this.utilisateurBindingSource1.DataSource = typeof(AP_1_GSB.Data.Models.Utilisateur);
            // 
            // CreerModifierUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 297);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(identifiantLabel);
            this.Controls.Add(this.identifiantTextBox);
            this.Controls.Add(mdpLabel);
            this.Controls.Add(this.mdpTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreerModifierUtilisateur";
            this.Text = "CreerModifierUtilisateur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichesFraisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreerUtilisateur;
        private System.Windows.Forms.Label lblModifierUtilisateur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private System.Windows.Forms.TextBox identifiantTextBox;
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource utilisateurBindingSource3;
        private System.Windows.Forms.BindingSource utilisateurBindingSource1;
        private System.Windows.Forms.BindingSource utilisateurBindingSource2;
        private System.Windows.Forms.BindingSource fichesFraisBindingSource;
    }
}