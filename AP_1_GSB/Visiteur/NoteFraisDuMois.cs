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
            DateTime prochainMois = DateTime.Now.AddMonths(1);
            DateTime DateMin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 11);
            DateTime DateMax = new DateTime(DateTime.Now.Year, prochainMois.Month, 10);
            this.Utilisateur = utilisateur;
            InitializeComponent();
            DateFicheFrais.Text = "Fiche de frais du 11 " + DateTime.Now.ToString("MMMM yyyy") + " au 10 " + DateTime.Now.AddMonths(1).ToString("MMMM yyyy");
            dateTimePicker1.MinDate = DateMin;
            dateTimePicker1.MaxDate = DateMax;

            byte[] blob = utilisateur.FichesFrais[0].FraisForfaits[1].justificatif.FichierBlob;
            using (MemoryStream ms = new MemoryStream(blob))
            {
                Image image = Image.FromStream(ms);
                // Vous pouvez maintenant utiliser l'objet image.
                // Par exemple, pour l'afficher dans un PictureBox :
                pictureBox1.Image = image;
                pictureBox1.Size = image.Size;
            }
        }
    }
}
