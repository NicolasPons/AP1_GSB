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
    public partial class TableauBord : Form
    {
        readonly Utilisateur utilisateur;
        FicheFraisDuMois FicheFraisDuMois;
        FicheFrais ficheEnCours;
        DateTime dtFin;
        public TableauBord(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            InitializeComponent();
            NomPrenom.Text = "Bienvenue " + utilisateur.Nom + " " + utilisateur.Prenom;


            utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);

            ficheEnCours = null;
            DateTime now = DateTime.Now;
            DateTime DateDebut;

            if (now.Day >= 11)
            {
                DateDebut = new DateTime(now.Year, now.Month, 11);
                dtFin = new DateTime(now.Year, now.Month + 1, 10);
            }
            else
            {
                DateDebut = new DateTime(now.Year, now.Month - 1, 11);
                dtFin = new DateTime(now.Year, now.Month, 10);
            }


            utilisateur.FichesFrais.ForEach
                (
                    ficheFrais =>
                    {
                        if (ficheFrais.Date >= DateDebut && ficheFrais.Date <= dtFin)
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

            FicheFraisDuMois = new FicheFraisDuMois(utilisateur, ficheEnCours, dtFin);
            FicheFraisDuMois.ListesVide += () => BtnSupprimerNote.Enabled = false;
            FicheFraisDuMois.VerifierListesVides();
            FicheFraisDuMois.TopLevel = false;
            PanelAffichage.Controls.Add(FicheFraisDuMois);
            FicheFraisDuMois.FormBorderStyle = FormBorderStyle.None;
            FicheFraisDuMois.Dock = DockStyle.Fill;
            FicheFraisDuMois.Show();
        }

        // TESTER ALGORITHME POUR VOIR SI FICHEFRAIS RECUP EST LA BONNE 
        // TESTER ALGORITHME POUR VOIR SI FICHEENCOURS EST BIEN LA DERNIERE FICHE EN CAS DE CREATION DE FICHE 
        public void BtnAjouterNoteFrais_Clique(object sender, EventArgs e)
        {
            AjouterNoteDeFrais ajouterNoteFrais = new AjouterNoteDeFrais(utilisateur, ficheEnCours, dtFin);

            ajouterNoteFrais.NoteDeFraisAjoutee += FicheFraisDuMois.MettreAJourListView;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
            ajouterNoteFrais.StartPosition = FormStartPosition.Manual;
            ajouterNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
            ajouterNoteFrais.TopLevel = true;
            ajouterNoteFrais.Show();
        }
        public void BtnSupprimerNote_Clique(object sender, EventArgs e)
        {
            FicheFraisDuMois.SupprimerSelectionLigne();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
