namespace AP_1_GSB
{
    partial class TableauBord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableauBord));
            this.panelEnTete = new System.Windows.Forms.Panel();
            this.LblTitre = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.LblNom = new System.Windows.Forms.Label();
            this.PanelUtilsateurLogo = new System.Windows.Forms.Panel();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.PanelComptable = new System.Windows.Forms.Panel();
            this.BtnRetourLoginComptable = new System.Windows.Forms.Button();
            this.BtnAfficherJustificatifComptable = new System.Windows.Forms.Button();
            this.btnAccepterFrais = new System.Windows.Forms.Button();
            this.btnRefusFrais = new System.Windows.Forms.Button();
            this.BtnAfficheFichesEmploye = new System.Windows.Forms.Button();
            this.panelAdministrateur = new System.Windows.Forms.Panel();
            this.BtnRetourLoginAdministrateur = new System.Windows.Forms.Button();
            this.btnSupprimerUtilisateur = new System.Windows.Forms.Button();
            this.btnModifierTypeFrais = new System.Windows.Forms.Button();
            this.btnAjouterTypeFrais = new System.Windows.Forms.Button();
            this.btnModifierUtilisateur = new System.Windows.Forms.Button();
            this.btnAjoutUtilisateur = new System.Windows.Forms.Button();
            this.PanelAffichage = new System.Windows.Forms.Panel();
            this.PanelUtilisateur = new System.Windows.Forms.Panel();
            this.BtnRetourLoginUtilisateur = new System.Windows.Forms.Button();
            this.BtnAfficherJustificatifUtilisateur = new System.Windows.Forms.Button();
            this.BtnAfficherHistoriqueVisiteur = new System.Windows.Forms.Button();
            this.BtnModifierNoteVisiteur = new System.Windows.Forms.Button();
            this.BtnSupprimerNoteVisiteur = new System.Windows.Forms.Button();
            this.BtnAjouterNoteFraisVisiteur = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelEnTete.SuspendLayout();
            this.PanelUtilsateurLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.PanelComptable.SuspendLayout();
            this.panelAdministrateur.SuspendLayout();
            this.PanelAffichage.SuspendLayout();
            this.PanelUtilisateur.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnTete
            // 
            this.panelEnTete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelEnTete.Controls.Add(this.LblTitre);
            this.panelEnTete.Controls.Add(this.btnQuitter);
            this.panelEnTete.Location = new System.Drawing.Point(200, 0);
            this.panelEnTete.Margin = new System.Windows.Forms.Padding(2);
            this.panelEnTete.Name = "panelEnTete";
            this.panelEnTete.Size = new System.Drawing.Size(1000, 78);
            this.panelEnTete.TabIndex = 0;
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblTitre.ForeColor = System.Drawing.Color.White;
            this.LblTitre.Location = new System.Drawing.Point(296, 19);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(289, 26);
            this.LblTitre.TabIndex = 8;
            this.LblTitre.Text = "Gestion notes de frais - GSB";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(950, 19);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(39, 43);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblNom.ForeColor = System.Drawing.Color.White;
            this.LblNom.Location = new System.Drawing.Point(71, 19);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(51, 24);
            this.LblNom.TabIndex = 9;
            this.LblNom.Text = "Nom";
            // 
            // PanelUtilsateurLogo
            // 
            this.PanelUtilsateurLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PanelUtilsateurLogo.Controls.Add(this.LblPrenom);
            this.PanelUtilsateurLogo.Controls.Add(this.LblNom);
            this.PanelUtilsateurLogo.Controls.Add(this.PictureBoxLogo);
            this.PanelUtilsateurLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUtilsateurLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelUtilsateurLogo.Name = "PanelUtilsateurLogo";
            this.PanelUtilsateurLogo.Size = new System.Drawing.Size(200, 125);
            this.PanelUtilsateurLogo.TabIndex = 7;
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblPrenom.ForeColor = System.Drawing.Color.White;
            this.LblPrenom.Location = new System.Drawing.Point(71, 45);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(77, 24);
            this.LblPrenom.TabIndex = 10;
            this.LblPrenom.Text = "Prenom";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = global::AP_1_GSB.Properties.Resources.icons8_utilisateur_50;
            this.PictureBoxLogo.Location = new System.Drawing.Point(12, 19);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(53, 50);
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // PanelComptable
            // 
            this.PanelComptable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.PanelComptable.Controls.Add(this.BtnRetourLoginComptable);
            this.PanelComptable.Controls.Add(this.BtnAfficherJustificatifComptable);
            this.PanelComptable.Controls.Add(this.btnAccepterFrais);
            this.PanelComptable.Controls.Add(this.btnRefusFrais);
            this.PanelComptable.Controls.Add(this.BtnAfficheFichesEmploye);
            this.PanelComptable.Location = new System.Drawing.Point(619, 35);
            this.PanelComptable.Name = "PanelComptable";
            this.PanelComptable.Size = new System.Drawing.Size(200, 675);
            this.PanelComptable.TabIndex = 6;
            // 
            // BtnRetourLoginComptable
            // 
            this.BtnRetourLoginComptable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRetourLoginComptable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnRetourLoginComptable.FlatAppearance.BorderSize = 0;
            this.BtnRetourLoginComptable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetourLoginComptable.Font = new System.Drawing.Font("Century Gothic", 7.2F);
            this.BtnRetourLoginComptable.ForeColor = System.Drawing.Color.White;
            this.BtnRetourLoginComptable.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetourLoginComptable.Image")));
            this.BtnRetourLoginComptable.Location = new System.Drawing.Point(0, 606);
            this.BtnRetourLoginComptable.Name = "BtnRetourLoginComptable";
            this.BtnRetourLoginComptable.Size = new System.Drawing.Size(200, 69);
            this.BtnRetourLoginComptable.TabIndex = 10;
            this.BtnRetourLoginComptable.Text = "     Déconnexion";
            this.BtnRetourLoginComptable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRetourLoginComptable.UseVisualStyleBackColor = true;
            this.BtnRetourLoginComptable.Click += new System.EventHandler(this.BtnRetourLoginComptable_Click);
            // 
            // BtnAfficherJustificatifComptable
            // 
            this.BtnAfficherJustificatifComptable.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAfficherJustificatifComptable.FlatAppearance.BorderSize = 0;
            this.BtnAfficherJustificatifComptable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficherJustificatifComptable.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherJustificatifComptable.ForeColor = System.Drawing.Color.White;
            this.BtnAfficherJustificatifComptable.Image = global::AP_1_GSB.Properties.Resources.icons8_image_25;
            this.BtnAfficherJustificatifComptable.Location = new System.Drawing.Point(0, 221);
            this.BtnAfficherJustificatifComptable.Name = "BtnAfficherJustificatifComptable";
            this.BtnAfficherJustificatifComptable.Size = new System.Drawing.Size(200, 74);
            this.BtnAfficherJustificatifComptable.TabIndex = 3;
            this.BtnAfficherJustificatifComptable.Text = "      Afficher justificatif";
            this.BtnAfficherJustificatifComptable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherJustificatifComptable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAfficherJustificatifComptable.UseVisualStyleBackColor = true;
            this.BtnAfficherJustificatifComptable.Click += new System.EventHandler(this.BtnAfficherJustificatifComptable_Click);
            // 
            // btnAccepterFrais
            // 
            this.btnAccepterFrais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccepterFrais.FlatAppearance.BorderSize = 0;
            this.btnAccepterFrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccepterFrais.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccepterFrais.ForeColor = System.Drawing.Color.White;
            this.btnAccepterFrais.Image = global::AP_1_GSB.Properties.Resources.icons8_vérifié_25;
            this.btnAccepterFrais.Location = new System.Drawing.Point(0, 147);
            this.btnAccepterFrais.Name = "btnAccepterFrais";
            this.btnAccepterFrais.Size = new System.Drawing.Size(200, 74);
            this.btnAccepterFrais.TabIndex = 2;
            this.btnAccepterFrais.Text = "      Accepter un frais";
            this.btnAccepterFrais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccepterFrais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccepterFrais.UseVisualStyleBackColor = true;
            this.btnAccepterFrais.Click += new System.EventHandler(this.btnAccepterFrais_Click);
            // 
            // btnRefusFrais
            // 
            this.btnRefusFrais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefusFrais.FlatAppearance.BorderSize = 0;
            this.btnRefusFrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefusFrais.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefusFrais.ForeColor = System.Drawing.Color.White;
            this.btnRefusFrais.Image = global::AP_1_GSB.Properties.Resources.icons8_croix_25;
            this.btnRefusFrais.Location = new System.Drawing.Point(0, 73);
            this.btnRefusFrais.Name = "btnRefusFrais";
            this.btnRefusFrais.Size = new System.Drawing.Size(200, 74);
            this.btnRefusFrais.TabIndex = 1;
            this.btnRefusFrais.Text = "       Refuser un frais";
            this.btnRefusFrais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefusFrais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefusFrais.UseVisualStyleBackColor = true;
            this.btnRefusFrais.Click += new System.EventHandler(this.btnRefusFrais_Click);
            // 
            // BtnAfficheFichesEmploye
            // 
            this.BtnAfficheFichesEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAfficheFichesEmploye.FlatAppearance.BorderSize = 0;
            this.BtnAfficheFichesEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficheFichesEmploye.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficheFichesEmploye.ForeColor = System.Drawing.Color.White;
            this.BtnAfficheFichesEmploye.Image = global::AP_1_GSB.Properties.Resources.icons8_document_252;
            this.BtnAfficheFichesEmploye.Location = new System.Drawing.Point(0, 0);
            this.BtnAfficheFichesEmploye.Name = "BtnAfficheFichesEmploye";
            this.BtnAfficheFichesEmploye.Size = new System.Drawing.Size(200, 73);
            this.BtnAfficheFichesEmploye.TabIndex = 0;
            this.BtnAfficheFichesEmploye.Text = "      Afficher la fiche";
            this.BtnAfficheFichesEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficheFichesEmploye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAfficheFichesEmploye.UseVisualStyleBackColor = true;
            this.BtnAfficheFichesEmploye.Click += new System.EventHandler(this.BtnAfficherFichesEmplye_Clique);
            // 
            // panelAdministrateur
            // 
            this.panelAdministrateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelAdministrateur.Controls.Add(this.BtnRetourLoginAdministrateur);
            this.panelAdministrateur.Controls.Add(this.btnSupprimerUtilisateur);
            this.panelAdministrateur.Controls.Add(this.btnModifierTypeFrais);
            this.panelAdministrateur.Controls.Add(this.btnAjouterTypeFrais);
            this.panelAdministrateur.Controls.Add(this.btnModifierUtilisateur);
            this.panelAdministrateur.Controls.Add(this.btnAjoutUtilisateur);
            this.panelAdministrateur.Location = new System.Drawing.Point(130, 35);
            this.panelAdministrateur.Name = "panelAdministrateur";
            this.panelAdministrateur.Size = new System.Drawing.Size(200, 675);
            this.panelAdministrateur.TabIndex = 7;
            // 
            // BtnRetourLoginAdministrateur
            // 
            this.BtnRetourLoginAdministrateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRetourLoginAdministrateur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnRetourLoginAdministrateur.FlatAppearance.BorderSize = 0;
            this.BtnRetourLoginAdministrateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetourLoginAdministrateur.Font = new System.Drawing.Font("Century Gothic", 7.2F);
            this.BtnRetourLoginAdministrateur.ForeColor = System.Drawing.Color.White;
            this.BtnRetourLoginAdministrateur.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetourLoginAdministrateur.Image")));
            this.BtnRetourLoginAdministrateur.Location = new System.Drawing.Point(0, 606);
            this.BtnRetourLoginAdministrateur.Name = "BtnRetourLoginAdministrateur";
            this.BtnRetourLoginAdministrateur.Size = new System.Drawing.Size(200, 69);
            this.BtnRetourLoginAdministrateur.TabIndex = 12;
            this.BtnRetourLoginAdministrateur.Text = "     Déconnexion";
            this.BtnRetourLoginAdministrateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRetourLoginAdministrateur.UseVisualStyleBackColor = true;
            this.BtnRetourLoginAdministrateur.Click += new System.EventHandler(this.BtnRetourLoginAdministrateur_Click);
            // 
            // btnSupprimerUtilisateur
            // 
            this.btnSupprimerUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupprimerUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnSupprimerUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerUtilisateur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerUtilisateur.Image = global::AP_1_GSB.Properties.Resources.icons8_supprimer_25;
            this.btnSupprimerUtilisateur.Location = new System.Drawing.Point(0, 288);
            this.btnSupprimerUtilisateur.Name = "btnSupprimerUtilisateur";
            this.btnSupprimerUtilisateur.Size = new System.Drawing.Size(200, 72);
            this.btnSupprimerUtilisateur.TabIndex = 4;
            this.btnSupprimerUtilisateur.Text = " Supprimer un utilisateur";
            this.btnSupprimerUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupprimerUtilisateur.UseVisualStyleBackColor = true;
            this.btnSupprimerUtilisateur.Click += new System.EventHandler(this.btnSupprimerUtilisateur_Clique);
            // 
            // btnModifierTypeFrais
            // 
            this.btnModifierTypeFrais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifierTypeFrais.FlatAppearance.BorderSize = 0;
            this.btnModifierTypeFrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierTypeFrais.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierTypeFrais.ForeColor = System.Drawing.Color.White;
            this.btnModifierTypeFrais.Image = global::AP_1_GSB.Properties.Resources.icons8_créer_un_nouveau_25;
            this.btnModifierTypeFrais.Location = new System.Drawing.Point(0, 216);
            this.btnModifierTypeFrais.Name = "btnModifierTypeFrais";
            this.btnModifierTypeFrais.Size = new System.Drawing.Size(200, 72);
            this.btnModifierTypeFrais.TabIndex = 1;
            this.btnModifierTypeFrais.Text = "  Modifier un type de frais";
            this.btnModifierTypeFrais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifierTypeFrais.UseVisualStyleBackColor = true;
            this.btnModifierTypeFrais.Click += new System.EventHandler(this.btnModifierTypeFrais_Click);
            // 
            // btnAjouterTypeFrais
            // 
            this.btnAjouterTypeFrais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjouterTypeFrais.FlatAppearance.BorderSize = 0;
            this.btnAjouterTypeFrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterTypeFrais.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterTypeFrais.ForeColor = System.Drawing.Color.White;
            this.btnAjouterTypeFrais.Image = global::AP_1_GSB.Properties.Resources.icons8_ajouter_25;
            this.btnAjouterTypeFrais.Location = new System.Drawing.Point(0, 144);
            this.btnAjouterTypeFrais.Name = "btnAjouterTypeFrais";
            this.btnAjouterTypeFrais.Size = new System.Drawing.Size(200, 72);
            this.btnAjouterTypeFrais.TabIndex = 0;
            this.btnAjouterTypeFrais.Text = "  Ajouter un type de frais";
            this.btnAjouterTypeFrais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterTypeFrais.UseVisualStyleBackColor = true;
            this.btnAjouterTypeFrais.Click += new System.EventHandler(this.btnAjouterTypeFrais_Clique);
            // 
            // btnModifierUtilisateur
            // 
            this.btnModifierUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifierUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnModifierUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierUtilisateur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnModifierUtilisateur.Image = global::AP_1_GSB.Properties.Resources.icons8_créer_un_nouveau_25;
            this.btnModifierUtilisateur.Location = new System.Drawing.Point(0, 72);
            this.btnModifierUtilisateur.Name = "btnModifierUtilisateur";
            this.btnModifierUtilisateur.Size = new System.Drawing.Size(200, 72);
            this.btnModifierUtilisateur.TabIndex = 3;
            this.btnModifierUtilisateur.Text = "    Modifier un utilisateur";
            this.btnModifierUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifierUtilisateur.UseVisualStyleBackColor = true;
            this.btnModifierUtilisateur.Click += new System.EventHandler(this.btnModifierUtilisateur_Clique);
            // 
            // btnAjoutUtilisateur
            // 
            this.btnAjoutUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjoutUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnAjoutUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutUtilisateur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnAjoutUtilisateur.Image = global::AP_1_GSB.Properties.Resources.icons8_ajouter_25;
            this.btnAjoutUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.btnAjoutUtilisateur.Name = "btnAjoutUtilisateur";
            this.btnAjoutUtilisateur.Size = new System.Drawing.Size(200, 72);
            this.btnAjoutUtilisateur.TabIndex = 2;
            this.btnAjoutUtilisateur.Text = "    Ajouter un utilisateur";
            this.btnAjoutUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjoutUtilisateur.UseVisualStyleBackColor = true;
            this.btnAjoutUtilisateur.Click += new System.EventHandler(this.btnAjoutUtilisateur_Clique);
            // 
            // PanelAffichage
            // 
            this.PanelAffichage.BackColor = System.Drawing.Color.Transparent;
            this.PanelAffichage.Controls.Add(this.PanelUtilisateur);
            this.PanelAffichage.Controls.Add(this.PanelComptable);
            this.PanelAffichage.Controls.Add(this.panelAdministrateur);
            this.PanelAffichage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelAffichage.Location = new System.Drawing.Point(200, 78);
            this.PanelAffichage.Name = "PanelAffichage";
            this.PanelAffichage.Size = new System.Drawing.Size(1000, 722);
            this.PanelAffichage.TabIndex = 2;
            // 
            // PanelUtilisateur
            // 
            this.PanelUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.PanelUtilisateur.Controls.Add(this.BtnRetourLoginUtilisateur);
            this.PanelUtilisateur.Controls.Add(this.BtnAfficherJustificatifUtilisateur);
            this.PanelUtilisateur.Controls.Add(this.BtnAfficherHistoriqueVisiteur);
            this.PanelUtilisateur.Controls.Add(this.BtnModifierNoteVisiteur);
            this.PanelUtilisateur.Controls.Add(this.BtnSupprimerNoteVisiteur);
            this.PanelUtilisateur.Controls.Add(this.BtnAjouterNoteFraisVisiteur);
            this.PanelUtilisateur.Location = new System.Drawing.Point(385, 35);
            this.PanelUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.PanelUtilisateur.Name = "PanelUtilisateur";
            this.PanelUtilisateur.Size = new System.Drawing.Size(200, 675);
            this.PanelUtilisateur.TabIndex = 1;
            // 
            // BtnRetourLoginUtilisateur
            // 
            this.BtnRetourLoginUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRetourLoginUtilisateur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnRetourLoginUtilisateur.FlatAppearance.BorderSize = 0;
            this.BtnRetourLoginUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetourLoginUtilisateur.Font = new System.Drawing.Font("Century Gothic", 7.2F);
            this.BtnRetourLoginUtilisateur.ForeColor = System.Drawing.Color.White;
            this.BtnRetourLoginUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetourLoginUtilisateur.Image")));
            this.BtnRetourLoginUtilisateur.Location = new System.Drawing.Point(0, 606);
            this.BtnRetourLoginUtilisateur.Name = "BtnRetourLoginUtilisateur";
            this.BtnRetourLoginUtilisateur.Size = new System.Drawing.Size(200, 69);
            this.BtnRetourLoginUtilisateur.TabIndex = 11;
            this.BtnRetourLoginUtilisateur.Text = "     Déconnexion";
            this.BtnRetourLoginUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRetourLoginUtilisateur.UseVisualStyleBackColor = true;
            this.BtnRetourLoginUtilisateur.Click += new System.EventHandler(this.BtnRetourLoginUtilisateur_Click);
            // 
            // BtnAfficherJustificatifUtilisateur
            // 
            this.BtnAfficherJustificatifUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAfficherJustificatifUtilisateur.FlatAppearance.BorderSize = 0;
            this.BtnAfficherJustificatifUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficherJustificatifUtilisateur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherJustificatifUtilisateur.ForeColor = System.Drawing.Color.White;
            this.BtnAfficherJustificatifUtilisateur.Image = global::AP_1_GSB.Properties.Resources.icons8_image_25;
            this.BtnAfficherJustificatifUtilisateur.Location = new System.Drawing.Point(0, 296);
            this.BtnAfficherJustificatifUtilisateur.Name = "BtnAfficherJustificatifUtilisateur";
            this.BtnAfficherJustificatifUtilisateur.Size = new System.Drawing.Size(200, 74);
            this.BtnAfficherJustificatifUtilisateur.TabIndex = 6;
            this.BtnAfficherJustificatifUtilisateur.Text = "   Afficher justificatif";
            this.BtnAfficherJustificatifUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAfficherJustificatifUtilisateur.UseVisualStyleBackColor = true;
            this.BtnAfficherJustificatifUtilisateur.Click += new System.EventHandler(this.BtnAfficherJustificatifUtilisateur_Click);
            // 
            // BtnAfficherHistoriqueVisiteur
            // 
            this.BtnAfficherHistoriqueVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAfficherHistoriqueVisiteur.FlatAppearance.BorderSize = 0;
            this.BtnAfficherHistoriqueVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficherHistoriqueVisiteur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherHistoriqueVisiteur.ForeColor = System.Drawing.Color.White;
            this.BtnAfficherHistoriqueVisiteur.Image = global::AP_1_GSB.Properties.Resources.icons8_document_25;
            this.BtnAfficherHistoriqueVisiteur.Location = new System.Drawing.Point(0, 222);
            this.BtnAfficherHistoriqueVisiteur.Name = "BtnAfficherHistoriqueVisiteur";
            this.BtnAfficherHistoriqueVisiteur.Size = new System.Drawing.Size(200, 74);
            this.BtnAfficherHistoriqueVisiteur.TabIndex = 5;
            this.BtnAfficherHistoriqueVisiteur.Text = "  Afficher l\'historique";
            this.BtnAfficherHistoriqueVisiteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAfficherHistoriqueVisiteur.UseVisualStyleBackColor = true;
            this.BtnAfficherHistoriqueVisiteur.Click += new System.EventHandler(this.BtnHistorique_Click);
            // 
            // BtnModifierNoteVisiteur
            // 
            this.BtnModifierNoteVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnModifierNoteVisiteur.FlatAppearance.BorderSize = 0;
            this.BtnModifierNoteVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifierNoteVisiteur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifierNoteVisiteur.ForeColor = System.Drawing.Color.White;
            this.BtnModifierNoteVisiteur.Image = global::AP_1_GSB.Properties.Resources.icons8_créer_un_nouveau_25;
            this.BtnModifierNoteVisiteur.Location = new System.Drawing.Point(0, 148);
            this.BtnModifierNoteVisiteur.Name = "BtnModifierNoteVisiteur";
            this.BtnModifierNoteVisiteur.Size = new System.Drawing.Size(200, 74);
            this.BtnModifierNoteVisiteur.TabIndex = 4;
            this.BtnModifierNoteVisiteur.Text = "  Modifier une note";
            this.BtnModifierNoteVisiteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModifierNoteVisiteur.UseVisualStyleBackColor = true;
            this.BtnModifierNoteVisiteur.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimerNoteVisiteur
            // 
            this.BtnSupprimerNoteVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSupprimerNoteVisiteur.FlatAppearance.BorderSize = 0;
            this.BtnSupprimerNoteVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimerNoteVisiteur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimerNoteVisiteur.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimerNoteVisiteur.Image = global::AP_1_GSB.Properties.Resources.icons8_supprimer_25;
            this.BtnSupprimerNoteVisiteur.Location = new System.Drawing.Point(0, 74);
            this.BtnSupprimerNoteVisiteur.Name = "BtnSupprimerNoteVisiteur";
            this.BtnSupprimerNoteVisiteur.Size = new System.Drawing.Size(200, 74);
            this.BtnSupprimerNoteVisiteur.TabIndex = 3;
            this.BtnSupprimerNoteVisiteur.Text = "  Supprimer une note";
            this.BtnSupprimerNoteVisiteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSupprimerNoteVisiteur.UseVisualStyleBackColor = true;
            this.BtnSupprimerNoteVisiteur.Click += new System.EventHandler(this.BtnSupprimerNote_Clique);
            // 
            // BtnAjouterNoteFraisVisiteur
            // 
            this.BtnAjouterNoteFraisVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAjouterNoteFraisVisiteur.FlatAppearance.BorderSize = 0;
            this.BtnAjouterNoteFraisVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouterNoteFraisVisiteur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouterNoteFraisVisiteur.ForeColor = System.Drawing.Color.White;
            this.BtnAjouterNoteFraisVisiteur.Image = global::AP_1_GSB.Properties.Resources.icons8_ajouter_25;
            this.BtnAjouterNoteFraisVisiteur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAjouterNoteFraisVisiteur.Location = new System.Drawing.Point(0, 0);
            this.BtnAjouterNoteFraisVisiteur.Name = "BtnAjouterNoteFraisVisiteur";
            this.BtnAjouterNoteFraisVisiteur.Size = new System.Drawing.Size(200, 74);
            this.BtnAjouterNoteFraisVisiteur.TabIndex = 2;
            this.BtnAjouterNoteFraisVisiteur.Text = "  Ajouter des notes de frais";
            this.BtnAjouterNoteFraisVisiteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjouterNoteFraisVisiteur.UseVisualStyleBackColor = true;
            this.BtnAjouterNoteFraisVisiteur.Click += new System.EventHandler(this.BtnAjouterNoteFrais_Clique);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelMenu.Controls.Add(this.PanelUtilsateurLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 800);
            this.panelMenu.TabIndex = 4;
            // 
            // TableauBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.PanelAffichage);
            this.Controls.Add(this.panelEnTete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TableauBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.panelEnTete.ResumeLayout(false);
            this.panelEnTete.PerformLayout();
            this.PanelUtilsateurLogo.ResumeLayout(false);
            this.PanelUtilsateurLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.PanelComptable.ResumeLayout(false);
            this.panelAdministrateur.ResumeLayout(false);
            this.PanelAffichage.ResumeLayout(false);
            this.PanelUtilisateur.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEnTete;
        private System.Windows.Forms.Panel PanelAffichage;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Panel PanelComptable;
        private System.Windows.Forms.Button BtnAfficheFichesEmploye;
        private System.Windows.Forms.Button btnRefusFrais;
        private System.Windows.Forms.Button btnAccepterFrais;
        private System.Windows.Forms.Panel panelAdministrateur;
        private System.Windows.Forms.Button btnAjouterTypeFrais;
        private System.Windows.Forms.Button btnSupprimerUtilisateur;
        private System.Windows.Forms.Button btnModifierUtilisateur;
        private System.Windows.Forms.Button btnAjoutUtilisateur;
        private System.Windows.Forms.Button btnModifierTypeFrais;
        private System.Windows.Forms.Button BtnRetourLoginComptable;
        private System.Windows.Forms.Button BtnAfficherJustificatifComptable;
        private System.Windows.Forms.Button BtnAjouterNoteFraisVisiteur;
        private System.Windows.Forms.Button BtnModifierNoteVisiteur;
        private System.Windows.Forms.Button BtnAfficherHistoriqueVisiteur;
        private System.Windows.Forms.Button BtnAfficherJustificatifUtilisateur;
        private System.Windows.Forms.Panel PanelUtilisateur;
        private System.Windows.Forms.Panel PanelUtilsateurLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnRetourLoginAdministrateur;
        private System.Windows.Forms.Button BtnRetourLoginUtilisateur;
        private System.Windows.Forms.Button BtnSupprimerNoteVisiteur;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LblPrenom;
    }
}