namespace AP_1_GSB.Visiteur
{
    partial class NoteFraisDuMois
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
            this.DateFicheFrais = new System.Windows.Forms.Label();
            this.ListViewForfait = new System.Windows.Forms.ListView();
            this.ID_Frais_Forfait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type_frais_forfait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Justificatif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHorsForfait = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Montant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHorsForfait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EtatHF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JustificatifHF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateFicheFrais
            // 
            this.DateFicheFrais.AutoSize = true;
            this.DateFicheFrais.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFicheFrais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.DateFicheFrais.Location = new System.Drawing.Point(399, 26);
            this.DateFicheFrais.Name = "DateFicheFrais";
            this.DateFicheFrais.Size = new System.Drawing.Size(460, 24);
            this.DateFicheFrais.TabIndex = 0;
            this.DateFicheFrais.Text = "Fiche de frais du 10 Mai 2025 au 00 Mai 2025";
            // 
            // ListViewForfait
            // 
            this.ListViewForfait.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Frais_Forfait,
            this.Type_frais_forfait,
            this.Quantite,
            this.Date,
            this.Etat,
            this.Justificatif});
            this.ListViewForfait.HideSelection = false;
            this.ListViewForfait.Location = new System.Drawing.Point(38, 124);
            this.ListViewForfait.Name = "ListViewForfait";
            this.ListViewForfait.Size = new System.Drawing.Size(1207, 357);
            this.ListViewForfait.TabIndex = 1;
            this.ListViewForfait.UseCompatibleStateImageBehavior = false;
            this.ListViewForfait.View = System.Windows.Forms.View.Details;
            // 
            // ID_Frais_Forfait
            // 
            this.ID_Frais_Forfait.Text = "ID";
            this.ID_Frais_Forfait.Width = 200;
            // 
            // Type_frais_forfait
            // 
            this.Type_frais_forfait.Text = "Type frais forfait";
            this.Type_frais_forfait.Width = 200;
            // 
            // Quantite
            // 
            this.Quantite.Text = "Quantite";
            this.Quantite.Width = 200;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 200;
            // 
            // Etat
            // 
            this.Etat.Text = "Etat";
            this.Etat.Width = 200;
            // 
            // Justificatif
            // 
            this.Justificatif.Text = "Justificatif";
            this.Justificatif.Width = 200;
            // 
            // listViewHorsForfait
            // 
            this.listViewHorsForfait.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Description,
            this.Montant,
            this.DateHorsForfait,
            this.EtatHF,
            this.JustificatifHF});
            this.listViewHorsForfait.HideSelection = false;
            this.listViewHorsForfait.Location = new System.Drawing.Point(38, 538);
            this.listViewHorsForfait.Name = "listViewHorsForfait";
            this.listViewHorsForfait.Size = new System.Drawing.Size(1207, 354);
            this.listViewHorsForfait.TabIndex = 2;
            this.listViewHorsForfait.UseCompatibleStateImageBehavior = false;
            this.listViewHorsForfait.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 200;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Description.Width = 200;
            // 
            // Montant
            // 
            this.Montant.Text = "Montant";
            this.Montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Montant.Width = 200;
            // 
            // DateHorsForfait
            // 
            this.DateHorsForfait.Text = "Date";
            this.DateHorsForfait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateHorsForfait.Width = 200;
            // 
            // EtatHF
            // 
            this.EtatHF.Text = "Etat";
            this.EtatHF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EtatHF.Width = 200;
            // 
            // JustificatifHF
            // 
            this.JustificatifHF.Text = "Justificatif";
            this.JustificatifHF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JustificatifHF.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note de frais forfait";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note de frais hors forfait";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1045, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(351, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // NoteFraisDuMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1314, 918);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewHorsForfait);
            this.Controls.Add(this.ListViewForfait);
            this.Controls.Add(this.DateFicheFrais);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteFraisDuMois";
            this.Text = "AjouterNoteFrais";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateFicheFrais;
        private System.Windows.Forms.ListView ListViewForfait;
        private System.Windows.Forms.ColumnHeader Type_frais_forfait;
        private System.Windows.Forms.ColumnHeader Quantite;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Justificatif;
        private System.Windows.Forms.ListView listViewHorsForfait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader ID_Frais_Forfait;
        private System.Windows.Forms.ColumnHeader Etat;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Montant;
        private System.Windows.Forms.ColumnHeader DateHorsForfait;
        private System.Windows.Forms.ColumnHeader EtatHF;
        private System.Windows.Forms.ColumnHeader JustificatifHF;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}