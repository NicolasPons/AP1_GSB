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
        FicheFraisDuMois affichageFicheFraisDuMois;
        public Dashboard(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            InitializeComponent();
            NomPrenom.Text = "Bienvenue " + utilisateur.Nom + " " + utilisateur.Prenom;

            utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);

            FicheFrais ficheEnCours = null;
            DateTime now = DateTime.Now;
            DateTime DateDebut, endDate;

            if (now.Day >= 11)
            {
                DateDebut = new DateTime(now.Year, now.Month, 11);
                endDate = new DateTime(now.Year, now.Month + 1, 10);
            }
            else
            {
                DateDebut = new DateTime(now.Year, now.Month - 1, 11);
                endDate = new DateTime(now.Year, now.Month, 10);
            }


            utilisateur.FichesFrais.ForEach
                (
                    ficheFrais =>
                    {
                        if (ficheFrais.Date >= DateDebut && ficheFrais.Date <= endDate)
                        {
                            ficheEnCours = ficheFrais;
                        }
                    }
                );

            if (ficheEnCours == null)
            {
                utilisateur = Services.FicheFraisService.CreerFicheFraisMoisEnCours(utilisateur, DateDebut);
                ficheEnCours = utilisateur.FichesFrais.Last();
            }

            utilisateur = Services.FicheFraisService.RecupererNotesForfait(utilisateur, ficheEnCours);
            utilisateur = Services.FicheFraisService.RecupererNotesHorsForfait(utilisateur, ficheEnCours);

            affichageFicheFraisDuMois = new FicheFraisDuMois(utilisateur, ficheEnCours);
            affichageFicheFraisDuMois.ListesVide += () => BtnSupprimerNote.Enabled = false;
            affichageFicheFraisDuMois.TopLevel = false;
            PanelAffichage.Controls.Add(affichageFicheFraisDuMois);
            affichageFicheFraisDuMois.FormBorderStyle = FormBorderStyle.None;
            affichageFicheFraisDuMois.Dock = DockStyle.Fill;
            affichageFicheFraisDuMois.Show();
        }

        // TESTER ALGORITHME POUR VOIR SI FICHEFRAIS RECUP EST LA BONNE 
        // TESTER ALGORITHME POUR VOIR SI FICHEENCOURS EST BIEN LA DERNIERE FICHE EN CAS DE CREATION DE FICHE 
        public void BtnAjouterNoteFrais_Clique(object sender, EventArgs e)
        {
        }
        public void BtnSupprimerNote_Clique(object sender, EventArgs e)
        {
            affichageFicheFraisDuMois.SupprimerFraisForfait();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
