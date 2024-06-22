//namespace AP_1_GSB.Visiteur
//{
//    partial class CreerModifierNotesFrais
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.btnQuitter = new System.Windows.Forms.Button();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.label1 = new System.Windows.Forms.Label();
//            this.ComboBoxCategorieFrais = new System.Windows.Forms.ComboBox();
//            this.SelectionTypeForfait = new System.Windows.Forms.ComboBox();
//            this.DateFrais = new System.Windows.Forms.DateTimePicker();
//            this.QuantiteMontant = new System.Windows.Forms.NumericUpDown();
//            this.BtnJustificatif = new System.Windows.Forms.Button();
//            this.DescriptionHorsForfait = new System.Windows.Forms.RichTextBox();
//            this.btnValider = new System.Windows.Forms.Button();
//            this.LblCategorieForfait = new System.Windows.Forms.Label();
//            this.LblQuantite = new System.Windows.Forms.Label();
//            this.LblMontant = new System.Windows.Forms.Label();
//            this.LblDescription = new System.Windows.Forms.Label();
//            this.LblTypeForfait = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.QuantiteMontant)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // btnQuitter
//            // 
//            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnQuitter.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnQuitter.ForeColor = System.Drawing.Color.White;
//            this.btnQuitter.Location = new System.Drawing.Point(561, 12);
//            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
//            this.btnQuitter.Name = "btnQuitter";
//            this.btnQuitter.Size = new System.Drawing.Size(46, 45);
//            this.btnQuitter.TabIndex = 7;
//            this.btnQuitter.Text = "X";
//            this.btnQuitter.UseVisualStyleBackColor = true;
//            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
//            // 
//            // panel1
//            // 
//            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
//            this.panel1.Controls.Add(this.label1);
//            this.panel1.Controls.Add(this.btnQuitter);
//            this.panel1.Location = new System.Drawing.Point(0, 0);
//            this.panel1.Margin = new System.Windows.Forms.Padding(4);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(629, 81);
//            this.panel1.TabIndex = 8;
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.ForeColor = System.Drawing.Color.White;
//            this.label1.Location = new System.Drawing.Point(179, 25);
//            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(61, 24);
//            this.label1.TabIndex = 8;
//            this.label1.Text = "adaz";
//            // 
//            // ComboBoxCategorieFrais
//            // 
//            this.ComboBoxCategorieFrais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.ComboBoxCategorieFrais.FormattingEnabled = true;
//            this.ComboBoxCategorieFrais.Items.AddRange(new object[] {
//            "Frais forfait",
//            "Frais hors forfait"});
//            this.ComboBoxCategorieFrais.Location = new System.Drawing.Point(207, 118);
//            this.ComboBoxCategorieFrais.Name = "ComboBoxCategorieFrais";
//            this.ComboBoxCategorieFrais.Size = new System.Drawing.Size(119, 24);
//            this.ComboBoxCategorieFrais.TabIndex = 9;
//            this.ComboBoxCategorieFrais.SelectionChangeCommitted += new System.EventHandler(this.SelectionFrais_ChangementElement);
//            // 
//            // SelectionTypeForfait
//            // 
//            this.SelectionTypeForfait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.SelectionTypeForfait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.SelectionTypeForfait.FormattingEnabled = true;
//            this.SelectionTypeForfait.Location = new System.Drawing.Point(208, 169);
//            this.SelectionTypeForfait.Name = "SelectionTypeForfait";
//            this.SelectionTypeForfait.Size = new System.Drawing.Size(121, 24);
//            this.SelectionTypeForfait.TabIndex = 12;
//            // 
//            // DateFrais
//            // 
//            this.DateFrais.Location = new System.Drawing.Point(208, 270);
//            this.DateFrais.Margin = new System.Windows.Forms.Padding(4);
//            this.DateFrais.Name = "DateFrais";
//            this.DateFrais.Size = new System.Drawing.Size(203, 21);
//            this.DateFrais.TabIndex = 13;
//            // 
//            // QuantiteMontant
//            // 
//            this.QuantiteMontant.BackColor = System.Drawing.Color.White;
//            this.QuantiteMontant.Location = new System.Drawing.Point(207, 228);
//            this.QuantiteMontant.Maximum = new decimal(new int[] {
//            10000,
//            0,
//            0,
//            0});
//            this.QuantiteMontant.Name = "QuantiteMontant";
//            this.QuantiteMontant.Size = new System.Drawing.Size(120, 21);
//            this.QuantiteMontant.TabIndex = 14;
//            // 
//            // BtnJustificatif
//            // 
//            this.BtnJustificatif.Location = new System.Drawing.Point(207, 307);
//            this.BtnJustificatif.Name = "BtnJustificatif";
//            this.BtnJustificatif.Size = new System.Drawing.Size(130, 23);
//            this.BtnJustificatif.TabIndex = 15;
//            this.BtnJustificatif.Text = "Ajouter un justificatif";
//            this.BtnJustificatif.UseVisualStyleBackColor = true;
//            this.BtnJustificatif.Click += new System.EventHandler(this.AjouterJustificatif_Clique);
//            // 
//            // DescriptionHorsForfait
//            // 
//            this.DescriptionHorsForfait.Location = new System.Drawing.Point(207, 169);
//            this.DescriptionHorsForfait.Name = "DescriptionHorsForfait";
//            this.DescriptionHorsForfait.Size = new System.Drawing.Size(100, 24);
//            this.DescriptionHorsForfait.TabIndex = 16;
//            this.DescriptionHorsForfait.Text = "";
//            // 
//            // btnValider
//            // 
//            this.btnValider.Location = new System.Drawing.Point(233, 352);
//            this.btnValider.Name = "btnValider";
//            this.btnValider.Size = new System.Drawing.Size(75, 23);
//            this.btnValider.TabIndex = 17;
//            this.btnValider.Text = "Valider";
//            this.btnValider.UseVisualStyleBackColor = true;
//            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
//            // 
//            // LblCategorieForfait
//            // 
//            this.LblCategorieForfait.AutoSize = true;
//            this.LblCategorieForfait.Location = new System.Drawing.Point(207, 99);
//            this.LblCategorieForfait.Name = "LblCategorieForfait";
//            this.LblCategorieForfait.Size = new System.Drawing.Size(188, 16);
//            this.LblCategorieForfait.TabIndex = 18;
//            this.LblCategorieForfait.Text = "Sélectionner la catégorie de frais :";
//            // 
//            // LblQuantite
//            // 
//            this.LblQuantite.AutoSize = true;
//            this.LblQuantite.Location = new System.Drawing.Point(205, 209);
//            this.LblQuantite.Name = "LblQuantite";
//            this.LblQuantite.Size = new System.Drawing.Size(128, 16);
//            this.LblQuantite.TabIndex = 19;
//            this.LblQuantite.Text = "Renseigner la quantité";
//            // 
//            // LblMontant
//            // 
//            this.LblMontant.AutoSize = true;
//            this.LblMontant.Location = new System.Drawing.Point(207, 209);
//            this.LblMontant.Name = "LblMontant";
//            this.LblMontant.Size = new System.Drawing.Size(130, 16);
//            this.LblMontant.TabIndex = 20;
//            this.LblMontant.Text = "Renseigner le montant ";
//            // 
//            // LblDescription
//            // 
//            this.LblDescription.AutoSize = true;
//            this.LblDescription.Location = new System.Drawing.Point(204, 150);
//            this.LblDescription.Name = "LblDescription";
//            this.LblDescription.Size = new System.Drawing.Size(173, 16);
//            this.LblDescription.TabIndex = 21;
//            this.LblDescription.Text = "Donner une description du frais";
//            // 
//            // LblTypeForfait
//            // 
//            this.LblTypeForfait.AutoSize = true;
//            this.LblTypeForfait.Location = new System.Drawing.Point(207, 150);
//            this.LblTypeForfait.Name = "LblTypeForfait";
//            this.LblTypeForfait.Size = new System.Drawing.Size(196, 16);
//            this.LblTypeForfait.TabIndex = 22;
//            this.LblTypeForfait.Text = "Sélectionner le type de frais forfait : ";
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(207, 250);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(119, 16);
//            this.label3.TabIndex = 23;
//            this.label3.Text = "Sélectionner la date ";
//            // 
//            // CreerModifierNotesFrais
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(628, 416);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.LblTypeForfait);
//            this.Controls.Add(this.LblDescription);
//            this.Controls.Add(this.LblMontant);
//            this.Controls.Add(this.LblQuantite);
//            this.Controls.Add(this.LblCategorieForfait);
//            this.Controls.Add(this.btnValider);
//            this.Controls.Add(this.DescriptionHorsForfait);
//            this.Controls.Add(this.BtnJustificatif);
//            this.Controls.Add(this.QuantiteMontant);
//            this.Controls.Add(this.DateFrais);
//            this.Controls.Add(this.SelectionTypeForfait);
//            this.Controls.Add(this.ComboBoxCategorieFrais);
//            this.Controls.Add(this.panel1);
//            this.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Margin = new System.Windows.Forms.Padding(4);
//            this.Name = "CreerModifierNotesFrais";
//            this.Text = "AjouterNoteDeFrais";
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.QuantiteMontant)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Button btnQuitter;
//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.ComboBox ComboBoxCategorieFrais;
//        private System.Windows.Forms.ComboBox SelectionTypeForfait;
//        private System.Windows.Forms.DateTimePicker DateFrais;
//        private System.Windows.Forms.NumericUpDown QuantiteMontant;
//        private System.Windows.Forms.Button BtnJustificatif;
//        private System.Windows.Forms.RichTextBox DescriptionHorsForfait;
//        private System.Windows.Forms.Button btnValider;
//        private System.Windows.Forms.Label LblCategorieForfait;
//        private System.Windows.Forms.Label LblQuantite;
//        private System.Windows.Forms.Label LblMontant;
//        private System.Windows.Forms.Label LblDescription;
//        private System.Windows.Forms.Label LblTypeForfait;
//        private System.Windows.Forms.Label label3;
//    }
//}