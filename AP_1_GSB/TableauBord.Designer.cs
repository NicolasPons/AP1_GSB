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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NomPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.PanelUtilisateur = new System.Windows.Forms.Panel();
            this.BtnHistorique = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimerNote = new System.Windows.Forms.Button();
            this.btnAjouterNoteFrais = new System.Windows.Forms.Button();
            this.PanelAffichage = new System.Windows.Forms.Panel();
            this.PanelComptable = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelUtilisateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.NomPrenom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 54);
            this.panel1.TabIndex = 0;
            // 
            // NomPrenom
            // 
            this.NomPrenom.AutoSize = true;
            this.NomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NomPrenom.ForeColor = System.Drawing.Color.White;
            this.NomPrenom.Location = new System.Drawing.Point(1036, 17);
            this.NomPrenom.Name = "NomPrenom";
            this.NomPrenom.Size = new System.Drawing.Size(292, 26);
            this.NomPrenom.TabIndex = 9;
            this.NomPrenom.Text = "Bienvenue Jean Michel Jarre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tableau de bord";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AP_1_GSB.Properties.Resources._532_5328945_menu_bar_icon_white_;
            this.pictureBox1.Location = new System.Drawing.Point(42, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(1396, 6);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(39, 43);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // PanelUtilisateur
            // 
            this.PanelUtilisateur.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelUtilisateur.Controls.Add(this.PanelComptable);
            this.PanelUtilisateur.Controls.Add(this.BtnHistorique);
            this.PanelUtilisateur.Controls.Add(this.BtnModifier);
            this.PanelUtilisateur.Controls.Add(this.BtnSupprimerNote);
            this.PanelUtilisateur.Controls.Add(this.btnAjouterNoteFrais);
            this.PanelUtilisateur.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelUtilisateur.Location = new System.Drawing.Point(0, 54);
            this.PanelUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.PanelUtilisateur.Name = "PanelUtilisateur";
            this.PanelUtilisateur.Size = new System.Drawing.Size(200, 918);
            this.PanelUtilisateur.TabIndex = 1;
            // 
            // BtnHistorique
            // 
            this.BtnHistorique.Location = new System.Drawing.Point(0, 240);
            this.BtnHistorique.Name = "BtnHistorique";
            this.BtnHistorique.Size = new System.Drawing.Size(200, 74);
            this.BtnHistorique.TabIndex = 5;
            this.BtnHistorique.Text = "Afficher l\'historique";
            this.BtnHistorique.UseVisualStyleBackColor = true;
            this.BtnHistorique.Click += new System.EventHandler(this.BtnHistorique_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(0, 160);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(200, 74);
            this.BtnModifier.TabIndex = 4;
            this.BtnModifier.Text = "Modifier une note";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimerNote
            // 
            this.BtnSupprimerNote.Location = new System.Drawing.Point(0, 80);
            this.BtnSupprimerNote.Name = "BtnSupprimerNote";
            this.BtnSupprimerNote.Size = new System.Drawing.Size(200, 74);
            this.BtnSupprimerNote.TabIndex = 3;
            this.BtnSupprimerNote.Text = "Supprimer une note";
            this.BtnSupprimerNote.UseVisualStyleBackColor = true;
            this.BtnSupprimerNote.Click += new System.EventHandler(this.BtnSupprimerNote_Clique);
            // 
            // btnAjouterNoteFrais
            // 
            this.btnAjouterNoteFrais.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterNoteFrais.Location = new System.Drawing.Point(0, 0);
            this.btnAjouterNoteFrais.Name = "btnAjouterNoteFrais";
            this.btnAjouterNoteFrais.Size = new System.Drawing.Size(200, 74);
            this.btnAjouterNoteFrais.TabIndex = 2;
            this.btnAjouterNoteFrais.Text = "Ajouter des notes de frais";
            this.btnAjouterNoteFrais.UseVisualStyleBackColor = true;
            this.btnAjouterNoteFrais.Click += new System.EventHandler(this.BtnAjouterNoteFrais_Clique);
            // 
            // PanelAffichage
            // 
            this.PanelAffichage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelAffichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAffichage.Location = new System.Drawing.Point(200, 54);
            this.PanelAffichage.Name = "PanelAffichage";
            this.PanelAffichage.Size = new System.Drawing.Size(1264, 918);
            this.PanelAffichage.TabIndex = 2;
            // 
            // PanelComptable
            // 
            this.PanelComptable.Location = new System.Drawing.Point(0, 0);
            this.PanelComptable.Name = "PanelComptable";
            this.PanelComptable.Size = new System.Drawing.Size(200, 918);
            this.PanelComptable.TabIndex = 6;
            // 
            // TableauBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1464, 972);
            this.Controls.Add(this.PanelAffichage);
            this.Controls.Add(this.PanelUtilisateur);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TableauBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelUtilisateur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelUtilisateur;
        private System.Windows.Forms.Button btnAjouterNoteFrais;
        private System.Windows.Forms.Panel PanelAffichage;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NomPrenom;
        private System.Windows.Forms.Button BtnSupprimerNote;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnHistorique;
        private System.Windows.Forms.Panel PanelComptable;
    }
}