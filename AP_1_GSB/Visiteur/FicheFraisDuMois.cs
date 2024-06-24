using AP_1_GSB.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout.Borders;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Globalization;
using iText.IO.Image;
using iText.Layout.Properties;
using AP_1_GSB.Services;

using AP_1_GSB.Comptable;
namespace AP_1_GSB.Visiteur
{
    //Après modifications sur le form, évenement CalculTotalFiche cassé = à retravailler 
    public partial class FicheFraisDuMois : Form
    {
        readonly Utilisateur utilisateur;
        readonly FicheFrais ficheEnCours;
        readonly string version;
        public event Action ListesVide;
        public event Action GriserBouton;
        //public event Action CalculTotalFiche;
        public ListView ListViewForfait => this.listViewForfait;
        public ListView ListViewHorsForfait => this.listViewHorsForfait;

        public FicheFraisDuMois(Utilisateur utilisateur, FicheFrais ficheEnCours, DateTime dtFin, string version)
        {
            this.utilisateur = utilisateur;
            this.ficheEnCours = ficheEnCours;
            this.version = version;
            InitializeComponent();
            MettreAJourListView();
            //ListViewForfait.ColumnWidthChanging += ListView_ColumnWidthChanging;
            //listViewHorsForfait.ColumnWidthChanging += ListView_ColumnWidthChanging;
            AfficherInformationForm();
            MiseEnFormeBoutons();
            DateFicheFrais.Text = "Fiche de frais du " + ficheEnCours.Date.ToString("dd MMMM yyyy") + " au " + dtFin.ToString("dd MMMM yyyy");
        }
        //private void ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        //{
        //    //e.Cancel = true;
        //    // Vous pouvez également forcer la largeur de la colonne à rester constante si nécessaire
        //    e.NewWidth = ListViewForfait.Columns[e.ColumnIndex].Width;
        //}
        private void MiseEnFormeBoutons()
        {
            Design design = new Design();
            BtnPDF.MouseEnter += design.Btn_EntrerCurseur;
            BtnPDF.MouseLeave += design.Btn_SortirCurseur;
            design.MiseEnFormeBoutons(BtnPDF);
            btnRetour.MouseEnter += design.Btn_EntrerCurseur;
            btnRetour.MouseLeave += design.Btn_SortirCurseur;
            design.MiseEnFormeBoutons(btnRetour);
        }



        #region General
        private void AfficherInformationForm()
        {
            if (version == "utilisateur")
            {
                rBtnAccepter.Visible = false;
                rBtnEnCours.Visible = false;
                rBtnRefuser.Visible = false;
                rBtnRefusPartiel.Visible = false;
                LblEmployeInfo.Visible = false;
                btnRetour.Visible = false;

                string etat = FicheFraisService.EcrireEtatFiche(ficheEnCours);
                lblEtat.Text = "L'état de la fiche est : " + etat;
            }
            else
            {

                LblEmployeInfo.Text = "Employé : " + utilisateur.Nom + " " + utilisateur.Prenom;
                lblEtat.Visible = false;
                VerifierEtatFiche();
            }
        }

        public void MettreAJourListView()
        {
            listViewHorsForfait.Items.Clear();
            listViewForfait.Items.Clear();

            foreach (FraisHorsForfait fraisHorsForfait in ficheEnCours.FraisHorsForfaits)
            {
                string etatJustificatif = "Pas de justificatif";
                if (fraisHorsForfait.Justificatif != null)
                {
                    etatJustificatif = "Justificatif présent";
                }

                string etat = Services.FraisHorsForfaitService.EcrireEtatFraiHorsForfait(fraisHorsForfait);
                ListViewItem item = new ListViewItem(fraisHorsForfait.Description);
                item.SubItems.Add(fraisHorsForfait.Montant.ToString());
                item.SubItems.Add(fraisHorsForfait.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(etat);
                item.SubItems.Add(etatJustificatif);
                item.Tag = fraisHorsForfait.IdFraisHorsForfait;
                listViewHorsForfait.Items.Add(item);
            }
            float totalForfait = FraisForfaitService.CalculerTotalForfait(ficheEnCours);
            LblTotalForfait.Text = totalForfait.ToString("F2") + " €";


            foreach (FraisForfait fraisForfait in ficheEnCours.FraisForfaits)
            {

                string etatJustificatif = "Pas de justificatif";
                if (fraisForfait.justificatif != null)
                {
                    etatJustificatif = "Justificatif présent";
                }
                string etat = Services.FraisForfaitService.EcrireEtatFraisForfait(fraisForfait);
                ListViewItem item = new ListViewItem(fraisForfait.TypeForfait.Nom);
                item.SubItems.Add(fraisForfait.Quantite.ToString());
                item.SubItems.Add(fraisForfait.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(etat);
                item.SubItems.Add(etatJustificatif);
                item.Tag = fraisForfait.IdFraisForfait;
                listViewForfait.Items.Add(item);
            }

            float totalHorsForfait = FraisHorsForfaitService.CalculerTotalHorsForfait(ficheEnCours);
            LblTotalHorsForfait.Text = totalHorsForfait.ToString("F2") + " €";
            float totalFiche = FicheFraisService.CalculerTotalFiche(ficheEnCours);
            LblTotalFiche.Text = totalFiche.ToString("F2");

        }
        private void BtnPDF_Click(object sender, EventArgs e)
        {

            FicheFraisService.CreerPDF(utilisateur, ficheEnCours, listViewForfait, listViewHorsForfait);
            //string dest = "fiche_de_frais.pdf";

            //using (PdfWriter writer = new PdfWriter(dest))
            //{
            //    PdfDocument pdf = new PdfDocument(writer);
            //    Document document = new Document(pdf);

            //    //// Ajouter le logo
            //    //Image logo = new Image(ImageDataFactory.Create("path/to/your/logo.png"));
            //    //logo.SetHeight(50);
            //    //logo.SetHorizontalAlignment(HorizontalAlignment.LEFT);
            //    //document.Add(logo);

            //    document.Add(new Paragraph("Fiche de frais")
            //        .SetTextAlignment(TextAlignment.CENTER)
            //        .SetFontSize(20));
            //    document.Add(new LineSeparator(new SolidLine()));
            //    document.Add(new Paragraph("\n"));

            //    Table noteFraisTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1 }));
            //    Cell headerCellInfoTable = new Cell(1, 2).Add(new Paragraph("Information fiche"))
            //                   .SetTextAlignment(TextAlignment.CENTER)
            //                   .SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)
            //                   .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE)
            //                   .SetBold();
            //    noteFraisTable.AddHeaderCell(headerCellInfoTable);

            //    noteFraisTable.AddCell(CreateCell("NOTE DE FRAIS N°"));
            //    noteFraisTable.AddCell(CreateCell("" + ficheEnCours.IdFicheFrais));
            //    noteFraisTable.AddCell(CreateCell("Date de la note de frais"));
            //    noteFraisTable.AddCell(CreateCell(ficheEnCours.Date.ToString("dd/MM/yyyy")));

            //    document.Add(noteFraisTable);


            //    document.Add(new Paragraph("\n"));

            //    Table collaborateurTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1 }));
            //    Cell headerCellEmploye = new Cell(1, 2).Add(new Paragraph("Information employé"))
            //                   .SetTextAlignment(TextAlignment.CENTER)
            //                   .SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)
            //                   .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE)
            //                   .SetBold();
            //    collaborateurTable.AddHeaderCell(headerCellEmploye);
            //    collaborateurTable.AddCell(CreateCell("Nom"));
            //    collaborateurTable.AddCell(CreateCell(utilisateur.Nom));
            //    collaborateurTable.AddCell(CreateCell("Prénom"));
            //    collaborateurTable.AddCell(CreateCell(utilisateur.Prenom));
            //    collaborateurTable.AddCell(CreateCell("E-mail"));
            //    collaborateurTable.AddCell(CreateCell(utilisateur.Email));

            //    float yPosition = 750;
            //    float margin = 20;
            //    float tableWidth = 250;

            //    collaborateurTable.SetFixedPosition(1, 315, 660, tableWidth);
            //    noteFraisTable.SetFixedPosition(1, margin + tableWidth + margin, yPosition, tableWidth);



            //    document.Add(collaborateurTable);

            //    document.Add(new Paragraph("\n"));

            //    Table remboursementTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1 }));
            //    remboursementTable.AddCell(CreateCell("Date de remboursement prévue"));
            //    remboursementTable.AddCell(CreateCell(""));
            //    remboursementTable.AddCell(CreateCell("Montant du remboursement"));
            //    remboursementTable.AddCell(CreateCell(""));
            //    document.Add(remboursementTable);

            //    document.Add(new Paragraph("\n"));

            //    document.Add(new Paragraph("Frais Forfait")
            //        .SetTextAlignment(TextAlignment.CENTER)
            //        .SetFontSize(14)
            //        .SetBold());
            //    Table fraisForfaitTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1, 1 })).UseAllAvailableWidth();
            //    fraisForfaitTable.AddHeaderCell(CreateHeaderCell("Type"));
            //    fraisForfaitTable.AddHeaderCell(CreateHeaderCell("Quantité"));
            //    fraisForfaitTable.AddHeaderCell(CreateHeaderCell("Date"));
            //    fraisForfaitTable.AddHeaderCell(CreateHeaderCell("Etat"));

            //    foreach (ListViewItem item in listViewForfait.Items)
            //    {
            //        fraisForfaitTable.AddCell(CreateCell(item.SubItems[0].Text));
            //        fraisForfaitTable.AddCell(CreateCell(item.SubItems[1].Text));
            //        fraisForfaitTable.AddCell(CreateCell(item.SubItems[2].Text));
            //        fraisForfaitTable.AddCell(CreateCell(item.SubItems[3].Text));
            //    }

            //    document.Add(fraisForfaitTable);

            //    document.Add(new Paragraph("\n"));

            //    document.Add(new Paragraph("Frais Hors Forfait")
            //        .SetTextAlignment(TextAlignment.CENTER)
            //        .SetFontSize(14)
            //        .SetBold());
            //    Table fraisHorsForfaitTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1, 1 })).UseAllAvailableWidth();
            //    fraisHorsForfaitTable.AddHeaderCell(CreateHeaderCell("Description"));
            //    fraisHorsForfaitTable.AddHeaderCell(CreateHeaderCell("Montant"));
            //    fraisHorsForfaitTable.AddHeaderCell(CreateHeaderCell("Date"));
            //    fraisHorsForfaitTable.AddHeaderCell(CreateHeaderCell("Etat"));

            //    foreach (ListViewItem item in listViewHorsForfait.Items)
            //    {
            //        fraisHorsForfaitTable.AddCell(CreateCell(item.SubItems[0].Text));
            //        fraisHorsForfaitTable.AddCell(CreateCell(item.SubItems[1].Text));
            //        fraisHorsForfaitTable.AddCell(CreateCell(item.SubItems[2].Text));
            //        fraisHorsForfaitTable.AddCell(CreateCell(item.SubItems[3].Text));
            //    }

            //    document.Add(fraisHorsForfaitTable);
            //    document.Close();
            //}
            //Process.Start(new ProcessStartInfo(dest) { UseShellExecute = true });
        }

        private Cell CreateCell(string content)
        {
            return new Cell().Add(new Paragraph(content).SetFontSize(10));
        }
        private Cell CreateHeaderCell(string content)
        {
            return new Cell().Add(new Paragraph(content).SetFontSize(10).SetBold()).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE);
        }

        #endregion



        #region utilisateur 

        public void VerifierListesVides()
        {
            if (listViewForfait.Items.Count == 0 && listViewHorsForfait.Items.Count == 0)
            {
                ListesVide?.Invoke();
            }
        }

        public void SupprimerSelectionLigne()
        {
            if (listViewForfait.SelectedItems.Count > 0)
            {
                SupprimerFraisForfait();
            }
            else if (listViewHorsForfait.SelectedItems.Count > 0)
            {
                SupprimerFraisHorsForfait();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un frais à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SupprimerFraisForfait()
        {

            if (listViewForfait.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un frais forfait à supprimer", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idFraisASupprimer = (int)listViewForfait.SelectedItems[0].Tag;
            listViewForfait.Items.Remove(listViewForfait.SelectedItems[0]);
            FraisForfait FraisASupprimer = ficheEnCours.FraisForfaits.Find(f => f.IdFraisForfait == idFraisASupprimer);


            if (FraisASupprimer == null)
            {
                MessageBox.Show("Erreur : frais forfait non trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Services.FraisForfaitService.SupprimerFraisForfait(FraisASupprimer))
            {
                MessageBox.Show("Note de frais forfait supprimée", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ficheEnCours.FraisForfaits.Remove(FraisASupprimer);
                float total = FraisForfaitService.CalculerTotalForfait(ficheEnCours);
                LblTotalForfait.Text = total.ToString("F2") + " €";
                float totalFiche = FicheFraisService.CalculerTotalFiche(ficheEnCours);
                LblTotalFiche.Text = totalFiche.ToString("F2");
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression de la note de frais", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            VerifierListesVides();
        }

        public void SupprimerFraisHorsForfait()
        {
            int idFraisASupprimer = 0;
            FraisHorsForfait FraisASupprimer = null;


            if (listViewHorsForfait.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un frais hors forfait à supprimer", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                idFraisASupprimer = (int)listViewHorsForfait.SelectedItems[0].Tag; ;
                listViewHorsForfait.Items.Remove(listViewHorsForfait.SelectedItems[0]);
                FraisASupprimer = ficheEnCours.FraisHorsForfaits.Find(f => f.IdFraisHorsForfait == idFraisASupprimer);
            }

            if (Services.FraisHorsForfaitService.SupprimerFraisHorsForfait(FraisASupprimer))
            {
                ficheEnCours.FraisHorsForfaits.Remove(FraisASupprimer);
                float totalHorsForfait = FraisHorsForfaitService.CalculerTotalHorsForfait(ficheEnCours);
                LblTotalHorsForfait.Text = totalHorsForfait.ToString("F2") + " €";
                float totalFiche = FicheFraisService.CalculerTotalFiche(ficheEnCours);
                LblTotalFiche.Text = totalFiche.ToString("F2");
                MessageBox.Show("Note de frais hors forfait supprimée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression de la note de frais", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VerifierListesVides();
        }
        #endregion


        #region Comptable

        // En base, pour id_etat : 1 = hors_delai / 2 = en_cours / 3 = accepter / 4 = refuser / 5 = refus_partiel

        public void VerifierEtatFiche()
        {
            switch (ficheEnCours.Etat)
            {
                case EtatFicheFrais.Accepter:
                    rBtnAccepter.Checked = true;
                    break;
                case EtatFicheFrais.Refuser:
                    rBtnRefuser.Checked = true;
                    break;
                case EtatFicheFrais.EnCours:
                    rBtnEnCours.Checked = true;
                    break;
                case EtatFicheFrais.RefusPartiel:
                    rBtnRefusPartiel.Checked = true;
                    rBtnEnCours.Enabled = false;
                    rBtnAccepter.Enabled = false;
                    break;
            }
        }

        public void RefuserFrais()
        {
            string etat = "REFUSER";
            if (listViewForfait.SelectedItems.Count > 0)
            {
                int idFrais = (int)listViewForfait.SelectedItems[0].Tag;
                FraisForfait fraisForfait = null;
                foreach (FraisForfait frais in ficheEnCours.FraisForfaits)
                {
                    if (frais.IdFraisForfait == idFrais)
                    {
                        fraisForfait = frais;
                        break;
                    }
                }

                if (fraisForfait.Etat == EtatFraisForfait.Refuser)
                {
                    MessageBox.Show("Le frais est déjà refusé", "Frais refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    fraisForfait.Etat = EtatFraisForfait.Refuser;
                }

                FraisForfaitService.ChangerEtatFraisForfat(idFrais, etat);

                FicheFraisService.ChangerEtatFiche(ficheEnCours, 5);
                ficheEnCours.Etat = EtatFicheFrais.RefusPartiel;
                MettreAJourListView();
                rBtnRefusPartiel.Checked = true;
                ChangerStatutRadioBtn(false, false, false);
                GriserRadioBtn(false, false);
            }
            else if (listViewHorsForfait.SelectedItems.Count > 0)
            {
                int idFrais = (int)listViewHorsForfait.SelectedItems[0].Tag;

                FraisHorsForfaitService.ChangerEtatHorsForfait(idFrais, etat);
                foreach (FraisHorsForfait frais in ficheEnCours.FraisHorsForfaits)
                {
                    if (frais.IdFraisHorsForfait == idFrais)
                        frais.Etat = EtatFraisHorsForfait.Refuser;
                }

                FicheFraisService.ChangerEtatFiche(ficheEnCours, 5);
                ficheEnCours.Etat = EtatFicheFrais.RefusPartiel;
                MettreAJourListView();
                rBtnRefusPartiel.Checked = true;
                ChangerStatutRadioBtn(false, false, false);
                GriserRadioBtn(false, false);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un frais à refuser", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AccepterFrais()
        {
            string etat = "ACCEPTER";
            if (listViewForfait.SelectedItems.Count > 0)
            {
                int idFrais = (int)listViewForfait.SelectedItems[0].Tag;
                FraisForfaitService.ChangerEtatFraisForfat(idFrais, etat);

                FraisForfait fraisForfait = null;
                foreach (FraisForfait frais in ficheEnCours.FraisForfaits)
                {
                    if (frais.IdFraisForfait == idFrais)
                        fraisForfait = frais;
                }

                if (fraisForfait.Etat == EtatFraisForfait.Accepter)
                {
                    MessageBox.Show("Le frais est déjà accepté", "Frais accepté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    fraisForfait.Etat = EtatFraisForfait.Accepter;
                }

                MettreAJourListView();
                VerifierEtatAccepter();
                FicheFraisService.ChangerEtatFiche(ficheEnCours, 2);
                ficheEnCours.Etat = EtatFicheFrais.EnCours;

            }
            else if (listViewHorsForfait.SelectedItems.Count > 0)
            {
                int idFrais = (int)listViewHorsForfait.SelectedItems[0].Tag;
                FraisHorsForfaitService.ChangerEtatHorsForfait(idFrais, etat);

                FraisHorsForfait fraisHorsForfait = null;
                foreach (FraisHorsForfait frais in ficheEnCours.FraisHorsForfaits)
                {
                    if (frais.IdFraisHorsForfait == idFrais)
                        fraisHorsForfait = frais;
                }

                if (fraisHorsForfait.Etat == EtatFraisHorsForfait.Accepter)
                {
                    MessageBox.Show("Le frais est déjà accepté", "Frais accepté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    fraisHorsForfait.Etat = EtatFraisHorsForfait.Accepter;
                }
                MettreAJourListView();
                VerifierEtatAccepter();
                FicheFraisService.ChangerEtatFiche(ficheEnCours, 2);
                ficheEnCours.Etat = EtatFicheFrais.EnCours;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un frais à accepter", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VerifierEtatAccepter()
        {
            List<FraisForfait> listeForfait = new List<FraisForfait>();
            foreach (FraisForfait frais in ficheEnCours.FraisForfaits)
            {
                if (frais.Etat == EtatFraisForfait.Refuser)
                    listeForfait.Add(frais);
            }
            List<FraisHorsForfait> listeHorsForfait = new List<FraisHorsForfait>();
            foreach (FraisHorsForfait frais in ficheEnCours.FraisHorsForfaits)
            {
                if (frais.Etat == EtatFraisHorsForfait.Refuser)
                    listeHorsForfait.Add(frais);
            }
            if (listeForfait.Count == 0 && listeHorsForfait.Count == 0)
            {
                rBtnAccepter.Checked = true;
                rBtnEnCours.Enabled = true;
                rBtnAccepter.Enabled = true;
                rBtnRefuser.Enabled = true;
                rBtnRefusPartiel.Enabled = false;
            }
        }

        // En base, pour id_etat : 1 = hors_delai / 2 = en_cours / 3 = accepter / 4 = refuser / 5 = refus_partiel
        private void rBtnAccepter_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnAccepter.Checked == true)
            {
                FicheFraisService.ChangerEtatFiche(ficheEnCours, 3);
                ficheEnCours.Etat = EtatFicheFrais.Accepter;
                ChangerStatutRadioBtn(false, true, false, false);
                rBtnRefusPartiel.Enabled = false;
            }
        }
        private void rBtnRefuser_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnRefuser.Checked == true)
            {
                FicheFraisService.ChangerEtatFiche(ficheEnCours, 4);
                ficheEnCours.Etat = EtatFicheFrais.Accepter;
                ChangerStatutRadioBtn(false, false, true, false);
                rBtnRefusPartiel.Enabled = false;
            }
        }
        private void rBtnEnCours_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnEnCours.Checked == true)
            {
                FicheFraisService.ChangerEtatFiche(ficheEnCours, 2);
                ficheEnCours.Etat = EtatFicheFrais.Accepter;
                ChangerStatutRadioBtn(true, false, false, false);
                rBtnRefusPartiel.Enabled = false;
            }
        }

        private void ChangerStatutRadioBtn(bool radioBtnEnCours, bool radioBtnAccepter, bool radioBtnRefuser)
        {
            rBtnEnCours.Checked = radioBtnEnCours;
            rBtnAccepter.Checked = radioBtnAccepter;
            rBtnRefuser.Checked = radioBtnRefuser;
        }
        private void ChangerStatutRadioBtn(bool radioBtnEnCours, bool radioBtnAccepter, bool radioBtnRefuser, bool radioBtnRefusPartiel)
        {
            rBtnEnCours.Checked = radioBtnEnCours;
            rBtnAccepter.Checked = radioBtnAccepter;
            rBtnRefuser.Checked = radioBtnRefuser;
            rBtnRefusPartiel.Checked = radioBtnRefusPartiel;
        }

        private void GriserRadioBtn(bool radioBtnEnCours, bool radioBtnAccepter)
        {
            rBtnEnCours.Enabled = radioBtnEnCours;
            rBtnAccepter.Enabled = radioBtnAccepter;
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            GriserBouton?.Invoke();
            this.SendToBack();
        }

        #endregion

        private void listViewHorsForfait_Enter(object sender, EventArgs e)
        {
            listViewForfait.SelectedItems.Clear();
        }

        private void listViewForfait_Enter(object sender, EventArgs e)
        {
            listViewHorsForfait.SelectedItems.Clear();
        }
    }
}




////PERMET D'AFFICHER UNE IMAGE DU FICHIER BLOB
//byte[] blob = utilisateur.FichesFrais[0].FraisForfaits[1].justificatif.FichierBlob;
//using (MemoryStream ms = new MemoryStream(blob))
//{
//    Image image = Image.FromStream(ms);
//    // Vous pouvez maintenant utiliser l'objet image.
//    // Par exemple, pour l'afficher dans un PictureBox :
//    pictureBox1.Image = image;
//    pictureBox1.Size = image.Size;
//}