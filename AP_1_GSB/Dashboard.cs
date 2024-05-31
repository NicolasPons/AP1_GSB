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

    //FONCTION DELETE UPDATE DE TYPE BOOLEEN POUR VERIFIER LA SUPPRESSION/AJOUT DANS LA BD
    //VERIFIER L'ID RETOURNE PAR EXECUTESCALAR ET COMPARER AVEC LA VALEUR 
    public partial class Dashboard : Form
    {
        Utilisateur utilisateur;
        public Dashboard(Data.Models.Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            InitializeComponent();
            NomPrenom.Text = "Bienvenue " + utilisateur.Nom + " " + utilisateur.Prenom;
        }

        //DEBUG EN COURS. VERIFIER LA VALEUR DU DERNIER ID. ID EST 10 en BD MAIS RESSORT 0 EN OBJET. WHY ??? WHY ALWAYS ME ??? 
        private void BtnAjouterNoteFrais(object sender, EventArgs e)
        {
            utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);
            utilisateur = Services.FicheFraisService.CreerFicheFraisMoisEnCours(utilisateur);
            FicheFrais ficheTest = utilisateur.FichesFrais.Last();
            int IdFicheFrais = ficheTest.IdFicheFrais;
            MessageBox.Show("L'ID de la dernière fiche en objet est : " + IdFicheFrais);

            //FicheFrais ficheEnCours = null;
            //utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);


            //utilisateur.FichesFrais.ForEach(ficheFrais =>
            //{
            //    if (ficheFrais.Date.Month == DateTime.Now.Month && ficheFrais.Date.Year == DateTime.Now.Year)
            //    {
            //        ficheEnCours = ficheFrais;
            //    }
            //});

            //if (ficheEnCours == null)
            //{
            //    utilisateur = Services.FicheFraisService.CreerFicheFraisMoisEnCours(utilisateur);
            //    ficheEnCours = Services.FicheFraisService.RecupererDerniereFiche(utilisateur.FichesFrais);
            //    //ficheEnCours = utilisateur.FichesFrais.Last();
            //}

            //NoteFraisDuMois ajouterNoteFrais = new NoteFraisDuMois(utilisateur, ficheEnCours);
            //ajouterNoteFrais.TopLevel = false;
            //myPanel.Controls.Add(ajouterNoteFrais);
            //ajouterNoteFrais.FormBorderStyle = FormBorderStyle.None;
            //ajouterNoteFrais.Dock = DockStyle.Fill;
            //ajouterNoteFrais.Show();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
