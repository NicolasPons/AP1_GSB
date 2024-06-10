using AP_1_GSB.Data.Models;
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
    public partial class FicheFraisDuMois : Form
    {
        readonly Utilisateur utilisateur;
        readonly FicheFrais ficheEnCours;
        public event Action ListesVide;

        public FicheFraisDuMois(Utilisateur utilisateur, FicheFrais ficheEnCours, DateTime dtFin)
        {
            this.utilisateur = utilisateur;
            this.ficheEnCours = ficheEnCours;
            InitializeComponent();
            DateFicheFrais.Text = "Fiche de frais du " + ficheEnCours.Date.ToString("dd MMMM yyyy") + " au " + dtFin.ToString("dd MMMM yyyy");
        }   

        public void MettreAJourListView()
        {
            listViewHorsForfait.Items.Clear();
            ListViewForfait.Items.Clear();
            //foreach (FraisHorsForfait fraisHorsForfait in ficheEnCours.FraisHorsForfaits)
            //{
            //    ListViewItem item = new ListViewItem(fraisHorsForfait.Description);
            //    item.SubItems.Add(fraisHorsForfait.Montant.ToString());
            //    item.SubItems.Add(fraisHorsForfait.Date.ToString("dd/MM/yyyy"));
            //    item.SubItems.Add(fraisHorsForfait.Etat.ToString());
            //    //item.SubItems.Add(fraisHorsForfait.Justificatif)
            //    item.Tag = fraisHorsForfait.IdFraisHorsForfait;
            //    listViewHorsForfait.Items.Add(item);
            //}

            foreach (var fraisForfait in ficheEnCours.FraisForfaits)
            {
                var item = new ListViewItem(new[]
                {
                    fraisForfait.IdFraisForfait.ToString(),
                    fraisForfait.TypeForfait.Nom,
                    fraisForfait.Quantite.ToString(),
                    fraisForfait.Date.ToString("dd MMMM yyyy"),
                    fraisForfait.Etat.ToString(),
                    //fraisForfait.justificatif.FichierBlob. 
                });
                ListViewForfait.Items.Add(item);
            }

            foreach (var fraisHorsForfait in ficheEnCours.FraisHorsForfaits)
            {
                var item = new ListViewItem(new[]
                {
                    fraisHorsForfait.IdFraisHorsForfait.ToString(),
                    fraisHorsForfait.Description,
                    fraisHorsForfait.Montant.ToString(),
                    fraisHorsForfait.Date.ToString("dd MMMM yyyy"),
                    fraisHorsForfait.Etat.ToString(),
                    //fraisHorsForfait.Justificatif.ToString(),
                });
                listViewHorsForfait.Items.Add(item);
            }
        }

        public void VerifierListesVides()
        {
            if (ListViewForfait.Items.Count == 0 && listViewHorsForfait.Items.Count == 0)
            {
                ListesVide?.Invoke();
            }
        }

        public void SupprimerSelectionLigne()
        {
            if (ListViewForfait.SelectedItems.Count > 0)
            {
                SupprimerFraisForfait();
            }
            else if (listViewHorsForfait.SelectedItems.Count > 0)
            {
                SupprimerFraisHorsForfait();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un frais à supprimer");
            }
        }

        public void SupprimerFraisForfait()
        {

            if (ListViewForfait.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un frais forfait à supprimer");
                return;
            }

            int idFraisASupprimer = int.Parse(ListViewForfait.SelectedItems[0].SubItems[0].Text);
            ListViewForfait.Items.Remove(ListViewForfait.SelectedItems[0]);
            FraisForfait FraisASupprimer = ficheEnCours.FraisForfaits.Find(f => f.IdFraisForfait == idFraisASupprimer);

            if (FraisASupprimer == null)
            {
                MessageBox.Show("Erreur : frais forfait non trouvé");
                return;
            }

            bool ValeurRetour = Services.FraisForfaitService.SupprimerFraisForfait(FraisASupprimer);
            if (ValeurRetour)
            {
                MessageBox.Show("Note de frais forfait supprimée");
                ficheEnCours.FraisForfaits.Remove(FraisASupprimer);
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression de la note de frais");
            }
            
            VerifierListesVides();
        }

        public void SupprimerFraisHorsForfait()
        {
            int idFraisASupprimer = 0;
            FraisHorsForfait FraisASupprimer = null;
            

            if (listViewHorsForfait.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un frais hors forfait à supprimer");
                return;
            }
            else
            {
                idFraisASupprimer = int.Parse(listViewHorsForfait.SelectedItems[0].SubItems[0].Text);
                listViewHorsForfait.Items.Remove(listViewHorsForfait.SelectedItems[0]);
                FraisASupprimer = ficheEnCours.FraisHorsForfaits.Find(f => f.IdFraisHorsForfait == idFraisASupprimer);
            }
            bool ValeurRetour = Services.FraisHorsForfaitService.SupprimerFraisHorsForfait(FraisASupprimer);
            if (ValeurRetour)
            {
                MessageBox.Show("Note de frais hors forfait supprimée");
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression de la note de frais");
            }
            ficheEnCours.FraisHorsForfaits.Remove(FraisASupprimer);
            VerifierListesVides();
        }

        private void FicheFraisDuMois_Load(object sender, EventArgs e)
        {
            MettreAJourListView();
        }
    }
}

            ////PERMET D'AFFICHER UNE IMAGE DU FICHIER BLOB
            //byte[] blob = utilisateur.FichesFrais[0].FraisForfaits[1].justificatif.FichierBlob;
            //using (MemoryStream ms = new MemoryStream(blob))
            //{
            //    Image image = Image.FromStream(ms);
            //    // Vous pouvez maintenant utiliser l'objet image.
            //    // Par exemple, pour l'afficher dans un PictureBox :
            //    pictureBox1.Image = image;
            //    pictureBox1.Size = image.Size;
            //}