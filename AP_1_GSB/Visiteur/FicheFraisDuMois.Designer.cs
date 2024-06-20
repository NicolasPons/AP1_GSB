namespace AP_1_GSB.Visiteur
{
    partial class FicheFraisDuMois
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
            this.listViewForfait = new System.Windows.Forms.ListView();
            this.Type_frais_forfait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Justificatif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHorsForfait = new System.Windows.Forms.ListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Montant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHorsForfait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EtatHF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JustificatifHF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTotalForfait = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotalHorsForfait = new System.Windows.Forms.Label();
            this.LblTotalFiche = new System.Windows.Forms.Label();
            this.LblEmployeInfo = new System.Windows.Forms.Label();
            this.rBtnEnCours = new System.Windows.Forms.RadioButton();
            this.rBtnAccepter = new System.Windows.Forms.RadioButton();
            this.rBtnRefuser = new System.Windows.Forms.RadioButton();
            this.lblEtat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.rBtnRefusPartiel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // DateFicheFrais
            // 
            this.DateFicheFrais.AutoSize = true;
            this.DateFicheFrais.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFicheFrais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.DateFicheFrais.Location = new System.Drawing.Point(378, 18);
            this.DateFicheFrais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateFicheFrais.Name = "DateFicheFrais";
            this.DateFicheFrais.Size = new System.Drawing.Size(468, 25);
            this.DateFicheFrais.TabIndex = 0;
            this.DateFicheFrais.Text = "Fiche de frais du 10 Mai 2025 au 00 Mai 2025";
            // 
            // listViewForfait
            // 
            this.listViewForfait.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type_frais_forfait,
            this.Quantite,
            this.Date,
            this.Etat,
            this.Justificatif});
            this.listViewForfait.FullRowSelect = true;
            this.listViewForfait.GridLines = true;
            this.listViewForfait.HideSelection = false;
            this.listViewForfait.Location = new System.Drawing.Point(44, 115);
            this.listViewForfait.Margin = new System.Windows.Forms.Padding(4);
            this.listViewForfait.MultiSelect = false;
            this.listViewForfait.Name = "listViewForfait";
            this.listViewForfait.Size = new System.Drawing.Size(1155, 303);
            this.listViewForfait.TabIndex = 1;
            this.listViewForfait.UseCompatibleStateImageBehavior = false;
            this.listViewForfait.View = System.Windows.Forms.View.Details;
            this.listViewForfait.Enter += new System.EventHandler(this.listViewForfait_Enter);
            // 
            // Type_frais_forfait
            // 
            this.Type_frais_forfait.Text = "Type frais forfait";
            this.Type_frais_forfait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type_frais_forfait.Width = 230;
            // 
            // Quantite
            // 
            this.Quantite.Text = "Quantite";
            this.Quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantite.Width = 230;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 230;
            // 
            // Etat
            // 
            this.Etat.Text = "Etat";
            this.Etat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Etat.Width = 230;
            // 
            // Justificatif
            // 
            this.Justificatif.Text = "Justificatif";
            this.Justificatif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Justificatif.Width = 230;
            // 
            // listViewHorsForfait
            // 
            this.listViewHorsForfait.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Montant,
            this.DateHorsForfait,
            this.EtatHF,
            this.JustificatifHF});
            this.listViewHorsForfait.FullRowSelect = true;
            this.listViewHorsForfait.GridLines = true;
            this.listViewHorsForfait.HideSelection = false;
            this.listViewHorsForfait.Location = new System.Drawing.Point(44, 504);
            this.listViewHorsForfait.Margin = new System.Windows.Forms.Padding(4);
            this.listViewHorsForfait.MultiSelect = false;
            this.listViewHorsForfait.Name = "listViewHorsForfait";
            this.listViewHorsForfait.Size = new System.Drawing.Size(1155, 310);
            this.listViewHorsForfait.TabIndex = 2;
            this.listViewHorsForfait.UseCompatibleStateImageBehavior = false;
            this.listViewHorsForfait.View = System.Windows.Forms.View.Details;
            this.listViewHorsForfait.Enter += new System.EventHandler(this.listViewHorsForfait_Enter);
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Description.Width = 230;
            // 
            // Montant
            // 
            this.Montant.Text = "Montant";
            this.Montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Montant.Width = 230;
            // 
            // DateHorsForfait
            // 
            this.DateHorsForfait.Text = "Date";
            this.DateHorsForfait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateHorsForfait.Width = 230;
            // 
            // EtatHF
            // 
            this.EtatHF.Text = "Etat";
            this.EtatHF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EtatHF.Width = 230;
            // 
            // JustificatifHF
            // 
            this.JustificatifHF.Text = "Justificatif";
            this.JustificatifHF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JustificatifHF.Width = 230;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(39, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note de frais forfait";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(43, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note de frais hors forfait";
            // 
            // BtnPDF
            // 
            this.BtnPDF.Location = new System.Drawing.Point(1078, 59);
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.Size = new System.Drawing.Size(121, 40);
            this.BtnPDF.TabIndex = 6;
            this.BtnPDF.Text = "Export PDF";
            this.BtnPDF.UseVisualStyleBackColor = true;
            this.BtnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1052, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total frais forfait : ";
            // 
            // LblTotalForfait
            // 
            this.LblTotalForfait.AutoSize = true;
            this.LblTotalForfait.Location = new System.Drawing.Point(1156, 422);
            this.LblTotalForfait.Name = "LblTotalForfait";
            this.LblTotalForfait.Size = new System.Drawing.Size(43, 16);
            this.LblTotalForfait.TabIndex = 8;
            this.LblTotalForfait.Text = "12320€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1028, 818);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total frais hors forfait : ";
            // 
            // LblTotalHorsForfait
            // 
            this.LblTotalHorsForfait.AutoSize = true;
            this.LblTotalHorsForfait.Location = new System.Drawing.Point(1156, 818);
            this.LblTotalHorsForfait.Name = "LblTotalHorsForfait";
            this.LblTotalHorsForfait.Size = new System.Drawing.Size(43, 16);
            this.LblTotalHorsForfait.TabIndex = 10;
            this.LblTotalHorsForfait.Text = "12320€";
            // 
            // LblTotalFiche
            // 
            this.LblTotalFiche.AutoSize = true;
            this.LblTotalFiche.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LblTotalFiche.ForeColor = System.Drawing.Color.Firebrick;
            this.LblTotalFiche.Location = new System.Drawing.Point(1136, 861);
            this.LblTotalFiche.Name = "LblTotalFiche";
            this.LblTotalFiche.Size = new System.Drawing.Size(57, 21);
            this.LblTotalFiche.TabIndex = 11;
            this.LblTotalFiche.Text = "label5";
            // 
            // LblEmployeInfo
            // 
            this.LblEmployeInfo.AutoSize = true;
            this.LblEmployeInfo.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.LblEmployeInfo.Location = new System.Drawing.Point(480, 43);
            this.LblEmployeInfo.Name = "LblEmployeInfo";
            this.LblEmployeInfo.Size = new System.Drawing.Size(226, 22);
            this.LblEmployeInfo.TabIndex = 13;
            this.LblEmployeInfo.Text = "Employé :  Nom Prenom";
            // 
            // rBtnEnCours
            // 
            this.rBtnEnCours.AutoSize = true;
            this.rBtnEnCours.Location = new System.Drawing.Point(44, 862);
            this.rBtnEnCours.Name = "rBtnEnCours";
            this.rBtnEnCours.Size = new System.Drawing.Size(69, 20);
            this.rBtnEnCours.TabIndex = 14;
            this.rBtnEnCours.Text = "En cours";
            this.rBtnEnCours.UseVisualStyleBackColor = true;
            this.rBtnEnCours.CheckedChanged += new System.EventHandler(this.rBtnEnCours_CheckedChanged);
            // 
            // rBtnAccepter
            // 
            this.rBtnAccepter.AutoSize = true;
            this.rBtnAccepter.Location = new System.Drawing.Point(119, 862);
            this.rBtnAccepter.Name = "rBtnAccepter";
            this.rBtnAccepter.Size = new System.Drawing.Size(75, 20);
            this.rBtnAccepter.TabIndex = 15;
            this.rBtnAccepter.Text = "Accepter";
            this.rBtnAccepter.UseVisualStyleBackColor = true;
            this.rBtnAccepter.CheckedChanged += new System.EventHandler(this.rBtnAccepter_CheckedChanged);
            // 
            // rBtnRefuser
            // 
            this.rBtnRefuser.AutoSize = true;
            this.rBtnRefuser.Location = new System.Drawing.Point(200, 862);
            this.rBtnRefuser.Name = "rBtnRefuser";
            this.rBtnRefuser.Size = new System.Drawing.Size(63, 20);
            this.rBtnRefuser.TabIndex = 16;
            this.rBtnRefuser.Text = "Refuser";
            this.rBtnRefuser.UseVisualStyleBackColor = true;
            this.rBtnRefuser.CheckedChanged += new System.EventHandler(this.rBtnRefuser_CheckedChanged);
            // 
            // lblEtat
            // 
            this.lblEtat.AutoSize = true;
            this.lblEtat.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblEtat.Location = new System.Drawing.Point(443, 861);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(261, 22);
            this.lblEtat.TabIndex = 17;
            this.lblEtat.Text = "etat : à définir dans le code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(1027, 861);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total fiche : ";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(835, 857);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(71, 33);
            this.btnRetour.TabIndex = 18;
            this.btnRetour.Text = "Retour ";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // rBtnRefusPartiel
            // 
            this.rBtnRefusPartiel.AutoSize = true;
            this.rBtnRefusPartiel.Location = new System.Drawing.Point(269, 864);
            this.rBtnRefusPartiel.Name = "rBtnRefusPartiel";
            this.rBtnRefusPartiel.Size = new System.Drawing.Size(90, 20);
            this.rBtnRefusPartiel.TabIndex = 19;
            this.rBtnRefusPartiel.Text = "Refus partiel";
            this.rBtnRefusPartiel.UseVisualStyleBackColor = true;
            // 
            // FicheFraisDuMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 918);
            this.Controls.Add(this.rBtnRefusPartiel);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.rBtnRefuser);
            this.Controls.Add(this.rBtnAccepter);
            this.Controls.Add(this.rBtnEnCours);
            this.Controls.Add(this.LblEmployeInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblTotalFiche);
            this.Controls.Add(this.LblTotalHorsForfait);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblTotalForfait);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnPDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewHorsForfait);
            this.Controls.Add(this.listViewForfait);
            this.Controls.Add(this.DateFicheFrais);
            this.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FicheFraisDuMois";
            this.Text = "AjouterNoteFrais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateFicheFrais;
        private System.Windows.Forms.ListView listViewForfait;
        private System.Windows.Forms.ColumnHeader Type_frais_forfait;
        private System.Windows.Forms.ColumnHeader Quantite;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Justificatif;
        private System.Windows.Forms.ListView listViewHorsForfait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Etat;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Montant;
        private System.Windows.Forms.ColumnHeader DateHorsForfait;
        private System.Windows.Forms.ColumnHeader EtatHF;
        private System.Windows.Forms.ColumnHeader JustificatifHF;
        private System.Windows.Forms.Button BtnPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTotalForfait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTotalHorsForfait;
        private System.Windows.Forms.Label LblTotalFiche;
        private System.Windows.Forms.Label LblEmployeInfo;
        private System.Windows.Forms.RadioButton rBtnEnCours;
        private System.Windows.Forms.RadioButton rBtnAccepter;
        private System.Windows.Forms.RadioButton rBtnRefuser;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.RadioButton rBtnRefusPartiel;
    }
}