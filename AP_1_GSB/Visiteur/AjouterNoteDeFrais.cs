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
    public partial class AjouterNoteDeFrais : Form
    {
        byte[] FichierBinaire;
        string description;
        int type;
        int quantite;
        int montant;
        DateTime dateFrais;
        FicheFrais FicheEnCours;
        Utilisateur utilisateur;
        public event Action NoteDeFraisAjoutee;
        public AjouterNoteDeFrais(Utilisateur utilisateur, FicheFrais ficheEnCours, DateTime dtFin)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            this.FicheEnCours = ficheEnCours;
            DateFrais.MinDate = ficheEnCours.Date;
            DateFrais.MaxDate = dtFin;
            SelectionTypeForfait.Visible= false;
            DescriptionHorsForfait.Visible = false;
            DateFrais.Visible = false;
            QuantiteMontant.Visible = false;
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectionFrais_ChangementElement(object sender, EventArgs e)
        {
            if (SelectionFrais.SelectedIndex == 0)
            {
                SelectionTypeForfait.Visible = true;
                SelectionTypeForfait.SelectedIndex = 0;
                DescriptionHorsForfait.Visible = false;
                DateFrais.Visible= true;
                QuantiteMontant.Visible = true;
            }
            else
            {
                SelectionTypeForfait.Visible = false;
                DescriptionHorsForfait.Visible = true;
                DateFrais.Visible = true;
                QuantiteMontant.Visible = true;
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

            if (SelectionFrais.SelectedIndex == 0)
            {
                int IdFiche = FicheEnCours.IdFicheFrais;
                type = SelectionTypeForfait.SelectedIndex + 1;
                dateFrais = DateFrais.Value;
                quantite = int.Parse(QuantiteMontant.Text);
                bool valeurRetour = FraisForfaitService.AjouterFraisForfait(IdFiche, type, dateFrais, quantite, FichierBinaire);

                if (valeurRetour)
                {
                    MessageBox.Show("Frais créée avec succés.");
                    utilisateur = FicheFraisService.RecupererNotesForfait(utilisateur, FicheEnCours);
                    NoteDeFraisAjoutee?.Invoke();   
                }
                else 
                {
                    MessageBox.Show("Erreur lors de la création du frais.");
                }
            }
            else 
            {
                //MODIFIER QUANTITE DOIT ETRE DE TYPE FLOAT OR SOMETHING, PEUT ETRE UN CHIFFRE A VIRGULE ET OUAIS 
                int IdFiche = FicheEnCours.IdFicheFrais;
                description = DescriptionHorsForfait.Text;
                dateFrais = DateFrais.Value;
                montant = int.Parse(QuantiteMontant.Text);
                bool valeurRetour = FraisHorsForfaitService.AjouterFraisHorsForfait(IdFiche, description, dateFrais, montant, FichierBinaire);

                if (valeurRetour)
                {
                    MessageBox.Show("Frais créée avec succés.");
                    utilisateur = FicheFraisService.RecupererNotesHorsForfait(utilisateur, FicheEnCours);   
                    NoteDeFraisAjoutee?.Invoke();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la création du frais.");
                }
            }
            this.Close();
        }
    }
}
