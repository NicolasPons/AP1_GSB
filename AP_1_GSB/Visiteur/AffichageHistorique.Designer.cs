namespace AP_1_GSB.Visiteur
{
    partial class AffichageHistorique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageHistorique));
            this.listViewFicheFrais = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Montant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFicheFrais
            // 
            this.listViewFicheFrais.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Montant,
            this.Etat});
            this.listViewFicheFrais.GridLines = true;
            this.listViewFicheFrais.HideSelection = false;
            this.listViewFicheFrais.HoverSelection = true;
            this.listViewFicheFrais.Location = new System.Drawing.Point(97, 118);
            this.listViewFicheFrais.Margin = new System.Windows.Forms.Padding(4);
            this.listViewFicheFrais.Name = "listViewFicheFrais";
            this.listViewFicheFrais.Size = new System.Drawing.Size(795, 474);
            this.listViewFicheFrais.TabIndex = 0;
            this.listViewFicheFrais.UseCompatibleStateImageBehavior = false;
            this.listViewFicheFrais.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 171;
            // 
            // Montant
            // 
            this.Montant.Text = "Montant";
            this.Montant.Width = 155;
            // 
            // Etat
            // 
            this.Etat.Text = "Etat";
            this.Etat.Width = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(342, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historique de vos fiches de frais";
            // 
            // BtnRetour
            // 
            this.BtnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.BtnRetour.FlatAppearance.BorderSize = 0;
            this.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetour.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.BtnRetour.ForeColor = System.Drawing.Color.White;
            this.BtnRetour.Image = global::AP_1_GSB.Properties.Resources.icons8_retour_25;
            this.BtnRetour.Location = new System.Drawing.Point(754, 600);
            this.BtnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(138, 48);
            this.BtnRetour.TabIndex = 2;
            this.BtnRetour.Text = "   Retour";
            this.BtnRetour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRetour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRetour.UseVisualStyleBackColor = false;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // AffichageHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 722);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewFicheFrais);
            this.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AffichageHistorique";
            this.Text = "AffichageHistorique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFicheFrais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Montant;
        private System.Windows.Forms.ColumnHeader Etat;
        private System.Windows.Forms.Button BtnRetour;
    }
}