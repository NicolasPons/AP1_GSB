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

namespace AP_1_GSB.Visiteur
{
    public partial class NoteFraisDuMois : Form
    {
        Utilisateur Utilisateur;
        public NoteFraisDuMois(Utilisateur utilisateur, FicheFrais ficheEnCours)
        {
            this.Utilisateur = utilisateur;
            InitializeComponent();
            DateTime dtFin = new DateTime(ficheEnCours.Date.Year, ficheEnCours.Date.AddMonths(1).Month, ficheEnCours.Date.AddDays(-1).Day);
            DateFicheFrais.Text = "Fiche de frais du " + ficheEnCours.Date.ToString("dd MMMM yyyy") + " au " + dtFin.ToString("dd MMMM yyyy");

            dateTimePicker1.MinDate = ficheEnCours.Date;
            dateTimePicker1.MaxDate = dtFin;

            foreach (var fraisForfait in ficheEnCours.FraisForfaits)
            {
                var item = new ListViewItem(new[]
                {
                    fraisForfait.IdFraisForfait.ToString(),
                    fraisForfait.TypeForfait.Nom,
                    fraisForfait.Quantite.ToString(),
                    fraisForfait.Date.ToString("dd MMMM yyyy"),
                    fraisForfait.Etat.ToString(),
                    //fraisForfait.justificatif.FichierBlob.
                    // Ajoutez d'autres attributs ici si nécessaire
                });
                ListViewForfait.Items.Add(item);
            }

            foreach (var fraisHorsForfait in ficheEnCours.FraisHorsForfaits)
            {
                var item = new ListViewItem(new[]
                {
                    fraisHorsForfait.IdFraisHorsForfait.ToString(),
                    fraisHorsForfait.Description,
                    fraisHorsForfait.Montant.ToString(),
                    fraisHorsForfait.Date.ToString("dd MMMM yyyy"),
                    fraisHorsForfait.Etat.ToString(),
                    //fraisHorsForfait.Justificatif.ToString(),
                });
                listViewHorsForfait.Items.Add(item);
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
        }
    }
}
