using AP_1_GSB.Data.Models;
using AP_1_GSB.Visiteur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB
{
    public partial class Dashboard : Form
    {
        Utilisateur utilisateur;
        public Dashboard(Data.Models.Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            InitializeComponent();
            NomPrenom.Text = "Bienvenue " + utilisateur.Nom + " " + utilisateur.Prenom;
        }


        private void BtnAjouterNoteFrais(object sender, EventArgs e)
        {
            FicheFrais ficheEnCours = null;
            utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);


            utilisateur.FichesFrais.ForEach(ficheFrais =>
            {
                if (ficheFrais.Date.Month == DateTime.Now.Month && ficheFrais.Date.Year == DateTime.Now.Year)
                {
                    ficheEnCours = ficheFrais;
                }
            });

            if (ficheEnCours == null)
            {
                Services.FicheFraisService.CreerFicheFraisMoisEnCours(utilisateur);
                return;
            }


            NoteFraisDuMois ajouterNoteFrais = new NoteFraisDuMois(utilisateur, ficheEnCours);
            ajouterNoteFrais.TopLevel = false;
            myPanel.Controls.Add(ajouterNoteFrais);
            ajouterNoteFrais.FormBorderStyle = FormBorderStyle.None;
            ajouterNoteFrais.Dock = DockStyle.Fill;
            ajouterNoteFrais.Show();

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
