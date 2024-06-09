namespace AP_1_GSB.Visiteur
{
    partial class AjouterNoteDeFrais
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectionFrais = new System.Windows.Forms.ComboBox();
            this.SelectionTypeForfait = new System.Windows.Forms.ComboBox();
            this.DateFrais = new System.Windows.Forms.DateTimePicker();
            this.QuantiteMontant = new System.Windows.Forms.NumericUpDown();
            this.AjouterJustificatif = new System.Windows.Forms.Button();
            this.DescriptionHorsForfait = new System.Windows.Forms.RichTextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteMontant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(875, 14);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(46, 53);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 81);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Création d\'une note de frais";
            // 
            // SelectionFrais
            // 
            this.SelectionFrais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectionFrais.FormattingEnabled = true;
            this.SelectionFrais.Items.AddRange(new object[] {
            "Frais forfait",
            "Frais hors forfait"});
            this.SelectionFrais.Location = new System.Drawing.Point(25, 129);
            this.SelectionFrais.Name = "SelectionFrais";
            this.SelectionFrais.Size = new System.Drawing.Size(121, 24);
            this.SelectionFrais.TabIndex = 9;
            this.SelectionFrais.SelectionChangeCommitted += new System.EventHandler(this.SelectionFrais_ChangementElement);
            // 
            // SelectionTypeForfait
            // 
            this.SelectionTypeForfait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectionTypeForfait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionTypeForfait.FormattingEnabled = true;
            this.SelectionTypeForfait.Items.AddRange(new object[] {
            "Nuitée",
            "Repas",
            "Frais kilométrique"});
            this.SelectionTypeForfait.Location = new System.Drawing.Point(251, 129);
            this.SelectionTypeForfait.Name = "SelectionTypeForfait";
            this.SelectionTypeForfait.Size = new System.Drawing.Size(121, 24);
            this.SelectionTypeForfait.TabIndex = 12;
            // 
            // DateFrais
            // 
            this.DateFrais.Location = new System.Drawing.Point(251, 239);
            this.DateFrais.Margin = new System.Windows.Forms.Padding(4);
            this.DateFrais.Name = "DateFrais";
            this.DateFrais.Size = new System.Drawing.Size(233, 21);
            this.DateFrais.TabIndex = 13;
            // 
            // QuantiteMontant
            // 
            this.QuantiteMontant.Location = new System.Drawing.Point(251, 187);
            this.QuantiteMontant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.QuantiteMontant.Name = "QuantiteMontant";
            this.QuantiteMontant.Size = new System.Drawing.Size(120, 21);
            this.QuantiteMontant.TabIndex = 14;
            // 
            // AjouterJustificatif
            // 
            this.AjouterJustificatif.Location = new System.Drawing.Point(251, 295);
            this.AjouterJustificatif.Name = "AjouterJustificatif";
            this.AjouterJustificatif.Size = new System.Drawing.Size(130, 23);
            this.AjouterJustificatif.TabIndex = 15;
            this.AjouterJustificatif.Text = "Ajouter un justificatif";
            this.AjouterJustificatif.UseVisualStyleBackColor = true;
            this.AjouterJustificatif.Click += new System.EventHandler(this.AjouterJustificatif_Clique);
            // 
            // DescriptionHorsForfait
            // 
            this.DescriptionHorsForfait.Location = new System.Drawing.Point(251, 159);
            this.DescriptionHorsForfait.Name = "DescriptionHorsForfait";
            this.DescriptionHorsForfait.Size = new System.Drawing.Size(100, 24);
            this.DescriptionHorsForfait.TabIndex = 16;
            this.DescriptionHorsForfait.Text = "";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(251, 361);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 17;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // AjouterNoteDeFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.DescriptionHorsForfait);
            this.Controls.Add(this.AjouterJustificatif);
            this.Controls.Add(this.QuantiteMontant);
            this.Controls.Add(this.DateFrais);
            this.Controls.Add(this.SelectionTypeForfait);
            this.Controls.Add(this.SelectionFrais);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjouterNoteDeFrais";
            this.Text = "AjouterNoteDeFrais";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteMontant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectionFrais;
        private System.Windows.Forms.ComboBox SelectionTypeForfait;
        private System.Windows.Forms.DateTimePicker DateFrais;
        private System.Windows.Forms.NumericUpDown QuantiteMontant;
        private System.Windows.Forms.Button AjouterJustificatif;
        private System.Windows.Forms.RichTextBox DescriptionHorsForfait;
        private System.Windows.Forms.Button btnValider;
    }
}