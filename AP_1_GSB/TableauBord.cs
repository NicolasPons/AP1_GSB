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
        readonly Login loginForm;
        Utilisateur utilisateur;
        FicheFraisDuMois ficheFraisDuMois;
        FicheFrais ficheEnCours;
        DateTime DateDebut;
        DateTime dateFin;
        InterfacePrincipaleComptable affichageComptable;
        AffichageHistorique affichageHistorique = null;
        CreerModifierNoteFrais creerModifierNoteFrais = null;
        InterfacePrincipaleAdmin interfaceAdmin = null;
        AfficherJustificatif affichageJustificatif = null;

        public TableauBord(Utilisateur utilisateur, Login loginForm)
        {
            this.utilisateur = utilisateur;
            this.loginForm = loginForm;
            InitializeComponent();

            //Affiche l'interface en fonction du profil 
            //Test Commit 
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

        #region General

        //Ouvre le formulaire pour afficher le justificatif en fonction du type de frais
        private void AfficherJustificatif()
        {
            if (ficheFraisDuMois.dataGridViewForfait.SelectedRows.Count > 0)
            {
                int idForfait = int.Parse(ficheFraisDuMois.dataGridViewForfait.SelectedRows[0].Cells[6].Value.ToString());
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

            else if (ficheFraisDuMois.dataGridViewHorsForfait.SelectedRows.Count > 0)
            {
                int idHorsForfait = int.Parse(ficheFraisDuMois.dataGridViewHorsForfait.SelectedRows[0].Cells[5].Value.ToString());
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
        #endregion


        #region Visiteur

        //Permet de définir la période de la fiche en fonction de la date actuelle
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

            //Passe l'état des fiche en Attente pour les fiches dont la période est finie 
            //et sur lesquelles le comptable n'a pas encore effectué d'action 
            utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);
            foreach (FicheFrais fiche in utilisateur.FichesFrais)
            {
                DateTime dateFin = new DateTime(fiche.Date.Year, fiche.Date.AddMonths(1).Month, 10);
                if (dateFin < DateTime.Now && fiche.Etat == EtatFicheFrais.EnCours)
                {
                    fiche.Etat = EtatFicheFrais.Attente;
                    FicheFraisService.ChangerEtatFiche(fiche, 1);
                }
            }

            //Récupère la fiche du mois en cours
            ficheEnCours = null;
            RecupererDatesFiche();
            ficheEnCours = Services.FicheFraisService.RecupererDerniereFiche(utilisateur, DateDebut, dateFin);
            utilisateur = Services.FicheFraisService.RecupererNotesForfait(utilisateur, ficheEnCours);
            utilisateur = Services.FicheFraisService.RecupererNotesHorsForfait(utilisateur, ficheEnCours);

            //Ouvre l'interface utilisateur 
            string version = "utilisateur";
            ficheFraisDuMois = new FicheFraisDuMois(utilisateur, ficheEnCours, dateFin, version);
            ficheFraisDuMois.DataGridsVides += () => BtnSupprimerNoteVisiteur.Enabled = false;
            ficheFraisDuMois.DataGridsVides += () => BtnModifierNoteVisiteur.Enabled = false;
            ficheFraisDuMois.DataGridsVides += () => BtnAfficherJustificatifVisiteur.Enabled = false;
            ficheFraisDuMois.VerifierDataGridsVides();
            ficheFraisDuMois.TopLevel = false;
            PanelAffichage.Controls.Add(ficheFraisDuMois);
            ficheFraisDuMois.FormBorderStyle = FormBorderStyle.None;
            ficheFraisDuMois.Dock = DockStyle.Fill;
            ficheFraisDuMois.Show();
        }

        //Action au clique des différents boutons de l'interface utilisateur
        public void BtnAjouterNoteFrais_Click(object sender, EventArgs e)
        {
            AfficherPopUpCreationModification("creer");
        }
        public void BtnSupprimerNote_Click(object sender, EventArgs e)
        {
            ficheFraisDuMois.SupprimerSelectionLigne();

        }

        private void BtnModifierNoteVisiteur_Click(object sender, EventArgs e)
        {
            if (ficheFraisDuMois.dataGridViewForfait.SelectedRows.Count > 0)
            {
                int idForfait = int.Parse(ficheFraisDuMois.dataGridViewForfait.SelectedRows[0].Cells[6].Value.ToString());
                FraisForfait fraisForfait = ficheEnCours.FraisForfaits.FirstOrDefault(item => item.IdFraisForfait == idForfait);
                AfficherPopUpCreationModification("modifierForfait", fraisForfait);
            }

            else if (ficheFraisDuMois.dataGridViewHorsForfait.SelectedRows.Count > 0)
            {
                
                int idHorsForfait = int.Parse(ficheFraisDuMois.dataGridViewHorsForfait.SelectedRows[0].Cells[5].Value.ToString());
                FraisHorsForfait fraisHorsForfait = ficheEnCours.FraisHorsForfaits.FirstOrDefault(item => item.IdFraisHorsForfait == idHorsForfait);

                AfficherPopUpCreationModification("modifierHorsForfait", fraisHorsForfait);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un frais à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Méthode surchargée pour prendre en compte les différentes versions de la pop up : Création ou modification 
        // et les différents types de frais à modifier : forfait ou hors forfait
        private void AfficherPopUpCreationModification(string versionPopUp)
        {
            if (creerModifierNoteFrais == null || creerModifierNoteFrais.IsDisposed)
            {
                creerModifierNoteFrais = new CreerModifierNoteFrais(utilisateur, ficheEnCours, dateFin, versionPopUp);
                creerModifierNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourDataGrids;
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
                creerModifierNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourDataGrids;
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
                creerModifierNoteFrais.NoteDeFraisAjoutee += ficheFraisDuMois.MettreAJourDataGrids;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnSupprimerNoteVisiteur.Enabled = true;
                creerModifierNoteFrais.NoteDeFraisAjoutee += () => BtnModifierNoteVisiteur.Enabled = true;
                creerModifierNoteFrais.StartPosition = FormStartPosition.Manual;
                creerModifierNoteFrais.Location = new System.Drawing.Point(this.Location.X + 400, this.Location.Y + 250);
                creerModifierNoteFrais.TopLevel = true;
            }
            creerModifierNoteFrais.Show();
        }

        private void BtnAfficherJustificatifVisiteur_Click(object sender, EventArgs e)
        {
            AfficherJustificatif();
        }

        //Affichage de l'historique du visiteur
        private void BtnHistorique_Click(object sender, EventArgs e)
        {
            GriserBouton(false, false, false, false);

            if (affichageHistorique == null)
            {
                affichageHistorique = new AffichageHistorique(utilisateur, ficheEnCours);
                affichageHistorique.DegriserBouton += () => GriserBouton(true, true, true, true);
                affichageHistorique.StartPosition = FormStartPosition.Manual;
                affichageHistorique.TopLevel = false;
                PanelAffichage.Controls.Add(affichageHistorique);
                affichageHistorique.FormBorderStyle = FormBorderStyle.None;
                affichageHistorique.Dock = DockStyle.Fill;
            }
            affichageHistorique.BringToFront();
            affichageHistorique.Show();
        }

        //Méthode pour griser et dégriser les boutons en fonction du besoin
        private void GriserBouton(bool btnAJout, bool btnSupprimer, bool btnModif, bool btnJustif)
        {
            BtnAjouterNoteFraisVisiteur.Enabled = btnAJout;
            BtnSupprimerNoteVisiteur.Enabled = btnSupprimer;
            BtnModifierNoteVisiteur.Enabled = btnModif;
            BtnAfficherJustificatifVisiteur.Enabled = btnJustif;
        }

        private void BtnRetourLoginVisiteur_Click(object sender, EventArgs e)
        {
            RetourLogin();
        }
        #endregion


        #region Comptable 
        
        //Affichage et mise en forme de l'interface comptable 
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

            BtnRefusFrais.Enabled = false;
            btnAccepterFrais.Enabled = false;
            BtnAfficherJustificatifComptable.Enabled = false;

            affichageComptable = new InterfacePrincipaleComptable();
            affichageComptable.TopLevel = false;
            PanelAffichage.Controls.Add(affichageComptable);
            affichageComptable.FormBorderStyle = FormBorderStyle.None;
            affichageComptable.Dock = DockStyle.Fill;
            affichageComptable.Show();
        }
        //Action au clique des différents boutons de l'interface comptable
        private void BtnAfficherFicheSelectionnee_Click(object sender, EventArgs e)
        {
           (ficheEnCours, utilisateur) = affichageComptable.SelectionnerFiche();
            DateTime dtFin = FicheFraisService.DateFin(ficheEnCours);
           
            if (ficheEnCours != null)
            {

                string version = "comptable";
                BtnRefusFrais.Enabled = true;
                btnAccepterFrais.Enabled = true;
                BtnAfficherJustificatifComptable.Enabled = true;
                BtnAfficherFicheSelectionnee.Enabled = false;
                ficheFraisDuMois = new FicheFraisDuMois(utilisateur, ficheEnCours, dtFin, version);
                ficheFraisDuMois.DataGridsVides += () => BtnRefusFrais.Enabled = false;
                ficheFraisDuMois.DataGridsVides += () => btnAccepterFrais.Enabled = false;
                ficheFraisDuMois.DataGridsVides += () => BtnAfficherJustificatifComptable.Enabled = false;
                ficheFraisDuMois.VerifierDataGridsVides();
                ficheFraisDuMois.GriserBouton += () => BtnRefusFrais.Enabled = false;
                ficheFraisDuMois.GriserBouton += () => btnAccepterFrais.Enabled = false;
                ficheFraisDuMois.GriserBouton += () => BtnAfficherJustificatifComptable.Enabled = false;
                ficheFraisDuMois.GriserBouton += () => BtnAfficherFicheSelectionnee.Enabled = true;
                ficheFraisDuMois.RetourChoixVisiteur += affichageComptable.MettreAJourDataGridFiche;
                ficheFraisDuMois.TopLevel = false;
                PanelAffichage.Controls.Add(ficheFraisDuMois);
                ficheFraisDuMois.FormBorderStyle = FormBorderStyle.None;
                ficheFraisDuMois.Dock = DockStyle.Fill;
                ficheFraisDuMois.BringToFront();
                ficheFraisDuMois.Show();
            }
        }
        private void BtnRefusFrais_Click(object sender, EventArgs e)
        {
            ficheFraisDuMois.RefuserFrais();
        }
        private void BtnAccepterFrais_Click(object sender, EventArgs e)
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

        //Affichage et mise en forme de l'interface administrateur
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

        //Action au clique des différents boutons de l'interface administrateur
        private void BtnAjouterTypeFrais_Click(object sender, EventArgs e)
        {
            interfaceAdmin.AjouterTypeFrais();
        }
        private void BtnModifierTypeFrais_Click(object sender, EventArgs e)
        {
            if (interfaceAdmin.dataGridTypeFrais.SelectedRows.Count > 0)
            {
                 interfaceAdmin.ModifierTypeFrais();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un type de frais à modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void BtnAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            interfaceAdmin.AjouterUtilisateur();
        }
        private void BtnModifierUtilisateur_Click(object sender, EventArgs e)
        {
            if (interfaceAdmin.dataGridUtilisateurs.SelectedRows.Count > 0)
            {
                interfaceAdmin.ModifierUtilisateur();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void BtnSupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            if (interfaceAdmin.dataGridUtilisateurs.SelectedRows.Count > 0)
            {
                interfaceAdmin.SupprimerUtilisateur();
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


        #region Design 
        // Met en forme les boutons à leur état initial
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

        //Met en forme le bouton actif lors du passage du curseur
        private void MiseEnFormeBoutonActif(Button BoutonSender)
        {
            MiseEnFormeBoutons(BoutonSender);
            BoutonSender.BackColor = Color.FromArgb(255, 183, 77);
            BoutonSender.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
        }

        private void Btn_EntrerCurseur(object sender, EventArgs e)
        {
            if (sender is Button BoutonSender)
            {
                MiseEnFormeBoutonActif(BoutonSender);
            }
        }

        private void Btn_SortirCurseur(object sender, EventArgs e)
        {
            if (sender is Button BoutonSender)
            {
                MiseEnFormeBoutonActif(BoutonSender);
            }
        }

        //Assigne les méthodes précédentes aux évenement entrer et sortie du curseur sur l'élément pour chacun des boutons du panel
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

        //Ce code permet de déplacer la fenêtre de l'application en cliquant et en glissant le panneau d'en-tête.
        //Appels direct à l'API windows pour gérer les actions de la souris et déplacer la fenêtre
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private void PanelEnTete_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

    }
}

