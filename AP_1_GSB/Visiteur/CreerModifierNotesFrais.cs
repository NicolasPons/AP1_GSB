using AP_1_GSB.Data.Models;
using AP_1_GSB.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Visiteur
{
    public partial class CreerModifierNotesFrais : Form
    {
        FicheFrais ficheEnCours;
        Utilisateur utilisateur;
        FraisForfait fraisForfait;
        FraisHorsForfait fraisHorsForfait;
        DateTime dateFrais;
        byte[] FichierBinaire;
        string description;
        string versionPopUp;
        int type;
        int quantite;
        int montant;
        public event Action NoteDeFraisAjoutee;

        public CreerModifierNotesFrais(Utilisateur utilisateur, FicheFrais ficheEnCours, DateTime dtFin, string versionPopUp)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            this.ficheEnCours = ficheEnCours;
            this.versionPopUp = versionPopUp;
            InitialiserForm(dtFin);
            ChargerCombobox();

            LblDescription.Visible = false;
            LblMontant.Visible = false;
            LblQuantite.Visible = false;
            LblTypeForfait.Visible = false;
            LblCategorieForfait.Visible = true;
            label3.Visible = false;
            SelectionTypeForfait.Visible = false;
            DescriptionHorsForfait.Visible = false;
            DateFrais.Visible = false;
            QuantiteMontant.Visible = false;
            BtnJustificatif.Visible = false;

        }

        public CreerModifierNotesFrais(Utilisateur utilisateur, FicheFrais ficheEnCours, DateTime dtFin, string versionPopUp, FraisForfait fraisForfait)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            this.ficheEnCours = ficheEnCours;
            this.fraisForfait = fraisForfait;
            this.versionPopUp = versionPopUp;
            InitialiserForm(dtFin);
            ChargerCombobox();

            SelectionTypeForfait.SelectedIndex = fraisForfait.TypeForfait.IdFraisForfait - 1;
            DateFrais.Value = fraisForfait.Date;
            QuantiteMontant.Value = fraisForfait.Quantite;

            SelectionTypeForfait.Visible = true;
            DateFrais.Visible = true;
            QuantiteMontant.Visible = true;
            BtnJustificatif.Visible = true;
            DescriptionHorsForfait.Visible = false;
            SelectionFrais.Visible = false;
            LblCategorieForfait.Visible = false;
            LblQuantite.Visible = true;
            LblTypeForfait.Visible = true;
            LblMontant.Visible = false;
            LblDescription.Visible = false;
            
        }
        public CreerModifierNotesFrais(Utilisateur utilisateur, FicheFrais ficheEnCours, DateTime dtFin, string versionPopUp, FraisHorsForfait fraisHorsForfait)
        {
            InitializeComponent();
            

            this.utilisateur = utilisateur;
            this.ficheEnCours = ficheEnCours;
            this.fraisHorsForfait = fraisHorsForfait;
            this.versionPopUp = versionPopUp;
            InitialiserForm(dtFin);
            ChargerCombobox();

            DateFrais.Value = fraisHorsForfait.Date;
            DescriptionHorsForfait.Text = fraisHorsForfait.Description;
            QuantiteMontant.Value = (decimal)fraisHorsForfait.Montant;

            SelectionTypeForfait.Visible = false;
            SelectionFrais.Visible = false;
            DescriptionHorsForfait.Visible = true;
            DateFrais.Visible = true;
            QuantiteMontant.Visible = true;
            BtnJustificatif.Visible = true;
            SelectionTypeForfait.Visible = false;
            LblQuantite.Visible = false; 
            LblTypeForfait.Visible = false;
            LblCategorieForfait.Visible = false;
            LblDescription.Visible = true;
            LblMontant.Visible = true;
        }

        private void InitialiserForm(DateTime dtFin)
        {
            DateFrais.MinDate = ficheEnCours.Date;
            DateFrais.MaxDate = dtFin;

            if (versionPopUp == "creer")
            {
                label1.Text = "Création d'une note de frais";
            }
            else
                label1.Text = "Modification d'une note de frais";
        }

        private void ChargerCombobox()
        {
            List<TypeFraisForfait> typeFraisForfaits = TypeFraisForfaitService.RecupererTypeFraisForfait();
            SelectionTypeForfait.DataSource = typeFraisForfaits;
            SelectionTypeForfait.DisplayMember = "Nom";
            SelectionTypeForfait.ValueMember = "IdFraisForfait";
        }

        private void SelectionFrais_ChangementElement(object sender, EventArgs e)
        {
            if (SelectionFrais.SelectedIndex == 0)
            {
                LblTypeForfait.Visible = true;
                LblQuantite.Visible = true;
                SelectionTypeForfait.Visible = true;
                SelectionTypeForfait.SelectedIndex = 0;
                DateFrais.Visible = true;
                QuantiteMontant.Visible = true;
                LblCategorieForfait.Visible = true;
                label3.Visible = true;
                BtnJustificatif.Visible = true;
                DescriptionHorsForfait.Visible = false;
                LblDescription.Visible = false;
                LblMontant.Visible=false;
            }
            else
            {
                LblDescription.Visible = true;
                LblMontant.Visible = true;
                DescriptionHorsForfait.Visible = true;
                DateFrais.Visible = true;
                QuantiteMontant.Visible = true;
                LblCategorieForfait.Visible = true;
                label3.Visible = true;
                BtnJustificatif.Visible = true;
                SelectionTypeForfait.Visible = false;
                LblTypeForfait.Visible = false;
                LblQuantite.Visible= false;
            }
        }

        private void AjouterJustificatif_Clique(object sender, EventArgs e)
        {
            OpenFileDialog ofdJustificatif = new OpenFileDialog();
            ofdJustificatif.Filter = "Fichiers PDF|*.pdf|Fichiers JPEG|*.jpg;*.jpeg|PNG Image|*.png";
            ofdJustificatif.Title = "Sélectionnez un justificatif";
            ofdJustificatif.Multiselect = false;

            if (ofdJustificatif.ShowDialog() == DialogResult.OK)
            {
                string CheminFichier = ofdJustificatif.FileName;
                FileInfo FichierInfo = new FileInfo(CheminFichier);

                if (FichierInfo.Length > 16L * 1024 * 1024)
                {
                    MessageBox.Show("Le fichier est trop grand. Veuillez sélectionner un fichier de moins de 16 Go.");
                    return;
                }
                FichierBinaire = File.ReadAllBytes(CheminFichier);
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (versionPopUp == "creer")
            {
                if (SelectionFrais.SelectedIndex == 0)
                {
                    int IdFiche = ficheEnCours.IdFicheFrais;
                    type = SelectionTypeForfait.SelectedIndex + 1;
                    dateFrais = DateFrais.Value;
                    quantite = int.Parse(QuantiteMontant.Text);

                    if (FraisForfaitService.AjouterFraisForfait(IdFiche, type, dateFrais, quantite, FichierBinaire))
                    {
                        MessageBox.Show("Frais créé avec succés.");
                        utilisateur = FicheFraisService.RecupererNotesForfait(utilisateur, ficheEnCours);
                        NoteDeFraisAjoutee?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la création du frais.");
                    }
                }
                else
                {
                    int IdFiche = ficheEnCours.IdFicheFrais;
                    description = DescriptionHorsForfait.Text;
                    dateFrais = DateFrais.Value;
                    montant = int.Parse(QuantiteMontant.Text);

                    if (FraisHorsForfaitService.AjouterFraisHorsForfait(IdFiche, description, dateFrais, montant, FichierBinaire))
                    {
                        MessageBox.Show("Frais créé avec succés.");
                        utilisateur = FicheFraisService.RecupererNotesHorsForfait(utilisateur, ficheEnCours);
                        NoteDeFraisAjoutee?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la création du frais.");
                    }
                }
            }

            else if (versionPopUp == "modifierForfait")
            {
                int IdFiche = fraisForfait.IdFraisForfait;
                type = SelectionTypeForfait.SelectedIndex + 1;
                dateFrais = DateFrais.Value;
                quantite = int.Parse(QuantiteMontant.Text);

                if (FraisForfaitService.ModifierFraisForfait(IdFiche, type, dateFrais, quantite, FichierBinaire))
                {
                    MessageBox.Show("Frais modifié avec succés.");
                    utilisateur = FicheFraisService.RecupererNotesForfait(utilisateur, ficheEnCours);
                    NoteDeFraisAjoutee?.Invoke();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du frais.");
                }
            }

            else
            {
                int IdFiche = fraisHorsForfait.IdFraisHorsForfait;
                description = DescriptionHorsForfait.Text;
                dateFrais = DateFrais.Value;
                montant = int.Parse(QuantiteMontant.Text);

                if (FraisHorsForfaitService.ModifierFraisHorsForfait(IdFiche, description, dateFrais, montant, FichierBinaire))
                {
                    MessageBox.Show("Frais modifié avec succés.");
                    utilisateur = FicheFraisService.RecupererNotesHorsForfait(utilisateur, ficheEnCours);
                    NoteDeFraisAjoutee?.Invoke();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du frais.");
                }
            }
            this.Close();
        }
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
