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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheFraisDuMois));
            this.DateFicheFrais = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPDF = new System.Windows.Forms.Button();
            this.LblEmployeInfo = new System.Windows.Forms.Label();
            this.rBtnEnCours = new System.Windows.Forms.RadioButton();
            this.rBtnAccepter = new System.Windows.Forms.RadioButton();
            this.rBtnRefuser = new System.Windows.Forms.RadioButton();
            this.lblEtat = new System.Windows.Forms.Label();
            this.rBtnRefusPartiel = new System.Windows.Forms.RadioButton();
            this.btnRetour = new System.Windows.Forms.Button();
            this.DataGridFraisForfait = new System.Windows.Forms.DataGridView();
            this.DataGridHorsForfait = new System.Windows.Forms.DataGridView();
            this.RBtnEnAttente = new System.Windows.Forms.RadioButton();
            this.LblTotalForfait = new System.Windows.Forms.Label();
            this.LblTotalFiche = new System.Windows.Forms.Label();
            this.LblTotalHorsForfait = new System.Windows.Forms.Label();
            this.Typefraisforfait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantiteDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantForfait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDGFrais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JustiDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFraisforfait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFraisHorsForfait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHorsForfait)).BeginInit();
            this.SuspendLayout();
            // 
            // DateFicheFrais
            // 
            this.DateFicheFrais.AutoSize = true;
            this.DateFicheFrais.Font = new System.Drawing.Font("Century Gothic", 12.74545F, System.Drawing.FontStyle.Bold);
            this.DateFicheFrais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.DateFicheFrais.Location = new System.Drawing.Point(249, 27);
            this.DateFicheFrais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateFicheFrais.Name = "DateFicheFrais";
            this.DateFicheFrais.Size = new System.Drawing.Size(442, 23);
            this.DateFicheFrais.TabIndex = 0;
            this.DateFicheFrais.Text = "Fiche de frais du 10 Mai 2025 au 00 Mai 2025";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note de frais forfait";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(40, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note de frais hors forfait";
            // 
            // BtnPDF
            // 
            this.BtnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.BtnPDF.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPDF.FlatAppearance.BorderSize = 0;
            this.BtnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPDF.ForeColor = System.Drawing.Color.White;
            this.BtnPDF.Location = new System.Drawing.Point(838, 31);
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.Size = new System.Drawing.Size(121, 40);
            this.BtnPDF.TabIndex = 6;
            this.BtnPDF.Text = "Export PDF";
            this.BtnPDF.UseVisualStyleBackColor = false;
            this.BtnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // LblEmployeInfo
            // 
            this.LblEmployeInfo.AutoSize = true;
            this.LblEmployeInfo.Font = new System.Drawing.Font("Century Gothic", 10.78182F);
            this.LblEmployeInfo.ForeColor = System.Drawing.Color.Black;
            this.LblEmployeInfo.Location = new System.Drawing.Point(376, 50);
            this.LblEmployeInfo.Name = "LblEmployeInfo";
            this.LblEmployeInfo.Size = new System.Drawing.Size(205, 21);
            this.LblEmployeInfo.TabIndex = 13;
            this.LblEmployeInfo.Text = "Employé :  Nom Prenom";
            // 
            // rBtnEnCours
            // 
            this.rBtnEnCours.AutoSize = true;
            this.rBtnEnCours.Location = new System.Drawing.Point(44, 650);
            this.rBtnEnCours.Name = "rBtnEnCours";
            this.rBtnEnCours.Size = new System.Drawing.Size(69, 20);
            this.rBtnEnCours.TabIndex = 14;
            this.rBtnEnCours.Text = "En cours";
            this.rBtnEnCours.UseVisualStyleBackColor = true;
            // 
            // rBtnAccepter
            // 
            this.rBtnAccepter.AutoSize = true;
            this.rBtnAccepter.Location = new System.Drawing.Point(119, 650);
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
            this.rBtnRefuser.Location = new System.Drawing.Point(200, 650);
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
            this.lblEtat.Location = new System.Drawing.Point(40, 647);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(261, 22);
            this.lblEtat.TabIndex = 17;
            this.lblEtat.Text = "etat : à définir dans le code";
            // 
            // rBtnRefusPartiel
            // 
            this.rBtnRefusPartiel.AutoSize = true;
            this.rBtnRefusPartiel.Location = new System.Drawing.Point(269, 652);
            this.rBtnRefusPartiel.Name = "rBtnRefusPartiel";
            this.rBtnRefusPartiel.Size = new System.Drawing.Size(90, 20);
            this.rBtnRefusPartiel.TabIndex = 19;
            this.rBtnRefusPartiel.Text = "Refus partiel";
            this.rBtnRefusPartiel.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btnRetour.FlatAppearance.BorderSize = 0;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Image = global::AP_1_GSB.Properties.Resources.icons8_retour_25;
            this.btnRetour.Location = new System.Drawing.Point(47, 23);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(80, 39);
            this.btnRetour.TabIndex = 18;
            this.btnRetour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // DataGridFraisForfait
            // 
            this.DataGridFraisForfait.AllowUserToAddRows = false;
            this.DataGridFraisForfait.AllowUserToDeleteRows = false;
            this.DataGridFraisForfait.AllowUserToResizeColumns = false;
            this.DataGridFraisForfait.AllowUserToResizeRows = false;
            this.DataGridFraisForfait.BackgroundColor = System.Drawing.Color.White;
            this.DataGridFraisForfait.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridFraisForfait.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFraisForfait.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridFraisForfait.ColumnHeadersHeight = 30;
            this.DataGridFraisForfait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Typefraisforfait,
            this.QuantiteDG,
            this.MontantForfait,
            this.DateDGFrais,
            this.EtatDG,
            this.JustiDG,
            this.IdFraisforfait});
            this.DataGridFraisForfait.EnableHeadersVisualStyles = false;
            this.DataGridFraisForfait.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridFraisForfait.Location = new System.Drawing.Point(44, 99);
            this.DataGridFraisForfait.MaximumSize = new System.Drawing.Size(915, 225);
            this.DataGridFraisForfait.MinimumSize = new System.Drawing.Size(915, 225);
            this.DataGridFraisForfait.MultiSelect = false;
            this.DataGridFraisForfait.Name = "DataGridFraisForfait";
            this.DataGridFraisForfait.ReadOnly = true;
            this.DataGridFraisForfait.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFraisForfait.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridFraisForfait.RowHeadersVisible = false;
            this.DataGridFraisForfait.RowHeadersWidth = 47;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFraisForfait.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridFraisForfait.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridFraisForfait.Size = new System.Drawing.Size(915, 225);
            this.DataGridFraisForfait.TabIndex = 20;
            this.DataGridFraisForfait.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridFraisForfait_MouseClick);
            // 
            // DataGridHorsForfait
            // 
            this.DataGridHorsForfait.AllowUserToAddRows = false;
            this.DataGridHorsForfait.AllowUserToDeleteRows = false;
            this.DataGridHorsForfait.AllowUserToResizeColumns = false;
            this.DataGridHorsForfait.AllowUserToResizeRows = false;
            this.DataGridHorsForfait.BackgroundColor = System.Drawing.Color.White;
            this.DataGridHorsForfait.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridHorsForfait.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridHorsForfait.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridHorsForfait.ColumnHeadersHeight = 30;
            this.DataGridHorsForfait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.IdFraisHorsForfait});
            this.DataGridHorsForfait.EnableHeadersVisualStyles = false;
            this.DataGridHorsForfait.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridHorsForfait.Location = new System.Drawing.Point(44, 387);
            this.DataGridHorsForfait.MaximumSize = new System.Drawing.Size(915, 225);
            this.DataGridHorsForfait.MinimumSize = new System.Drawing.Size(915, 225);
            this.DataGridHorsForfait.MultiSelect = false;
            this.DataGridHorsForfait.Name = "DataGridHorsForfait";
            this.DataGridHorsForfait.ReadOnly = true;
            this.DataGridHorsForfait.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridHorsForfait.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridHorsForfait.RowHeadersVisible = false;
            this.DataGridHorsForfait.RowHeadersWidth = 47;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridHorsForfait.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridHorsForfait.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridHorsForfait.Size = new System.Drawing.Size(915, 225);
            this.DataGridHorsForfait.TabIndex = 21;
            this.DataGridHorsForfait.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridHorsForfait_MouseClick);
            // 
            // RBtnEnAttente
            // 
            this.RBtnEnAttente.AutoSize = true;
            this.RBtnEnAttente.Location = new System.Drawing.Point(365, 652);
            this.RBtnEnAttente.Name = "RBtnEnAttente";
            this.RBtnEnAttente.Size = new System.Drawing.Size(81, 20);
            this.RBtnEnAttente.TabIndex = 22;
            this.RBtnEnAttente.Text = "En Attente";
            this.RBtnEnAttente.UseVisualStyleBackColor = true;
            // 
            // LblTotalForfait
            // 
            this.LblTotalForfait.AutoSize = true;
            this.LblTotalForfait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalForfait.Location = new System.Drawing.Point(832, 343);
            this.LblTotalForfait.Name = "LblTotalForfait";
            this.LblTotalForfait.Size = new System.Drawing.Size(125, 18);
            this.LblTotalForfait.TabIndex = 23;
            this.LblTotalForfait.Text = "Total forfait : 1444,34 €";
            // 
            // LblTotalFiche
            // 
            this.LblTotalFiche.AutoSize = true;
            this.LblTotalFiche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalFiche.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalFiche.ForeColor = System.Drawing.Color.Firebrick;
            this.LblTotalFiche.Location = new System.Drawing.Point(795, 652);
            this.LblTotalFiche.Name = "LblTotalFiche";
            this.LblTotalFiche.Size = new System.Drawing.Size(153, 20);
            this.LblTotalFiche.TabIndex = 24;
            this.LblTotalFiche.Text = "Total fiche : 757,45 €";
            // 
            // LblTotalHorsForfait
            // 
            this.LblTotalHorsForfait.AutoSize = true;
            this.LblTotalHorsForfait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalHorsForfait.Location = new System.Drawing.Point(814, 629);
            this.LblTotalHorsForfait.Name = "LblTotalHorsForfait";
            this.LblTotalHorsForfait.Size = new System.Drawing.Size(143, 18);
            this.LblTotalHorsForfait.TabIndex = 25;
            this.LblTotalHorsForfait.Text = "Total hors forfait : 145,34 €";
            // 
            // Typefraisforfait
            // 
            this.Typefraisforfait.Frozen = true;
            this.Typefraisforfait.HeaderText = "Type frais forfait";
            this.Typefraisforfait.MinimumWidth = 6;
            this.Typefraisforfait.Name = "Typefraisforfait";
            this.Typefraisforfait.ReadOnly = true;
            this.Typefraisforfait.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Typefraisforfait.Width = 180;
            // 
            // QuantiteDG
            // 
            this.QuantiteDG.Frozen = true;
            this.QuantiteDG.HeaderText = "Quantité";
            this.QuantiteDG.MinimumWidth = 6;
            this.QuantiteDG.Name = "QuantiteDG";
            this.QuantiteDG.ReadOnly = true;
            this.QuantiteDG.Width = 60;
            // 
            // MontantForfait
            // 
            this.MontantForfait.HeaderText = "Montant";
            this.MontantForfait.MinimumWidth = 6;
            this.MontantForfait.Name = "MontantForfait";
            this.MontantForfait.ReadOnly = true;
            // 
            // DateDGFrais
            // 
            this.DateDGFrais.HeaderText = "Date";
            this.DateDGFrais.MinimumWidth = 6;
            this.DateDGFrais.Name = "DateDGFrais";
            this.DateDGFrais.ReadOnly = true;
            this.DateDGFrais.Width = 150;
            // 
            // EtatDG
            // 
            this.EtatDG.HeaderText = "Etat";
            this.EtatDG.MinimumWidth = 6;
            this.EtatDG.Name = "EtatDG";
            this.EtatDG.ReadOnly = true;
            this.EtatDG.Width = 180;
            // 
            // JustiDG
            // 
            this.JustiDG.HeaderText = "Justificatif";
            this.JustiDG.MinimumWidth = 6;
            this.JustiDG.Name = "JustiDG";
            this.JustiDG.ReadOnly = true;
            this.JustiDG.Width = 230;
            // 
            // IdFraisforfait
            // 
            this.IdFraisforfait.HeaderText = "IdFraisforfait";
            this.IdFraisforfait.MinimumWidth = 6;
            this.IdFraisforfait.Name = "IdFraisforfait";
            this.IdFraisforfait.ReadOnly = true;
            this.IdFraisforfait.Width = 115;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Etat";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Justificatif";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 280;
            // 
            // IdFraisHorsForfait
            // 
            this.IdFraisHorsForfait.Frozen = true;
            this.IdFraisHorsForfait.HeaderText = "IdFraisHorsForfait";
            this.IdFraisHorsForfait.MinimumWidth = 6;
            this.IdFraisHorsForfait.Name = "IdFraisHorsForfait";
            this.IdFraisHorsForfait.ReadOnly = true;
            this.IdFraisHorsForfait.Width = 115;
            // 
            // FicheFraisDuMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.LblTotalHorsForfait);
            this.Controls.Add(this.LblTotalFiche);
            this.Controls.Add(this.LblTotalForfait);
            this.Controls.Add(this.RBtnEnAttente);
            this.Controls.Add(this.DataGridHorsForfait);
            this.Controls.Add(this.DataGridFraisForfait);
            this.Controls.Add(this.rBtnRefusPartiel);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.rBtnRefuser);
            this.Controls.Add(this.rBtnAccepter);
            this.Controls.Add(this.rBtnEnCours);
            this.Controls.Add(this.LblEmployeInfo);
            this.Controls.Add(this.BtnPDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateFicheFrais);
            this.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FicheFraisDuMois";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHorsForfait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateFicheFrais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPDF;
        private System.Windows.Forms.Label LblEmployeInfo;
        private System.Windows.Forms.RadioButton rBtnEnCours;
        private System.Windows.Forms.RadioButton rBtnAccepter;
        private System.Windows.Forms.RadioButton rBtnRefuser;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.RadioButton rBtnRefusPartiel;
        private System.Windows.Forms.DataGridView DataGridFraisForfait;
        private System.Windows.Forms.DataGridView DataGridHorsForfait;
        private System.Windows.Forms.RadioButton RBtnEnAttente;
        private System.Windows.Forms.Label LblTotalForfait;
        private System.Windows.Forms.Label LblTotalFiche;
        private System.Windows.Forms.Label LblTotalHorsForfait;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typefraisforfait;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantiteDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantForfait;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDGFrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn JustiDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFraisforfait;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFraisHorsForfait;
    }
}