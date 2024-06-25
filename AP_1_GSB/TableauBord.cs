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
using System.IO;
using AP_1_GSB.Services;
using AP_1_GSB;
using System.Runtime.InteropServices;


namespace AP_1_GSB
{ 
    public partial class TableauBord : Form
    {
        Login loginForm;
        Utilisateur utilisateur;
        FicheFraisDuMois ficheFraisDuMois;
        FicheFrais ficheEnCours;
        DateTime DateDebut;
        DateTime dateFin;
        InterfacePrincipaleComptable affichageComptable;
        AffichageHistorique affichageHistorique = null;
        CreerModifierNoteFrais creerModifierNoteFrais = null;
        AjouterModifierTypeFraisForfait ajouterModifierTypeFraisForfait = null;
        CreerModifierUtilisateur creerModifierUtilisateur = null;
        InterfacePrincipaleAdmin interfaceAdmin = null;
        AfficherJustificatif affichageJustificatif = null;

        public TableauBord(Utilisateur utilisateur, Login loginForm)
        {
            this.utilisateur = utilisateur;
            this.loginForm = loginForm;
            //this.Text = string.Empty;
            //this.ControlBox = false;
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

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);



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

            panelMenu.Controls.Add(PanelUtilisateur);
            panelMenu.Controls.Add(panelAdministrateur);
            panelMenu.Controls.Add(PanelComptable);
            panelMenu.Controls.Add(PanelUtilsateurLogo);
            panelMenu.Dock = DockStyle.Left;
            PanelUtilsateurLogo.Dock = DockStyle.Top;
            PanelUtilisateur.Dock = DockStyle.Bottom;
            panelAdministrateur.Visible = false;
            PanelComptable.Visible = false;
            PanelUtilisateur.Visible = true;
            PanelUtilsateurLogo.Visible = true;
            AssignerEvenementBouton();

            LblNom.Text = "" + utilisateur.Nom;
            LblPrenom.Text = "" + utilisateur.Prenom;
            LblProfilUtilisateur.Text = "Profil : " + utilisateur.Role.ToString();

            utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);
            foreach (FicheFrais fiche in utilisateur.FichesFrais)
            {
                DateTime dateFin = new DateTime(fiche.Date.Year, fiche.Date.AddMonths(1).Month, 10);
                if (dateFin < DateTime.Now)
                {
                    fiche.Etat = EtatFicheFrais.HorsDelai;
                    FicheFraisService.ChangerEtatFiche(fiche, 1);
                }
            }


            ficheEnCours = null;
            RecupererDatesFiche();
            ficheEnCours = Services.FicheFraisService.RecupererDerniereFiche(utilisateur, DateDebut, dateFin);
            utilisateur = Services.FicheFraisService.RecupererNotesForfait(utilisateur, ficheEnCours);
            utilisateur = Services.FicheFraisService.RecupererNotesHorsForfait(utilisateur, ficheEnCours);

            string version = "utilisateur";

            ficheFraisDuMois = new FicheFraisDuMois(utilisateur, ficheEnCours, dateFin, version);
            ficheFraisDuMois.ListesVide += () => BtnSupprimerNoteVisiteur.Enabled = false;
            ficheFraisDuMois.ListesVide += () => BtnModifierNoteVisiteur.Enabled = false;
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
                creerModifierNoteFrais = new CreerModifierNoteFrais(utilisateur, ficheEnCours, dateFin, versionPopUp);
                creerModifierNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNoteVisiteur.Enabled = true;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnModifierNoteVisiteur.Enabled = true;
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
                creerModifierNoteFrais = new CreerModifierNoteFrais(utilisateur, ficheEnCours, dateFin, versionPopUp, fraisForfait);
                creerModifierNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNoteVisiteur.Enabled = true;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnModifierNoteVisiteur.Enabled = true;
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
                creerModifierNoteFrais = new CreerModifierNoteFrais(utilisateur, ficheEnCours, dateFin, versionPopUp, fraisHorsForfait);
                creerModifierNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourListView;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNoteVisiteur.Enabled = true;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnModifierNoteVisiteur.Enabled = true;
                creerModifierNoteFrais.StartPosition = FormStartPosition.Manual;
                creerModifierNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                creerModifierNoteFrais.TopLevel = true;
            }
            creerModifierNoteFrais.Show();
        }

        private void BtnAfficherJustificatifUtilisateur_Click(object sender, EventArgs e)
        {
            AfficherJustificatif();
        }
        private void BtnHistorique_Click(object sender, EventArgs e)
        {

            GriserBouton(false, false, false, false);

            if (affichageHistorique == null)
            {
                affichageHistorique = new AffichageHistorique(utilisateur, ficheEnCours, ficheFraisDuMois.ListViewForfait, ficheFraisDuMois.ListViewHorsForfait);
                affichageHistorique.degriserBouton += () => GriserBouton(true, true, true, true);
                affichageHistorique.StartPosition = FormStartPosition.Manual;
                affichageHistorique.TopLevel = false;
                PanelAffichage.Controls.Add(affichageHistorique);
                affichageHistorique.FormBorderStyle = FormBorderStyle.None;
                affichageHistorique.Dock = DockStyle.Fill;
            }
            affichageHistorique.BringToFront();
            affichageHistorique.Show();
        }


        private void GriserBouton(bool btnAJout, bool btnSupprimer, bool btnModif, bool btnJustif)
        {
            BtnAjouterNoteFraisVisiteur.Enabled = btnAJout;
            BtnSupprimerNoteVisiteur.Enabled = btnSupprimer;
            BtnModifierNoteVisiteur.Enabled = btnModif;
            BtnAfficherJustificatifUtilisateur.Enabled = btnJustif;
        }

        private void BtnRetourLoginUtilisateur_Click(object sender, EventArgs e)
        {
            RetourLogin();
        }
        #endregion


        #region Comptable 
        private void AfficherInterfaceComptable()
        {
            panelMenu.Controls.Add(PanelUtilisateur);
            panelMenu.Controls.Add(panelAdministrateur);
            panelMenu.Controls.Add(PanelComptable);
            panelMenu.Controls.Add(PanelUtilsateurLogo);
            panelMenu.Dock = DockStyle.Left;
            PanelUtilsateurLogo.Dock = DockStyle.Top;
            PanelComptable.Dock = DockStyle.Bottom;
            panelAdministrateur.Visible = false;
            PanelComptable.Visible = true;
            PanelUtilsateurLogo.Visible = true;
            PanelUtilisateur.Visible = false;
            AssignerEvenementBouton();

            LblNom.Text = "" + utilisateur.Nom;
            LblPrenom.Text = "" + utilisateur.Prenom;
            LblProfilUtilisateur.Text = "Profil : " + utilisateur.Role.ToString();

            btnRefusFrais.Enabled = false;
            btnAccepterFrais.Enabled = false;
            BtnAfficherJustificatifComptable.Enabled = false;

            affichageComptable = new InterfacePrincipaleComptable();
            affichageComptable.TopLevel = false;
            PanelAffichage.Controls.Add(affichageComptable);
            affichageComptable.FormBorderStyle = FormBorderStyle.None;
            affichageComptable.Dock = DockStyle.Fill;
            affichageComptable.Show();
        }

        private void BtnAfficherFichesEmplye_Clique(object sender, EventArgs e)
        {
            Utilisateur employe = affichageComptable.SelectionnerVisiteur();
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
                BtnAfficherJustificatifComptable.Enabled = true;
                BtnAfficheFichesEmploye.Enabled = false;
                ficheFraisDuMois = new FicheFraisDuMois(employe, ficheEnCours, dateFin, version);
                ficheFraisDuMois.ListesVide += () => btnRefusFrais.Enabled = false;
                ficheFraisDuMois.ListesVide += () => btnAccepterFrais.Enabled = false;
                ficheFraisDuMois.ListesVide += () => BtnAfficherJustificatifComptable.Enabled = false;
                ficheFraisDuMois.VerifierListesVides();
                ficheFraisDuMois.GriserBouton += () => btnRefusFrais.Enabled = false;
                ficheFraisDuMois.GriserBouton += () => btnAccepterFrais.Enabled = false;
                ficheFraisDuMois.GriserBouton += () => BtnAfficherJustificatifComptable.Enabled = false;
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
        private void BtnAfficherJustificatifComptable_Click(object sender, EventArgs e)
        {
            AfficherJustificatif();
        }

        private void BtnRetourLoginComptable_Click(object sender, EventArgs e)
        {
            RetourLogin();
        }
        #endregion

        #region Administrateur

        private void AfficherInterfaceAdministrateur()
        {

            panelMenu.Controls.Add(PanelUtilisateur);
            panelMenu.Controls.Add(panelAdministrateur);
            panelMenu.Controls.Add(PanelComptable);
            panelMenu.Controls.Add(PanelUtilsateurLogo);
            panelMenu.Dock = DockStyle.Left;
            PanelUtilsateurLogo.Dock = DockStyle.Top;
            panelAdministrateur.Dock = DockStyle.Bottom;
            PanelUtilsateurLogo.Visible = true;
            panelAdministrateur.Visible = true;
            PanelComptable.Visible = false;
            PanelUtilisateur.Visible = false;
            AssignerEvenementBouton();


            panelAdministrateur.Visible = true;
            panelAdministrateur.BringToFront();
            PanelUtilisateur.SendToBack();
            PanelComptable.Hide();
            LblNom.Text = "" + utilisateur.Nom;
            LblPrenom.Text = "" + utilisateur.Prenom;
            LblProfilUtilisateur.Text = "Profil : " + utilisateur.Role.ToString();

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
        private void BtnRetourLoginAdministrateur_Click(object sender, EventArgs e)
        {
            RetourLogin();
        }

        #endregion

        private void AfficherJustificatif()
        {
            if (ficheFraisDuMois.ListViewForfait.SelectedItems.Count > 0)
            {
                int idForfait = (int)ficheFraisDuMois.ListViewForfait.SelectedItems[0].Tag;
                FraisForfait fraisForfait = ficheEnCours.FraisForfaits.FirstOrDefault(item => item.IdFraisForfait == idForfait);
                if (fraisForfait.justificatif != null)
                {

                    if (affichageJustificatif == null || affichageJustificatif.IsDisposed)
                    {
                        affichageJustificatif = new AfficherJustificatif(fraisForfait);
                        affichageJustificatif.StartPosition = FormStartPosition.Manual;
                        affichageJustificatif.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                        affichageJustificatif.TopLevel = true;
                    }
                    affichageJustificatif.Show();
                }
                else
                {
                    MessageBox.Show("Aucun justificatif n'a été ajouté pour ce frais.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (ficheFraisDuMois.ListViewHorsForfait.SelectedItems.Count > 0)
            {
                int idHorsForfait = (int)ficheFraisDuMois.ListViewHorsForfait.SelectedItems[0].Tag;
                FraisHorsForfait fraisHorsForfait = ficheEnCours.FraisHorsForfaits.FirstOrDefault(item => item.IdFraisHorsForfait == idHorsForfait);
                if (fraisHorsForfait.Justificatif != null)
                {
                    if (affichageJustificatif == null || affichageJustificatif.IsDisposed)
                    {
                        affichageJustificatif = new AfficherJustificatif(fraisHorsForfait);
                        affichageJustificatif.StartPosition = FormStartPosition.Manual;
                        affichageJustificatif.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                        affichageJustificatif.TopLevel = true;
                    }
                    affichageJustificatif.Show();
                }
                else
                {
                    MessageBox.Show("Aucun justificatif n'a été ajouté pour ce frais.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un frais.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RetourLogin()
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

        #region Design 
        private void MiseEnFormeBoutons(Button BoutonSender)
        {
            Control ControlParent = BoutonSender.Parent;

            foreach (Control control in ControlParent.Controls)
            {
                if (control is Button Bouton)
                {
                    Bouton.Font = new Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Bouton.BackColor = Color.FromArgb(45, 45, 61);
                }
            }
        }

        private void MiseEnFormeBoutonActif(Button BoutonSender)
        {
            MiseEnFormeBoutons(BoutonSender);
            BoutonSender.BackColor = Color.FromArgb(255, 183, 77);
            BoutonSender.Font = new Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
        }

        private void Btn_EntrerCurseur(object sender, EventArgs e)
        {
            Button BoutonSender = sender as Button;
            if (BoutonSender != null)
            {
                MiseEnFormeBoutonActif(BoutonSender);
            }
        }

        private void Btn_SortirCurseur(object sender, EventArgs e)
        {
            Button BoutonSender = sender as Button;
            if (BoutonSender != null)
            {
                MiseEnFormeBoutons(BoutonSender);
            }
        }

        private void AssignerEvenementBouton()
        {

            if (utilisateur.Role == UtilisateurRole.Visiteur)
            {
                foreach (Button bouton in PanelUtilisateur.Controls)
                {
                    bouton.MouseEnter += Btn_EntrerCurseur;
                    bouton.MouseLeave += Btn_SortirCurseur;
                }
            }
            else if (utilisateur.Role == UtilisateurRole.Comptable)
            {
                foreach (Button bouton in PanelComptable.Controls)
                {
                    bouton.MouseEnter += Btn_EntrerCurseur;
                    bouton.MouseLeave += Btn_SortirCurseur;
                }
            }
            else 
            {
                foreach (Button bouton in panelAdministrateur.Controls)
                {
                    bouton.MouseEnter += Btn_EntrerCurseur;
                    bouton.MouseLeave += Btn_SortirCurseur;
                }
            }
        }
        private void panelEnTete_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

    }
}

