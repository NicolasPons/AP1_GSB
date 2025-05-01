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
            this.PanelEnTete = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTitre = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.LblNom = new System.Windows.Forms.Label();
            this.PanelUtilsateurLogo = new System.Windows.Forms.Panel();
            this.LblProfilUtilisateur = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelAdministrateur = new System.Windows.Forms.Panel();
            this.BtnRetourLoginAdministrateur = new System.Windows.Forms.Button();
            this.btnAjouterTypeFrais = new System.Windows.Forms.Button();
            this.btnAjoutUtilisateur = new System.Windows.Forms.Button();
            this.PanelAffichage = new System.Windows.Forms.Panel();
            this.PanelUtilisateur = new System.Windows.Forms.Panel();
            this.BtnRetourLoginVisiteur = new System.Windows.Forms.Button();
            this.BtnAfficherJustificatifVisiteur = new System.Windows.Forms.Button();
            this.BtnAfficherHistoriqueVisiteur = new System.Windows.Forms.Button();
            this.BtnModifierNoteVisiteur = new System.Windows.Forms.Button();
            this.BtnSupprimerNoteVisiteur = new System.Windows.Forms.Button();
            this.BtnAjouterNoteFraisVisiteur = new System.Windows.Forms.Button();
            this.PanelComptable = new System.Windows.Forms.Panel();
            this.BtnRetourLoginComptable = new System.Windows.Forms.Button();
            this.BtnAfficherJustificatifComptable = new System.Windows.Forms.Button();
            this.btnAccepterFrais = new System.Windows.Forms.Button();
            this.BtnRefusFrais = new System.Windows.Forms.Button();
            this.BtnAfficherFicheSelectionnee = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.PanelEnTete.SuspendLayout();
            this.PanelUtilsateurLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.panelAdministrateur.SuspendLayout();
            this.PanelAffichage.SuspendLayout();
            this.PanelUtilisateur.SuspendLayout();
            this.PanelComptable.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEnTete
            // 
            this.PanelEnTete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.PanelEnTete.Controls.Add(this.label1);
            this.PanelEnTete.Controls.Add(this.LblTitre);
            this.PanelEnTete.Controls.Add(this.btnQuitter);
            this.PanelEnTete.Location = new System.Drawing.Point(200, -9);
            this.PanelEnTete.Margin = new System.Windows.Forms.Padding(2);
            this.PanelEnTete.Name = "PanelEnTete";
            this.PanelEnTete.Size = new System.Drawing.Size(1000, 87);
            this.PanelEnTete.TabIndex = 0;
            this.PanelEnTete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelEnTete_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(386, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Le soin des coûts";
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblTitre.ForeColor = System.Drawing.Color.White;
            this.LblTitre.Location = new System.Drawing.Point(295, 31);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(291, 24);
            this.LblTitre.TabIndex = 8;
            this.LblTitre.Text = "Gestion des fiches de Frais - GSB";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Image = global::AP_1_GSB.Properties.Resources.icons8_fermer_la_fenêtre_50;
            this.btnQuitter.Location = new System.Drawing.Point(950, 20);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(39, 43);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblNom.ForeColor = System.Drawing.Color.White;
            this.LblNom.Location = new System.Drawing.Point(71, 9);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(42, 20);
            this.LblNom.TabIndex = 9;
            this.LblNom.Text = "Nom";
            // 
            // PanelUtilsateurLogo
            // 
            this.PanelUtilsateurLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.PanelUtilsateurLogo.Controls.Add(this.LblProfilUtilisateur);
            this.PanelUtilsateurLogo.Controls.Add(this.LblPrenom);
            this.PanelUtilsateurLogo.Controls.Add(this.LblNom);
            this.PanelUtilsateurLogo.Controls.Add(this.PictureBoxLogo);
            this.PanelUtilsateurLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUtilsateurLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelUtilsateurLogo.Name = "PanelUtilsateurLogo";
            this.PanelUtilsateurLogo.Size = new System.Drawing.Size(200, 78);
            this.PanelUtilsateurLogo.TabIndex = 7;
            // 
            // LblProfilUtilisateur
            // 
            this.LblProfilUtilisateur.AutoSize = true;
            this.LblProfilUtilisateur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfilUtilisateur.ForeColor = System.Drawing.Color.White;
            this.LblProfilUtilisateur.Location = new System.Drawing.Point(72, 59);
            this.LblProfilUtilisateur.Name = "LblProfilUtilisateur";
            this.LblProfilUtilisateur.Size = new System.Drawing.Size(74, 15);
            this.LblProfilUtilisateur.TabIndex = 11;
            this.LblProfilUtilisateur.Text = "Profil : Visiteur";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblPrenom.ForeColor = System.Drawing.Color.White;
            this.LblPrenom.Location = new System.Drawing.Point(71, 33);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(64, 20);
            this.LblPrenom.TabIndex = 10;
            this.LblPrenom.Text = "Prenom";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = global::AP_1_GSB.Properties.Resources.icons8_utilisateur_50;
            this.PictureBoxLogo.Location = new System.Drawing.Point(12, 13);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(53, 50);
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // panelAdministrateur
            // 
            this.panelAdministrateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.panelAdministrateur.Controls.Add(this.BtnRetourLoginAdministrateur);
            this.panelAdministrateur.Controls.Add(this.btnAjouterTypeFrais);
            this.panelAdministrateur.Controls.Add(this.btnAjoutUtilisateur);
            this.panelAdministrateur.Location = new System.Drawing.Point(17, 5);
            this.panelAdministrateur.Name = "panelAdministrateur";
            this.panelAdministrateur.Size = new System.Drawing.Size(200, 722);
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
            this.BtnRetourLoginAdministrateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRetourLoginAdministrateur.Location = new System.Drawing.Point(0, 653);
            this.BtnRetourLoginAdministrateur.Name = "BtnRetourLoginAdministrateur";
            this.BtnRetourLoginAdministrateur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRetourLoginAdministrateur.Size = new System.Drawing.Size(200, 69);
            this.BtnRetourLoginAdministrateur.TabIndex = 12;
            this.BtnRetourLoginAdministrateur.Text = "        Déconnexion";
            this.BtnRetourLoginAdministrateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRetourLoginAdministrateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRetourLoginAdministrateur.UseVisualStyleBackColor = true;
            this.BtnRetourLoginAdministrateur.Click += new System.EventHandler(this.BtnRetourLoginAdministrateur_Click);
            // 
            // btnAjouterTypeFrais
            // 
            this.btnAjouterTypeFrais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjouterTypeFrais.FlatAppearance.BorderSize = 0;
            this.btnAjouterTypeFrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterTypeFrais.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterTypeFrais.ForeColor = System.Drawing.Color.White;
            this.btnAjouterTypeFrais.Image = global::AP_1_GSB.Properties.Resources.icons8_ajouter_25;
            this.btnAjouterTypeFrais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterTypeFrais.Location = new System.Drawing.Point(0, 72);
            this.btnAjouterTypeFrais.Name = "btnAjouterTypeFrais";
            this.btnAjouterTypeFrais.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAjouterTypeFrais.Size = new System.Drawing.Size(200, 72);
            this.btnAjouterTypeFrais.TabIndex = 0;
            this.btnAjouterTypeFrais.Text = "  Ajouter un type de frais";
            this.btnAjouterTypeFrais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterTypeFrais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterTypeFrais.UseVisualStyleBackColor = true;
            this.btnAjouterTypeFrais.Click += new System.EventHandler(this.BtnAjouterTypeFrais_Click);
            // 
            // btnAjoutUtilisateur
            // 
            this.btnAjoutUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjoutUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnAjoutUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutUtilisateur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnAjoutUtilisateur.Image = global::AP_1_GSB.Properties.Resources.icons8_ajouter_25;
            this.btnAjoutUtilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjoutUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.btnAjoutUtilisateur.Name = "btnAjoutUtilisateur";
            this.btnAjoutUtilisateur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAjoutUtilisateur.Size = new System.Drawing.Size(200, 72);
            this.btnAjoutUtilisateur.TabIndex = 2;
            this.btnAjoutUtilisateur.Text = "    Ajouter un utilisateur";
            this.btnAjoutUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjoutUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjoutUtilisateur.UseVisualStyleBackColor = true;
            this.btnAjoutUtilisateur.Click += new System.EventHandler(this.BtnAjoutUtilisateur_Click);
            // 
            // PanelAffichage
            // 
            this.PanelAffichage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelAffichage.BackColor = System.Drawing.Color.Transparent;
            this.PanelAffichage.Controls.Add(this.panelAdministrateur);
            this.PanelAffichage.Controls.Add(this.PanelUtilisateur);
            this.PanelAffichage.Controls.Add(this.PanelComptable);
            this.PanelAffichage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelAffichage.Location = new System.Drawing.Point(200, 78);
            this.PanelAffichage.Name = "PanelAffichage";
            this.PanelAffichage.Size = new System.Drawing.Size(1000, 722);
            this.PanelAffichage.TabIndex = 2;
            // 
            // PanelUtilisateur
            // 
            this.PanelUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.PanelUtilisateur.Controls.Add(this.BtnRetourLoginVisiteur);
            this.PanelUtilisateur.Controls.Add(this.BtnAfficherJustificatifVisiteur);
            this.PanelUtilisateur.Controls.Add(this.BtnAfficherHistoriqueVisiteur);
            this.PanelUtilisateur.Controls.Add(this.BtnModifierNoteVisiteur);
            this.PanelUtilisateur.Controls.Add(this.BtnSupprimerNoteVisiteur);
            this.PanelUtilisateur.Controls.Add(this.BtnAjouterNoteFraisVisiteur);
            this.PanelUtilisateur.Location = new System.Drawing.Point(300, 4);
            this.PanelUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.PanelUtilisateur.Name = "PanelUtilisateur";
            this.PanelUtilisateur.Size = new System.Drawing.Size(200, 722);
            this.PanelUtilisateur.TabIndex = 1;
            // 
            // BtnRetourLoginVisiteur
            // 
            this.BtnRetourLoginVisiteur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRetourLoginVisiteur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnRetourLoginVisiteur.FlatAppearance.BorderSize = 0;
            this.BtnRetourLoginVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetourLoginVisiteur.Font = new System.Drawing.Font("Century Gothic", 7.2F);
            this.BtnRetourLoginVisiteur.ForeColor = System.Drawing.Color.White;
            this.BtnRetourLoginVisiteur.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetourLoginVisiteur.Image")));
            this.BtnRetourLoginVisiteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRetourLoginVisiteur.Location = new System.Drawing.Point(0, 653);
            this.BtnRetourLoginVisiteur.Name = "BtnRetourLoginVisiteur";
            this.BtnRetourLoginVisiteur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRetourLoginVisiteur.Size = new System.Drawing.Size(200, 69);
            this.BtnRetourLoginVisiteur.TabIndex = 11;
            this.BtnRetourLoginVisiteur.Text = "       Déconnexion";
            this.BtnRetourLoginVisiteur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRetourLoginVisiteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRetourLoginVisiteur.UseVisualStyleBackColor = true;
            this.BtnRetourLoginVisiteur.Click += new System.EventHandler(this.BtnRetourLoginVisiteur_Click);
            // 
            // BtnAfficherJustificatifVisiteur
            // 
            this.BtnAfficherJustificatifVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAfficherJustificatifVisiteur.FlatAppearance.BorderSize = 0;
            this.BtnAfficherJustificatifVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficherJustificatifVisiteur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherJustificatifVisiteur.ForeColor = System.Drawing.Color.White;
            this.BtnAfficherJustificatifVisiteur.Image = global::AP_1_GSB.Properties.Resources.icons8_image_25;
            this.BtnAfficherJustificatifVisiteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherJustificatifVisiteur.Location = new System.Drawing.Point(0, 296);
            this.BtnAfficherJustificatifVisiteur.Name = "BtnAfficherJustificatifVisiteur";
            this.BtnAfficherJustificatifVisiteur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAfficherJustificatifVisiteur.Size = new System.Drawing.Size(200, 74);
            this.BtnAfficherJustificatifVisiteur.TabIndex = 6;
            this.BtnAfficherJustificatifVisiteur.Text = "   Afficher justificatif";
            this.BtnAfficherJustificatifVisiteur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherJustificatifVisiteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAfficherJustificatifVisiteur.UseVisualStyleBackColor = true;
            this.BtnAfficherJustificatifVisiteur.Click += new System.EventHandler(this.BtnAfficherJustificatifVisiteur_Click);
            // 
            // BtnAfficherHistoriqueVisiteur
            // 
            this.BtnAfficherHistoriqueVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAfficherHistoriqueVisiteur.FlatAppearance.BorderSize = 0;
            this.BtnAfficherHistoriqueVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficherHistoriqueVisiteur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherHistoriqueVisiteur.ForeColor = System.Drawing.Color.White;
            this.BtnAfficherHistoriqueVisiteur.Image = global::AP_1_GSB.Properties.Resources.icons8_document_25;
            this.BtnAfficherHistoriqueVisiteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherHistoriqueVisiteur.Location = new System.Drawing.Point(0, 222);
            this.BtnAfficherHistoriqueVisiteur.Name = "BtnAfficherHistoriqueVisiteur";
            this.BtnAfficherHistoriqueVisiteur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAfficherHistoriqueVisiteur.Size = new System.Drawing.Size(200, 74);
            this.BtnAfficherHistoriqueVisiteur.TabIndex = 5;
            this.BtnAfficherHistoriqueVisiteur.Text = "  Afficher l\'historique";
            this.BtnAfficherHistoriqueVisiteur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnModifierNoteVisiteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModifierNoteVisiteur.Location = new System.Drawing.Point(0, 148);
            this.BtnModifierNoteVisiteur.Name = "BtnModifierNoteVisiteur";
            this.BtnModifierNoteVisiteur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnModifierNoteVisiteur.Size = new System.Drawing.Size(200, 74);
            this.BtnModifierNoteVisiteur.TabIndex = 4;
            this.BtnModifierNoteVisiteur.Text = " Modifier une note";
            this.BtnModifierNoteVisiteur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModifierNoteVisiteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModifierNoteVisiteur.UseVisualStyleBackColor = true;
            this.BtnModifierNoteVisiteur.Click += new System.EventHandler(this.BtnModifierNoteVisiteur_Click);
            // 
            // BtnSupprimerNoteVisiteur
            // 
            this.BtnSupprimerNoteVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSupprimerNoteVisiteur.FlatAppearance.BorderSize = 0;
            this.BtnSupprimerNoteVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimerNoteVisiteur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimerNoteVisiteur.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimerNoteVisiteur.Image = global::AP_1_GSB.Properties.Resources.icons8_effacer_25;
            this.BtnSupprimerNoteVisiteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupprimerNoteVisiteur.Location = new System.Drawing.Point(0, 74);
            this.BtnSupprimerNoteVisiteur.Name = "BtnSupprimerNoteVisiteur";
            this.BtnSupprimerNoteVisiteur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSupprimerNoteVisiteur.Size = new System.Drawing.Size(200, 74);
            this.BtnSupprimerNoteVisiteur.TabIndex = 3;
            this.BtnSupprimerNoteVisiteur.Text = " Supprimer une note";
            this.BtnSupprimerNoteVisiteur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupprimerNoteVisiteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSupprimerNoteVisiteur.UseVisualStyleBackColor = true;
            this.BtnSupprimerNoteVisiteur.Click += new System.EventHandler(this.BtnSupprimerNote_Click);
            // 
            // BtnAjouterNoteFraisVisiteur
            // 
            this.BtnAjouterNoteFraisVisiteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAjouterNoteFraisVisiteur.FlatAppearance.BorderSize = 0;
            this.BtnAjouterNoteFraisVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouterNoteFraisVisiteur.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouterNoteFraisVisiteur.ForeColor = System.Drawing.Color.White;
            this.BtnAjouterNoteFraisVisiteur.Image = global::AP_1_GSB.Properties.Resources.icons8_ajouter_25;
            this.BtnAjouterNoteFraisVisiteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjouterNoteFraisVisiteur.Location = new System.Drawing.Point(0, 0);
            this.BtnAjouterNoteFraisVisiteur.Name = "BtnAjouterNoteFraisVisiteur";
            this.BtnAjouterNoteFraisVisiteur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAjouterNoteFraisVisiteur.Size = new System.Drawing.Size(200, 74);
            this.BtnAjouterNoteFraisVisiteur.TabIndex = 2;
            this.BtnAjouterNoteFraisVisiteur.Text = " Ajouter une note";
            this.BtnAjouterNoteFraisVisiteur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjouterNoteFraisVisiteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjouterNoteFraisVisiteur.UseVisualStyleBackColor = true;
            this.BtnAjouterNoteFraisVisiteur.Click += new System.EventHandler(this.BtnAjouterNoteFrais_Click);
            // 
            // PanelComptable
            // 
            this.PanelComptable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.PanelComptable.Controls.Add(this.BtnRetourLoginComptable);
            this.PanelComptable.Controls.Add(this.BtnAfficherJustificatifComptable);
            this.PanelComptable.Controls.Add(this.btnAccepterFrais);
            this.PanelComptable.Controls.Add(this.BtnRefusFrais);
            this.PanelComptable.Controls.Add(this.BtnAfficherFicheSelectionnee);
            this.PanelComptable.Location = new System.Drawing.Point(623, 5);
            this.PanelComptable.Name = "PanelComptable";
            this.PanelComptable.Size = new System.Drawing.Size(200, 722);
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
            this.BtnRetourLoginComptable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRetourLoginComptable.Location = new System.Drawing.Point(0, 653);
            this.BtnRetourLoginComptable.Name = "BtnRetourLoginComptable";
            this.BtnRetourLoginComptable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRetourLoginComptable.Size = new System.Drawing.Size(200, 69);
            this.BtnRetourLoginComptable.TabIndex = 10;
            this.BtnRetourLoginComptable.Text = "       Déconnexion";
            this.BtnRetourLoginComptable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnAfficherJustificatifComptable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherJustificatifComptable.Location = new System.Drawing.Point(0, 221);
            this.BtnAfficherJustificatifComptable.Name = "BtnAfficherJustificatifComptable";
            this.BtnAfficherJustificatifComptable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
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
            this.btnAccepterFrais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccepterFrais.Location = new System.Drawing.Point(0, 147);
            this.btnAccepterFrais.Name = "btnAccepterFrais";
            this.btnAccepterFrais.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccepterFrais.Size = new System.Drawing.Size(200, 74);
            this.btnAccepterFrais.TabIndex = 2;
            this.btnAccepterFrais.Text = "      Accepter un frais";
            this.btnAccepterFrais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccepterFrais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccepterFrais.UseVisualStyleBackColor = true;
            this.btnAccepterFrais.Click += new System.EventHandler(this.BtnAccepterFrais_Click);
            // 
            // BtnRefusFrais
            // 
            this.BtnRefusFrais.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRefusFrais.FlatAppearance.BorderSize = 0;
            this.BtnRefusFrais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefusFrais.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefusFrais.ForeColor = System.Drawing.Color.White;
            this.BtnRefusFrais.Image = global::AP_1_GSB.Properties.Resources.icons8_croix_25;
            this.BtnRefusFrais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefusFrais.Location = new System.Drawing.Point(0, 73);
            this.BtnRefusFrais.Name = "BtnRefusFrais";
            this.BtnRefusFrais.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRefusFrais.Size = new System.Drawing.Size(200, 74);
            this.BtnRefusFrais.TabIndex = 1;
            this.BtnRefusFrais.Text = "       Refuser un frais";
            this.BtnRefusFrais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefusFrais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefusFrais.UseVisualStyleBackColor = true;
            this.BtnRefusFrais.Click += new System.EventHandler(this.BtnRefusFrais_Click);
            // 
            // BtnAfficherFicheSelectionnee
            // 
            this.BtnAfficherFicheSelectionnee.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAfficherFicheSelectionnee.FlatAppearance.BorderSize = 0;
            this.BtnAfficherFicheSelectionnee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficherFicheSelectionnee.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherFicheSelectionnee.ForeColor = System.Drawing.Color.White;
            this.BtnAfficherFicheSelectionnee.Image = global::AP_1_GSB.Properties.Resources.icons8_document_252;
            this.BtnAfficherFicheSelectionnee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherFicheSelectionnee.Location = new System.Drawing.Point(0, 0);
            this.BtnAfficherFicheSelectionnee.Name = "BtnAfficherFicheSelectionnee";
            this.BtnAfficherFicheSelectionnee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAfficherFicheSelectionnee.Size = new System.Drawing.Size(200, 73);
            this.BtnAfficherFicheSelectionnee.TabIndex = 0;
            this.BtnAfficherFicheSelectionnee.Text = "      Afficher la fiche";
            this.BtnAfficherFicheSelectionnee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherFicheSelectionnee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAfficherFicheSelectionnee.UseVisualStyleBackColor = true;
            this.BtnAfficherFicheSelectionnee.Click += new System.EventHandler(this.BtnAfficherFicheSelectionnee_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
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
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.PanelAffichage);
            this.Controls.Add(this.PanelEnTete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TableauBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelEnTete.ResumeLayout(false);
            this.PanelEnTete.PerformLayout();
            this.PanelUtilsateurLogo.ResumeLayout(false);
            this.PanelUtilsateurLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.panelAdministrateur.ResumeLayout(false);
            this.PanelAffichage.ResumeLayout(false);
            this.PanelUtilisateur.ResumeLayout(false);
            this.PanelComptable.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEnTete;
        private System.Windows.Forms.Panel PanelAffichage;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Panel panelAdministrateur;
        private System.Windows.Forms.Button btnAjouterTypeFrais;
        private System.Windows.Forms.Button btnAjoutUtilisateur;
        private System.Windows.Forms.Button BtnAjouterNoteFraisVisiteur;
        private System.Windows.Forms.Button BtnModifierNoteVisiteur;
        private System.Windows.Forms.Button BtnAfficherHistoriqueVisiteur;
        private System.Windows.Forms.Button BtnAfficherJustificatifVisiteur;
        private System.Windows.Forms.Panel PanelUtilisateur;
        private System.Windows.Forms.Panel PanelUtilsateurLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnRetourLoginAdministrateur;
        private System.Windows.Forms.Button BtnRetourLoginVisiteur;
        private System.Windows.Forms.Button BtnSupprimerNoteVisiteur;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblProfilUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelComptable;
        private System.Windows.Forms.Button BtnRetourLoginComptable;
        private System.Windows.Forms.Button BtnAfficherJustificatifComptable;
        private System.Windows.Forms.Button btnAccepterFrais;
        private System.Windows.Forms.Button BtnRefusFrais;
        private System.Windows.Forms.Button BtnAfficherFicheSelectionnee;
    }
}