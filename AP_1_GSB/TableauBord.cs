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
using AP_1_GSB.Administrateur;

namespace AP_1_GSB
{

    //FONCTION DELETE UPDATE DE TYPE BOOLEEN POUR VERIFIER LA SUPPRESSION/AJOUT DANS LA BD
    //VERIFIER L'ID RETOURNE PAR EXECUTESCALAR ET COMPARER AVEC LA VALEUR 
    public partial class TableauBord : Form
    {
        Login loginForm;
        Utilisateur utilisateur;
        FicheFraisDuMois ficheFraisDuMois;
        InterfacePrincipaleComptable affichageComptable;
        FicheFrais ficheEnCours;
        //FraisForfait forfaitAModifie;
        //FraisHorsForfait horsForfaitAModifie;
        DateTime DateDebut;
        DateTime dateFin;
        AffichageHistorique affichageHistorique = null;
        CreerModifierNoteFrais2 creerModifierNoteFrais = null;
        AjouterModifierTypeFraisForfait ajouterModifierTypeFraisForfait = null;
        CreerModifierUtilisateur creerModifierUtilisateur = null;
        InterfacePrincipaleAdmin interfaceAdmin;

        public TableauBord(Utilisateur utilisateur, Login loginForm)
        {
            this.utilisateur = utilisateur;
            this.loginForm = loginForm;
            InitializeComponent();

            switch (utilisateur.Role)
            {
                case UtilisateurRole.Visiteur:
                    AfficherInterfaceUtilisateur();
                    break;

                case UtilisateurRole.Comptable:
                    AfficherInterfaceComptable();
                    break;

                case UtilisateurRole.Administrateur:
                    AfficherInterfaceAdministrateur();
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

        private void AfficherInterfaceUtilisateur()
        {
            //PanelUtilisateur.BringToFront();
            PanelComptable.Hide();
            panelAdministrateur.Hide();
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
            AfficherPopUpCreationModification(VersionPopUp);
        }
        public void BtnSupprimerNote_Clique(object sender, EventArgs e)
        {
            ficheFraisDuMois.SupprimerSelectionLigne();

        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (ficheFraisDuMois.ListViewForfait.SelectedItems.Count > 0)
            {
                int idForfait = (int)ficheFraisDuMois.ListViewForfait.SelectedItems[0].Tag;
                FraisForfait fraisForfait = ficheEnCours.FraisForfaits.FirstOrDefault(item => item.IdFraisForfait == idForfait);
                AfficherPopUpCreationModification("modifierForfait", fraisForfait);
            }

            else if (ficheFraisDuMois.ListViewHorsForfait.SelectedItems.Count > 0)
            {
                string versionPopUp = "modifierHorsForfait";
                int idHorsForfait = (int)ficheFraisDuMois.ListViewHorsForfait.SelectedItems[0].Tag;
                FraisHorsForfait fraisHorsForfait = ficheEnCours.FraisHorsForfaits.FirstOrDefault(item => item.IdFraisHorsForfait == idHorsForfait);

                AfficherPopUpCreationModification(versionPopUp, fraisHorsForfait);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un frais à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AfficherPopUpCreationModification(string versionPopUp)
        {
            if (creerModifierNoteFrais == null || creerModifierNoteFrais.IsDisposed)
            {
                creerModifierNoteFrais = new CreerModifierNoteFrais2(utilisateur, ficheEnCours, dateFin, versionPopUp);
                creerModifierNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnModifier.Enabled = true;
                creerModifierNoteFrais.StartPosition = FormStartPosition.Manual;
                creerModifierNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                creerModifierNoteFrais.TopLevel = true;
            }
            creerModifierNoteFrais.Show();
        }
        private void AfficherPopUpCreationModification(string versionPopUp, FraisForfait fraisForfait)
        {
            if (creerModifierNoteFrais == null || creerModifierNoteFrais.IsDisposed)
            {
                creerModifierNoteFrais = new CreerModifierNoteFrais2(utilisateur, ficheEnCours, dateFin, versionPopUp, fraisForfait);
                creerModifierNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnModifier.Enabled = true;
                creerModifierNoteFrais.StartPosition = FormStartPosition.Manual;
                creerModifierNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                creerModifierNoteFrais.TopLevel = true;

            }
            creerModifierNoteFrais.Show();
        }

        private void AfficherPopUpCreationModification(string versionPopUp, FraisHorsForfait fraisHorsForfait)
        {
            if (creerModifierNoteFrais == null || creerModifierNoteFrais.IsDisposed)
            {
                creerModifierNoteFrais = new CreerModifierNoteFrais2(utilisateur, ficheEnCours, dateFin, versionPopUp, fraisHorsForfait);
                creerModifierNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNote.Enabled = true;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnModifier.Enabled = true;
                creerModifierNoteFrais.StartPosition = FormStartPosition.Manual;
                creerModifierNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                creerModifierNoteFrais.TopLevel = true;
                creerModifierNoteFrais.Show();
            }
        }

        private void BtnHistorique_Click(object sender, EventArgs e)
        {

            GriserBouton(false, false, false);

            if (affichageHistorique == null)
            {
                affichageHistorique = new AffichageHistorique(utilisateur);
                affichageHistorique.degriserBouton += () => GriserBouton(true, true, true);
                affichageHistorique.StartPosition = FormStartPosition.Manual;
                affichageHistorique.TopLevel = false;
                PanelAffichage.Controls.Add(affichageHistorique);
                affichageHistorique.FormBorderStyle = FormBorderStyle.None;
                affichageHistorique.Dock = DockStyle.Fill;
            }
            affichageHistorique.BringToFront();
            affichageHistorique.Show();
        }

        private void GriserBouton(bool btnAJout, bool btnSupprimer, bool btnModif)
        {
            btnAjouterNoteFrais.Enabled = btnAJout;
            BtnSupprimerNote.Enabled = btnSupprimer;
            BtnModifier.Enabled = btnModif;
        }
        #endregion


        #region Comptable 
        private void AfficherInterfaceComptable()
        {
            //Label ou image signifiant qu'on est sur un compte comptable 
            NomPrenom.Text = "Bienvenue " + utilisateur.Nom + " " + utilisateur.Prenom;
            PanelComptable.Visible = true;
            PanelComptable.BringToFront();
            panelAdministrateur.Hide();
       
            btnRefusFrais.Enabled = false;
            btnAccepterFrais.Enabled = false;

            affichageComptable = new InterfacePrincipaleComptable();
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
                ficheFraisDuMois.ListesVide += () => btnAccepterFrais.Enabled = false;
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

        #region Administrateur
        private void AfficherInterfaceAdministrateur()
        {
            panelAdministrateur.Visible = true;
            panelAdministrateur.BringToFront();
            PanelComptable.Hide();
            NomPrenom.Text = "Profil administrateur";

            interfaceAdmin = new InterfacePrincipaleAdmin();
            interfaceAdmin.TopLevel = false;
            PanelAffichage.Controls.Add(interfaceAdmin);
            interfaceAdmin.FormBorderStyle = FormBorderStyle.None;
            interfaceAdmin.Dock = DockStyle.Fill;
            interfaceAdmin.Show();
        }
        private void btnAjouterTypeFrais_Clique(object sender, EventArgs e)
        {
            string version = "ajouter";

            if (ajouterModifierTypeFraisForfait == null || ajouterModifierTypeFraisForfait.IsDisposed)
            {
                ajouterModifierTypeFraisForfait = new AjouterModifierTypeFraisForfait(version);
                ajouterModifierTypeFraisForfait.StartPosition = FormStartPosition.Manual;
                ajouterModifierTypeFraisForfait.TypeFraisForfaitEvenement += interfaceAdmin.MettreAJourListViewAdmin;
                ajouterModifierTypeFraisForfait.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                ajouterModifierTypeFraisForfait.TopLevel = true;
            }
            ajouterModifierTypeFraisForfait.Show();
        }
        private void btnModifierTypeFrais_Click(object sender, EventArgs e)
        {
            string version = "modfier";
            if (interfaceAdmin.ListViewTypeFraisForfait.SelectedItems.Count > 0)
            {
                List<TypeFraisForfait> TypesFraisForfait = new List<TypeFraisForfait>();
                TypesFraisForfait = Services.TypeFraisForfaitService.RecupererTypeFraisForfait();
                int idTypFrais = (int)interfaceAdmin.ListViewTypeFraisForfait.SelectedItems[0].Tag;
                TypeFraisForfait typeFraisForfait = TypesFraisForfait.FirstOrDefault(frais => frais.IdFraisForfait == idTypFrais);

                if (ajouterModifierTypeFraisForfait == null || ajouterModifierTypeFraisForfait.IsDisposed)
                {
                    ajouterModifierTypeFraisForfait = new AjouterModifierTypeFraisForfait(version, typeFraisForfait);
                    ajouterModifierTypeFraisForfait.StartPosition = FormStartPosition.Manual;
                    ajouterModifierTypeFraisForfait.TypeFraisForfaitEvenement += interfaceAdmin.MettreAJourListViewAdmin;
                    ajouterModifierTypeFraisForfait.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                    ajouterModifierTypeFraisForfait.TopLevel = true;
                }
                ajouterModifierTypeFraisForfait.Show();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un type de frais à modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnAjoutUtilisateur_Clique(object sender, EventArgs e)
        {
            string version = "ajouter";

            if (creerModifierUtilisateur == null || creerModifierUtilisateur.IsDisposed)
            {
                creerModifierUtilisateur = new CreerModifierUtilisateur(version);
                creerModifierUtilisateur.StartPosition = FormStartPosition.Manual;
                creerModifierUtilisateur.UtilisateurEvenement += interfaceAdmin.MettreAJourListViewAdmin;
                creerModifierUtilisateur.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                creerModifierUtilisateur.TopLevel = true;
            }
            creerModifierUtilisateur.Show();
        }
        private void btnModifierUtilisateur_Clique(object sender, EventArgs e)
        {
            string version = "modifier";
            if (interfaceAdmin.ListViewUtilisateur.SelectedItems.Count > 0)
            {
                List<Utilisateur> utilisateurs = new List<Utilisateur>();
                utilisateurs = Services.UtilisateurService.RecupererUtilisateurs();
                int idUtilisateur = (int)interfaceAdmin.ListViewUtilisateur.SelectedItems[0].Tag;
                Utilisateur utilisateur = utilisateurs.FirstOrDefault(item => item.IdUtilisateur == idUtilisateur);

                if (creerModifierUtilisateur == null || creerModifierUtilisateur.IsDisposed)
                {
                    creerModifierUtilisateur = new CreerModifierUtilisateur(version, utilisateur);
                    creerModifierUtilisateur.StartPosition = FormStartPosition.Manual;
                    creerModifierUtilisateur.UtilisateurEvenement += interfaceAdmin.MettreAJourListViewAdmin;
                    creerModifierUtilisateur.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                    creerModifierUtilisateur.TopLevel = true;
                }
                creerModifierUtilisateur.Show();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSupprimerUtilisateur_Clique(object sender, EventArgs e)
        {
            if (interfaceAdmin.ListViewUtilisateur.SelectedItems.Count > 0)
            {
                List<Utilisateur> utilisateurs = new List<Utilisateur>();
                utilisateurs = Services.UtilisateurService.RecupererUtilisateurs();
                int idUtilisateur = (int)interfaceAdmin.ListViewUtilisateur.SelectedItems[0].Tag;
                Utilisateur utilisateur = utilisateurs.FirstOrDefault(item => item.IdUtilisateur == idUtilisateur);

                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Services.UtilisateurService.SupprimerUtilisateur(utilisateur))
                    {
                        MessageBox.Show("Utilisateur supprimé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        interfaceAdmin.MettreAJourListViewAdmin();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'utilisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        #endregion
        private void btnRetourLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.SaisieMdp.Clear();
            loginForm.SaisieUtilisateur.Clear();
            loginForm.Show();
        }
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

