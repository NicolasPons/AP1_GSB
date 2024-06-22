using AP_1_GSB.Data.Models;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;



namespace AP_1_GSB.Services
{
    internal class PdfGenerationService
    {
        public static void CreerPDF(Utilisateur utilisateur, FicheFrais ficheEnCours, ListView listForfait, ListView listHorsForfait)
        {
            string dest = "fiche_de_frais.pdf";

            using (PdfWriter writer = new PdfWriter(dest))
            {
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                //// Ajouter le logo
                //Image logo = new Image(ImageDataFactory.Create("path/to/your/logo.png"));
                //logo.SetHeight(50);
                //logo.SetHorizontalAlignment(HorizontalAlignment.LEFT);
                //document.Add(logo);

                document.Add(new Paragraph("Fiche de frais")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20));
                document.Add(new LineSeparator(new SolidLine()));
                document.Add(new Paragraph("\n"));

                Table noteFraisTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1 }));
                Cell headerCellInfoTable = new Cell(1, 2).Add(new Paragraph("Information fiche"))
                               .SetTextAlignment(TextAlignment.CENTER)
                               .SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)
                               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE)
                               .SetBold();
                noteFraisTable.AddHeaderCell(headerCellInfoTable);

                noteFraisTable.AddCell(CreerCellule("NOTE DE FRAIS N°"));
                noteFraisTable.AddCell(CreerCellule("" + ficheEnCours.IdFicheFrais));
                noteFraisTable.AddCell(CreerCellule("Date de la note de frais"));
                noteFraisTable.AddCell(CreerCellule(ficheEnCours.Date.ToString("dd/MM/yyyy")));

                document.Add(noteFraisTable);


                document.Add(new Paragraph("\n"));

                Table collaborateurTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1 }));
                Cell headerCellEmploye = new Cell(1, 2).Add(new Paragraph("Information employé"))
                               .SetTextAlignment(TextAlignment.CENTER)
                               .SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)
                               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE)
                               .SetBold();
                collaborateurTable.AddHeaderCell(headerCellEmploye);
                collaborateurTable.AddCell(CreerCellule("Nom"));
                collaborateurTable.AddCell(CreerCellule(utilisateur.Nom));
                collaborateurTable.AddCell(CreerCellule("Prénom"));
                collaborateurTable.AddCell(CreerCellule(utilisateur.Prenom));
                collaborateurTable.AddCell(CreerCellule("E-mail"));
                collaborateurTable.AddCell(CreerCellule(utilisateur.Email));

                float yPosition = 750;
                float margin = 20;
                float tableWidth = 250;

                collaborateurTable.SetFixedPosition(1, 315, 660, tableWidth);
                noteFraisTable.SetFixedPosition(1, margin + tableWidth + margin, yPosition, tableWidth);

                document.Add(collaborateurTable);
                document.Add(new Paragraph("\n"));

                float montantTotal = FicheFraisService.CalculerTotalFiche(ficheEnCours);
                float montantRefuse = FicheFraisService.CalculerMontantFraisRefuser(ficheEnCours);
                float montantAccepter = montantTotal - montantRefuse;
                DateTime dateRemboursement = new DateTime(ficheEnCours.Date.Year, ficheEnCours.Date.AddMonths(1).Month, 28);
                Table remboursementTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1 }));
                remboursementTable.AddCell(CreerCellule("Date de remboursement prévue"));
                remboursementTable.AddCell(CreerCellule("" + dateRemboursement.ToString("dd/MM/yyyy")));
                remboursementTable.AddCell(CreerCellule("Montant du remboursement"));
                remboursementTable.AddCell(CreerCellule("" + montantAccepter + "€"));
                document.Add(remboursementTable);

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph("Frais Forfait")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14)
                    .SetBold());
                Table fraisForfaitTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1, 1 })).UseAllAvailableWidth();
                fraisForfaitTable.AddHeaderCell(CreerEnTete("Type"));
                fraisForfaitTable.AddHeaderCell(CreerEnTete("Quantité"));
                fraisForfaitTable.AddHeaderCell(CreerEnTete("Date"));
                fraisForfaitTable.AddHeaderCell(CreerEnTete("Etat"));

                foreach (ListViewItem item in listForfait.Items)
                {
                    fraisForfaitTable.AddCell(CreerCellule(item.SubItems[0].Text));
                    fraisForfaitTable.AddCell(CreerCellule(item.SubItems[1].Text));
                    fraisForfaitTable.AddCell(CreerCellule(item.SubItems[2].Text));
                    fraisForfaitTable.AddCell(CreerCellule(item.SubItems[3].Text));
                }

                document.Add(fraisForfaitTable);

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph("Frais Hors Forfait")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(14)
                    .SetBold());
                Table fraisHorsForfaitTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1, 1 })).UseAllAvailableWidth();
                fraisHorsForfaitTable.AddHeaderCell(CreerEnTete("Description"));
                fraisHorsForfaitTable.AddHeaderCell(CreerEnTete("Montant"));
                fraisHorsForfaitTable.AddHeaderCell(CreerEnTete("Date"));
                fraisHorsForfaitTable.AddHeaderCell(CreerEnTete("Etat"));

                foreach (ListViewItem item in listHorsForfait.Items)
                {
                    fraisHorsForfaitTable.AddCell(CreerCellule(item.SubItems[0].Text));
                    fraisHorsForfaitTable.AddCell(CreerCellule(item.SubItems[1].Text));
                    fraisHorsForfaitTable.AddCell(CreerCellule(item.SubItems[2].Text));
                    fraisHorsForfaitTable.AddCell(CreerCellule(item.SubItems[3].Text));
                }

                document.Add(fraisHorsForfaitTable);
                document.Close();
            }
            Process.Start(new ProcessStartInfo(dest) { UseShellExecute = true });
        }
        private static Cell CreerCellule(string contenu)
        {
            return new Cell().Add(new Paragraph(contenu).SetFontSize(10));
        }
        private static Cell CreerEnTete(string contenu)
        {
            return new Cell().Add(new Paragraph(contenu).SetFontSize(10).SetBold()).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE);
        }

    }
}
