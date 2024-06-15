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
        FicheFraisDuMois ficheFraisDuMois;
        FicheFrais ficheEnCours;
        FraisForfait forfaitAModifie;
        FraisHorsForfait horsForfaitAModifie;
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

            ficheFraisDuMois = new FicheFraisDuMois(utilisateur, ficheEnCours, dtFin);
            ficheFraisDuMois.ListesVide += () => BtnSupprimerNote.Enabled = false;
            ficheFraisDuMois.ListesVide += () => BtnModifier.Enabled = false;
            ficheFraisDuMois.VerifierListesVides();
            ficheFraisDuMois.TopLevel = false;
            PanelAffichage.Controls.Add(ficheFraisDuMois);
            ficheFraisDuMois.FormBorderStyle = FormBorderStyle.None;
            ficheFraisDuMois.Dock = DockStyle.Fill;
            ficheFraisDuMois.Show();
        }

        // TESTER ALGORITHME POUR VOIR SI FICHEFRAIS RECUP EST LA BONNE 
        // TESTER ALGORITHME POUR VOIR SI FICHEENCOURS EST BIEN LA DERNIERE FICHE EN CAS DE CREATION DE FICHE 
        public void BtnAjouterNoteFrais_Clique(object sender, EventArgs e)
        {
            string mode = "creer";
            OuvrirPopUp(mode);
        }
        public void BtnSupprimerNote_Clique(object sender, EventArgs e)
        {
            ficheFraisDuMois.SupprimerSelectionLigne();
            
        }
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (ficheFraisDuMois.ListViewForfait.SelectedItems.Count > 0)
            {
                string mode = "modifierForfait";
                forfaitAModifie = ficheFraisDuMois.SelectionForfaitAModifier();
                OuvrirPopUp(mode, forfaitAModifie);
            }

            else if (ficheFraisDuMois.ListViewHorsForfait.SelectedItems.Count > 0)
            {
                string mode = "modifierHorsForfait";
                horsForfaitAModifie = ficheFraisDuMois.SelectionHorsForfaitAModifier();
                OuvrirPopUp(mode, horsForfaitAModifie);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un frais à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OuvrirPopUp(string mode)
        {
            CreerModifierNotesFrais ajouterNoteFrais = new CreerModifierNotesFrais(utilisateur, ficheEnCours, dtFin, mode);
            ajouterNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnModifier.Enabled = true;
            ajouterNoteFrais.StartPosition = FormStartPosition.Manual;
            ajouterNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
            ajouterNoteFrais.TopLevel = true;
            ajouterNoteFrais.Show();
        }
        private void OuvrirPopUp(string mode, FraisForfait fraisForfait)
        {
            CreerModifierNotesFrais ajouterNoteFrais = new CreerModifierNotesFrais(utilisateur, ficheEnCours, dtFin, mode, fraisForfait);
            ajouterNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnModifier.Enabled = true;
            ajouterNoteFrais.StartPosition = FormStartPosition.Manual;
            ajouterNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
            ajouterNoteFrais.TopLevel = true;
            ajouterNoteFrais.Show();
        }

        private void OuvrirPopUp(string mode, FraisHorsForfait fraisHorsForfait)
        {
            CreerModifierNotesFrais ajouterNoteFrais = new CreerModifierNotesFrais(utilisateur, ficheEnCours, dtFin, mode, fraisHorsForfait);
            ajouterNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnModifier.Enabled = true;
            ajouterNoteFrais.StartPosition = FormStartPosition.Manual;
            ajouterNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
            ajouterNoteFrais.TopLevel = true;
            ajouterNoteFrais.Show();
        }


        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHistorique_Click(object sender, EventArgs e)
        {
            AffichageHistorique affichageHistorique = new AffichageHistorique(utilisateur);
            affichageHistorique.StartPosition = FormStartPosition.Manual;
            affichageHistorique.TopLevel = false;
            PanelAffichage.Controls.Add(affichageHistorique);
            affichageHistorique.FormBorderStyle = FormBorderStyle.None;
            affichageHistorique.Dock = DockStyle.Fill;
            affichageHistorique.BringToFront();
            affichageHistorique.Show();
        }
    }
}

