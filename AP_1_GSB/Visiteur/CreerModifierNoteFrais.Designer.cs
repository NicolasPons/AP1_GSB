namespace AP_1_GSB.Visiteur
{
    partial class CreerModifierNoteFrais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreerModifierNoteFrais));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtTimePickerForfait = new System.Windows.Forms.DateTimePicker();
            this.quantiteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxSelectionForfaitHorsForfait = new System.Windows.Forms.ComboBox();
            this.ComboBoxTypeForfait = new System.Windows.Forms.ComboBox();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnJustificatif = new System.Windows.Forms.Button();
            this.DtTimePickerHorsForfait = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.montantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTypeForfait = new System.Windows.Forms.Label();
            this.LblMontant = new System.Windows.Forms.Label();
            this.LblQuantite = new System.Windows.Forms.Label();
            this.LblCategorie = new System.Windows.Forms.Label();
            this.lblMiseAJourJustificatif = new System.Windows.Forms.Label();
            this.lblJustificatif = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.fraisForfaitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fraisHorsForfaitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fraisForfaitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fraisHorsForfaitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.74545F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "adaz";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 81);
            this.panel1.TabIndex = 9;
            // 
            // DtTimePickerForfait
            // 
            this.DtTimePickerForfait.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fraisForfaitBindingSource, "Date", true));
            this.DtTimePickerForfait.Location = new System.Drawing.Point(210, 178);
            this.DtTimePickerForfait.Name = "DtTimePickerForfait";
            this.DtTimePickerForfait.Size = new System.Drawing.Size(150, 22);
            this.DtTimePickerForfait.TabIndex = 11;
            // 
            // quantiteNumericUpDown
            // 
            this.quantiteNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fraisForfaitBindingSource, "Quantite", true));
            this.quantiteNumericUpDown.Location = new System.Drawing.Point(210, 210);
            this.quantiteNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.quantiteNumericUpDown.Name = "quantiteNumericUpDown";
            this.quantiteNumericUpDown.Size = new System.Drawing.Size(150, 22);
            this.quantiteNumericUpDown.TabIndex = 13;
            // 
            // ComboBoxSelectionForfaitHorsForfait
            // 
            this.ComboBoxSelectionForfaitHorsForfait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSelectionForfaitHorsForfait.FormattingEnabled = true;
            this.ComboBoxSelectionForfaitHorsForfait.Items.AddRange(new object[] {
            "Frais forfait",
            "Frais hors forfait"});
            this.ComboBoxSelectionForfaitHorsForfait.Location = new System.Drawing.Point(210, 115);
            this.ComboBoxSelectionForfaitHorsForfait.Name = "ComboBoxSelectionForfaitHorsForfait";
            this.ComboBoxSelectionForfaitHorsForfait.Size = new System.Drawing.Size(121, 22);
            this.ComboBoxSelectionForfaitHorsForfait.TabIndex = 14;
            this.ComboBoxSelectionForfaitHorsForfait.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectionForfaitHorsForfait_SelectedIndexChanged);
            // 
            // ComboBoxTypeForfait
            // 
            this.ComboBoxTypeForfait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTypeForfait.FormattingEnabled = true;
            this.ComboBoxTypeForfait.Location = new System.Drawing.Point(210, 148);
            this.ComboBoxTypeForfait.Name = "ComboBoxTypeForfait";
            this.ComboBoxTypeForfait.Size = new System.Drawing.Size(150, 22);
            this.ComboBoxTypeForfait.TabIndex = 15;
            // 
            // BtnValider
            // 
            this.BtnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.BtnValider.FlatAppearance.BorderSize = 0;
            this.BtnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnValider.ForeColor = System.Drawing.Color.White;
            this.BtnValider.Location = new System.Drawing.Point(210, 295);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(136, 36);
            this.BtnValider.TabIndex = 16;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = false;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnJustificatif
            // 
            this.BtnJustificatif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.BtnJustificatif.FlatAppearance.BorderSize = 0;
            this.BtnJustificatif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJustificatif.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnJustificatif.Location = new System.Drawing.Point(210, 239);
            this.BtnJustificatif.Name = "BtnJustificatif";
            this.BtnJustificatif.Size = new System.Drawing.Size(150, 23);
            this.BtnJustificatif.TabIndex = 18;
            this.BtnJustificatif.Text = "Choisir un fichier";
            this.BtnJustificatif.UseVisualStyleBackColor = false;
            this.BtnJustificatif.Click += new System.EventHandler(this.BtnJustificatif_Click);
            // 
            // DtTimePickerHorsForfait
            // 
            this.DtTimePickerHorsForfait.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fraisHorsForfaitBindingSource, "Date", true));
            this.DtTimePickerHorsForfait.Location = new System.Drawing.Point(210, 178);
            this.DtTimePickerHorsForfait.Name = "DtTimePickerHorsForfait";
            this.DtTimePickerHorsForfait.Size = new System.Drawing.Size(150, 22);
            this.DtTimePickerHorsForfait.TabIndex = 26;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fraisHorsForfaitBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(210, 143);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(199, 28);
            this.descriptionTextBox.TabIndex = 28;
            // 
            // montantNumericUpDown
            // 
            this.montantNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fraisHorsForfaitBindingSource, "Montant", true));
            this.montantNumericUpDown.DecimalPlaces = 3;
            this.montantNumericUpDown.Location = new System.Drawing.Point(210, 210);
            this.montantNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.montantNumericUpDown.Name = "montantNumericUpDown";
            this.montantNumericUpDown.Size = new System.Drawing.Size(150, 22);
            this.montantNumericUpDown.TabIndex = 30;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(158, 178);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(46, 14);
            this.LblDate.TabIndex = 31;
            this.LblDate.Text = "Date :";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(118, 151);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(86, 14);
            this.LblDescription.TabIndex = 32;
            this.LblDescription.Text = "Description :";
            // 
            // LblTypeForfait
            // 
            this.LblTypeForfait.AutoSize = true;
            this.LblTypeForfait.Location = new System.Drawing.Point(98, 153);
            this.LblTypeForfait.Name = "LblTypeForfait";
            this.LblTypeForfait.Size = new System.Drawing.Size(106, 14);
            this.LblTypeForfait.TabIndex = 33;
            this.LblTypeForfait.Text = "Type de forfait :";
            // 
            // LblMontant
            // 
            this.LblMontant.AutoSize = true;
            this.LblMontant.Location = new System.Drawing.Point(136, 212);
            this.LblMontant.Name = "LblMontant";
            this.LblMontant.Size = new System.Drawing.Size(68, 14);
            this.LblMontant.TabIndex = 34;
            this.LblMontant.Text = "Montant :";
            // 
            // LblQuantite
            // 
            this.LblQuantite.AutoSize = true;
            this.LblQuantite.Location = new System.Drawing.Point(133, 212);
            this.LblQuantite.Name = "LblQuantite";
            this.LblQuantite.Size = new System.Drawing.Size(71, 14);
            this.LblQuantite.TabIndex = 35;
            this.LblQuantite.Text = "Quantité :";
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(71, 118);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(133, 14);
            this.LblCategorie.TabIndex = 36;
            this.LblCategorie.Text = "Categorie de frais : ";
            // 
            // lblMiseAJourJustificatif
            // 
            this.lblMiseAJourJustificatif.AutoSize = true;
            this.lblMiseAJourJustificatif.Font = new System.Drawing.Font("Verdana", 6F);
            this.lblMiseAJourJustificatif.Location = new System.Drawing.Point(208, 265);
            this.lblMiseAJourJustificatif.Name = "lblMiseAJourJustificatif";
            this.lblMiseAJourJustificatif.Size = new System.Drawing.Size(201, 12);
            this.lblMiseAJourJustificatif.TabIndex = 17;
            this.lblMiseAJourJustificatif.Text = "Aucun fichier n\'a été sélectionné ...";
            // 
            // lblJustificatif
            // 
            this.lblJustificatif.AutoSize = true;
            this.lblJustificatif.Location = new System.Drawing.Point(123, 243);
            this.lblJustificatif.Name = "lblJustificatif";
            this.lblJustificatif.Size = new System.Drawing.Size(81, 14);
            this.lblJustificatif.TabIndex = 37;
            this.lblJustificatif.Text = "Justificatif : ";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Verdana", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Image = global::AP_1_GSB.Properties.Resources.icons8_fermer_50;
            this.btnQuitter.Location = new System.Drawing.Point(440, 21);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(32, 32);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // fraisForfaitBindingSource
            // 
            this.fraisForfaitBindingSource.DataSource = typeof(AP_1_GSB.Data.Models.FraisForfait);
            // 
            // fraisHorsForfaitBindingSource
            // 
            this.fraisHorsForfaitBindingSource.DataSource = typeof(AP_1_GSB.Data.Models.FraisHorsForfait);
            // 
            // CreerModifierNoteFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 376);
            this.Controls.Add(this.lblJustificatif);
            this.Controls.Add(this.LblCategorie);
            this.Controls.Add(this.LblQuantite);
            this.Controls.Add(this.LblMontant);
            this.Controls.Add(this.LblTypeForfait);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DtTimePickerForfait);
            this.Controls.Add(this.quantiteNumericUpDown);
            this.Controls.Add(this.ComboBoxSelectionForfaitHorsForfait);
            this.Controls.Add(this.ComboBoxTypeForfait);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.lblMiseAJourJustificatif);
            this.Controls.Add(this.BtnJustificatif);
            this.Controls.Add(this.DtTimePickerHorsForfait);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.montantNumericUpDown);
            this.Font = new System.Drawing.Font("Verdana", 7.781818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreerModifierNoteFrais";
            this.Text = "Créer ou Modifier une Note de Frais";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fraisForfaitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fraisHorsForfaitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource fraisForfaitBindingSource;
        private System.Windows.Forms.DateTimePicker DtTimePickerForfait;
        private System.Windows.Forms.NumericUpDown quantiteNumericUpDown;
        private System.Windows.Forms.ComboBox ComboBoxSelectionForfaitHorsForfait;
        private System.Windows.Forms.ComboBox ComboBoxTypeForfait;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnJustificatif;
        private System.Windows.Forms.BindingSource fraisHorsForfaitBindingSource;
        private System.Windows.Forms.DateTimePicker DtTimePickerHorsForfait;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.NumericUpDown montantNumericUpDown;
        #endregion

        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTypeForfait;
        private System.Windows.Forms.Label LblMontant;
        private System.Windows.Forms.Label LblQuantite;
        private System.Windows.Forms.Label LblCategorie;
        private System.Windows.Forms.Label lblMiseAJourJustificatif;
        private System.Windows.Forms.Label lblJustificatif;
    }
}
