using AP_1_GSB.Data.Models;
using AP_1_GSB.Visiteur;
using AP_1_GSB.Comptable;
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
        Utilisateur utilisateur;
        FicheFraisDuMois ficheFraisDuMois;
        SelectionEmploye affichageComptable;
        FicheFrais ficheEnCours;
        FraisForfait forfaitAModifie;
        FraisHorsForfait horsForfaitAModifie;
        DateTime DateDebut;
        DateTime dateFin;
        public TableauBord(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            InitializeComponent();

            switch (utilisateur.Role)
            {
                case UtilisateurRole.Visiteur:
                    AfficherInformationsUtilisateur();
                    break;

                case UtilisateurRole.Comptable:
                    AfficherInformationComptable();
                    break;

                case UtilisateurRole.Administrateur:
                    MessageBox.Show("administrateur");
                    break;
            }
        }

        #region Visiteur

        private void RecupererDatesFiche()
        {
            DateTime now = DateTime.Now;

            if (now.Day >= 11)
            {
                DateDebut = new DateTime(now.Year, now.Month, 11);
                dateFin = new DateTime(now.Year, now.Month + 1, 10);
            }
            else
            {
                DateDebut = new DateTime(now.Year, now.Month - 1, 11);
                dateFin = new DateTime(now.Year, now.Month, 10);
            }
        }

        private void AfficherInformationsUtilisateur()
        {
            //PanelUtilisateur.BringToFront();
            PanelComptable.Hide();
            NomPrenom.Text = "Bienvenue " + utilisateur.Nom + " " + utilisateur.Prenom;

            utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);

            ficheEnCours = null;
            RecupererDatesFiche();

            ficheEnCours = Services.FicheFraisService.RecupererDerniereFiche(utilisateur, DateDebut, dateFin);
            utilisateur = Services.FicheFraisService.RecupererNotesForfait(utilisateur, ficheEnCours);
            utilisateur = Services.FicheFraisService.RecupererNotesHorsForfait(utilisateur, ficheEnCours);

            string version = "utilisateur";

            ficheFraisDuMois = new FicheFraisDuMois(utilisateur, ficheEnCours, dateFin, version);
            ficheFraisDuMois.ListesVide += () => BtnSupprimerNote.Enabled = false;
            ficheFraisDuMois.ListesVide += () => BtnModifier.Enabled = false;
            ficheFraisDuMois.VerifierListesVides();
            ficheFraisDuMois.TopLevel = false;
            PanelAffichage.Controls.Add(ficheFraisDuMois);
            ficheFraisDuMois.FormBorderStyle = FormBorderStyle.None;
            ficheFraisDuMois.Dock = DockStyle.Fill;
            ficheFraisDuMois.Show();
        }
        public void BtnAjouterNoteFrais_Clique(object sender, EventArgs e)
        {
            string VersionPopUp = "creer";
            OuvrirPopUp(VersionPopUp);
        }
        public void BtnSupprimerNote_Clique(object sender, EventArgs e)
        {
            ficheFraisDuMois.SupprimerSelectionLigne();

        }
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (ficheFraisDuMois.ListViewForfait.SelectedItems.Count > 0)
            {
                string versionPopUp = "modifierForfait";
                forfaitAModifie = ficheFraisDuMois.SelectionForfaitAModifier();
                OuvrirPopUp(versionPopUp, forfaitAModifie);
            }

            else if (ficheFraisDuMois.ListViewHorsForfait.SelectedItems.Count > 0)
            {
                string versionPopUp = "modifierHorsForfait";
                horsForfaitAModifie = ficheFraisDuMois.SelectionHorsForfaitAModifier();
                OuvrirPopUp(versionPopUp, horsForfaitAModifie);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un frais à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void OuvrirPopUp(string versionPopUp)
        {
            CreerModifierNotesFrais ajouterNoteFrais = new CreerModifierNotesFrais(utilisateur, ficheEnCours, dateFin, versionPopUp);
            ajouterNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnModifier.Enabled = true;
            ajouterNoteFrais.StartPosition = FormStartPosition.Manual;
            ajouterNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
            ajouterNoteFrais.TopLevel = true;
            ajouterNoteFrais.Show();
        }
        private void OuvrirPopUp(string versionPopUp, FraisForfait fraisForfait)
        {
            CreerModifierNotesFrais ajouterNoteFrais = new CreerModifierNotesFrais(utilisateur, ficheEnCours, dateFin, versionPopUp, fraisForfait);
            ajouterNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnModifier.Enabled = true;
            ajouterNoteFrais.StartPosition = FormStartPosition.Manual;
            ajouterNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
            ajouterNoteFrais.TopLevel = true;
            ajouterNoteFrais.Show();
        }

        private void OuvrirPopUp(string versionPopUp, FraisHorsForfait fraisHorsForfait)
        {
            CreerModifierNotesFrais ajouterNoteFrais = new CreerModifierNotesFrais(utilisateur, ficheEnCours, dateFin, versionPopUp, fraisHorsForfait);
            ajouterNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
            ajouterNoteFrais.NoteDeFraisAjoutee += () => BtnModifier.Enabled = true;
            ajouterNoteFrais.StartPosition = FormStartPosition.Manual;
            ajouterNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
            ajouterNoteFrais.TopLevel = true;
            ajouterNoteFrais.Show();
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
        #endregion


        #region Comptable 
        private void AfficherInformationComptable()
        {
            //Label ou image signifiant qu'on est sur un compte comptable 
            NomPrenom.Text = "Bienvenue " + utilisateur.Nom + " " + utilisateur.Prenom;
            PanelComptable.Visible = true;
            btnRefusFrais.Enabled = false;
            btnAccepterFrais.Enabled = false;

            affichageComptable = new SelectionEmploye();
            affichageComptable.TopLevel = false;
            PanelAffichage.Controls.Add(affichageComptable);
            affichageComptable.FormBorderStyle = FormBorderStyle.None;
            affichageComptable.Dock = DockStyle.Fill;
            affichageComptable.Show();
        }

        private void BtnAfficherFichesEmplye_Clique(object sender, EventArgs e)
        {
            Utilisateur employe = affichageComptable.SelectionnerEmploye();
            if (employe != null)
            {
                employe = Services.FicheFraisService.RecupererFichesFrais(employe);
                RecupererDatesFiche();
                ficheEnCours = Services.FicheFraisService.RecupererDerniereFiche(employe, DateDebut, dateFin);
                employe = Services.FicheFraisService.RecupererNotesForfait(employe, ficheEnCours);
                employe = Services.FicheFraisService.RecupererNotesHorsForfait(employe, ficheEnCours);

                string version = "comptable";
                btnRefusFrais.Enabled = true;
                btnAccepterFrais.Enabled = true;
                BtnAfficheFichesEmploye.Enabled = false;
                ficheFraisDuMois = new FicheFraisDuMois(employe, ficheEnCours, dateFin, version);
                ficheFraisDuMois.ListesVide += () => btnRefusFrais.Enabled = false;
                ficheFraisDuMois.VerifierListesVides();
                ficheFraisDuMois.GriserBouton += () => btnRefusFrais.Enabled = false;
                ficheFraisDuMois.GriserBouton += () => btnAccepterFrais.Enabled = false;
                ficheFraisDuMois.GriserBouton += () => BtnAfficheFichesEmploye.Enabled = true;
                ficheFraisDuMois.TopLevel = false;
                PanelAffichage.Controls.Add(ficheFraisDuMois);
                ficheFraisDuMois.FormBorderStyle = FormBorderStyle.None;
                ficheFraisDuMois.Dock = DockStyle.Fill;
                ficheFraisDuMois.BringToFront();
                ficheFraisDuMois.Show();
            }
        }
        private void btnRefusFrais_Click(object sender, EventArgs e)
        {
            ficheFraisDuMois.RefuserFrais();
        }
        private void btnAccepterFrais_Click(object sender, EventArgs e)
        {
            ficheFraisDuMois.AccepterFrais();
        }
        #endregion

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

