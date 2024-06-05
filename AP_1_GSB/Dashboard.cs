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
        public Dashboard(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            InitializeComponent();
            NomPrenom.Text = "Bienvenue " + utilisateur.Nom + " " + utilisateur.Prenom;
        }

        // TESTER ALGORITHME POUR VOIR SI FICHEFRAIS RECUP EST LA BONNE 
        // TESTER ALGORITHME POUR VOIR SI FICHEENCOURS EST BIEN LA DERNIERE FICHE EN CAS DE CREATION DE FICHE 
        private void BtnAjouterNoteFrais(object sender, EventArgs e)
        {
            utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);

            FicheFrais ficheEnCours = null;
            DateTime now = DateTime.Now;
            DateTime startDate, endDate;

            if (now.Day >= 11)
            {
                startDate = new DateTime(now.Year, now.Month, 11);
                endDate = new DateTime(now.Year, now.Month + 1, 10);
            }
            else
            {
                startDate = new DateTime(now.Year, now.Month - 1, 11);
                endDate = new DateTime(now.Year, now.Month, 10);
            }


            utilisateur.FichesFrais.ForEach
                (
                    ficheFrais =>
                    {
                        if (ficheFrais.Date >= startDate && ficheFrais.Date <= endDate)
                        {
                            ficheEnCours = ficheFrais;
                        }
                    }
                );

            if (ficheEnCours == null)
            {
                DateTime dateCreationFiche = startDate;
                utilisateur = Services.FicheFraisService.CreerFicheFraisMoisEnCours(utilisateur, dateCreationFiche);
                ficheEnCours = utilisateur.FichesFrais.Last();
            }

            utilisateur = Services.FicheFraisService.RecupererNotesForfait(utilisateur, ficheEnCours);
            utilisateur = Services.FicheFraisService.RecupererNotesHorsForfait(utilisateur, ficheEnCours);

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
