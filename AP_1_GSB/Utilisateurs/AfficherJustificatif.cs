using AP_1_GSB.Data.Models;
using AP_1_GSB.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB
{
    public partial class AfficherJustificatif : Form
    {
        FraisForfait fraisForfait;
        FraisHorsForfait fraisHorsForfait;

        //Deux constructeurs pour afficher le justificatif en fonction du type de frais. 
        //Transforme le fichier byte[] en Image via une méthode et affiche l'image dans le picture box
        public AfficherJustificatif(FraisForfait frais)
        {
            InitializeComponent();
            this.fraisForfait = frais;
            byte[] blob = fraisForfait.justificatif.FichierBlob;
            Image image = JustificatifService.AfficherJustificatif(blob);
            btnQuitter.BringToFront();
            PictureBoxJustificatif.Image = image;
            PictureBoxJustificatif.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public AfficherJustificatif(FraisHorsForfait frais)
        {
            InitializeComponent();
            this.fraisHorsForfait = frais;
            byte[] blob = fraisHorsForfait.Justificatif.FichierBlob;
            Image image = JustificatifService.AfficherJustificatif(blob);
            btnQuitter.BringToFront();
            PictureBoxJustificatif.Image = image;
            PictureBoxJustificatif.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
