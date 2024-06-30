using AP_1_GSB.Data.Models;
using Google.Protobuf.Compiler;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Administrateur
{
    public partial class InterfacePrincipaleAdmin : Form
    {
        public DataGridView dataGridUtilisateurs => this.DataGridUtilisateurs;
        public DataGridView dataGridTypeFrais => this.DataGridTypeFrais;
        CreerModifierUtilisateur creerModifierUtilisateur = null;
        AjouterModifierTypeFraisForfait ajouterModifierTypeFraisForfait = null;

        public InterfacePrincipaleAdmin()
        {
            InitializeComponent();
            MettreAJourDataGrids();
        }

        public void MettreAJourDataGrids()
        {
            DataGridUtilisateurs.Rows.Clear();
            DataGridTypeFrais.Rows.Clear();
            DataGridUtilisateurs.Columns["IdUtilisateur"].Visible = false;
            DataGridTypeFrais.Columns["IdTypeFrais"].Visible = false;

            List<TypeFraisForfait> TypesFraisForfait = Services.TypeFraisForfaitService.RecupererTypeFraisForfait();
            List<Utilisateur> utilisateurs = Services.UtilisateurService.RecupererUtilisateurs();

            foreach (TypeFraisForfait type in TypesFraisForfait)
            {
                string[] row = new string[]
                {
                    type.Nom,
                    type.Montant.ToString(),
                    type.IdFraisForfait.ToString(),
                };
                DataGridTypeFrais.Rows.Add(row);

            }

            foreach (Utilisateur utilisateur in utilisateurs)
            {
                string[] row = new string[]
                {
                     utilisateur.Nom,
                     utilisateur.Prenom,
                     utilisateur.Email,
                     utilisateur.Role.ToString(),
                     utilisateur.IdUtilisateur.ToString(),
                };
                DataGridUtilisateurs.Rows.Add(row);
            }
        }
        //Méthode pour ajouter un utilisateur
        public void AjouterUtilisateur()
        {
            if (creerModifierUtilisateur == null || creerModifierUtilisateur.IsDisposed)
            {
                creerModifierUtilisateur = new CreerModifierUtilisateur("ajouter");
                creerModifierUtilisateur.StartPosition = FormStartPosition.Manual;
                creerModifierUtilisateur.UtilisateurEvenement += MettreAJourDataGrids;
                creerModifierUtilisateur.Location = new System.Drawing.Point(this.Location.X - 1100, this.Location.Y + 350);
                creerModifierUtilisateur.TopLevel = true;
            }
            creerModifierUtilisateur.Show();
        }
        //Méthode pour modifier un utilisateur. Récupère l'ID sélectionné
        public void ModifierUtilisateur()
        {
           
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            utilisateurs = Services.UtilisateurService.RecupererUtilisateurs();
            int idUtilisateur = int.Parse(DataGridUtilisateurs.SelectedRows[0].Cells[4].Value.ToString());
            Utilisateur utilisateur = utilisateurs.FirstOrDefault(item => item.IdUtilisateur == idUtilisateur);

            if (creerModifierUtilisateur == null || creerModifierUtilisateur.IsDisposed)
            {
                creerModifierUtilisateur = new CreerModifierUtilisateur("modifier", utilisateur);
                creerModifierUtilisateur.StartPosition = FormStartPosition.Manual;
                creerModifierUtilisateur.UtilisateurEvenement += MettreAJourDataGrids;
                creerModifierUtilisateur.Location = new System.Drawing.Point(this.Location.X - 1100, this.Location.Y + 350);
                creerModifierUtilisateur.TopLevel = true;
            }
            creerModifierUtilisateur.Show();
        }
        //Méthode pour supprimer un utilisateur. Récupère l'ID sélectionné
        public void SupprimerUtilisateur()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            utilisateurs = Services.UtilisateurService.RecupererUtilisateurs();
            int idUtilisateur = int.Parse(DataGridUtilisateurs.SelectedRows[0].Cells[4].Value.ToString());
            Utilisateur utilisateur = utilisateurs.FirstOrDefault(item => item.IdUtilisateur == idUtilisateur);

            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (Services.UtilisateurService.SupprimerUtilisateur(utilisateur))
                {
                    MessageBox.Show("Utilisateur supprimé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MettreAJourDataGrids();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de l'utilisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Méthode pour modifier le type de frais. Récupère l'ID sélectionné
        public void ModifierTypeFrais()
        {
            List<TypeFraisForfait> TypesFraisForfait = new List<TypeFraisForfait>();
            TypesFraisForfait = Services.TypeFraisForfaitService.RecupererTypeFraisForfait();
            string test = DataGridTypeFrais.SelectedRows[0].Cells[0].Value.ToString();
            int idTypFrais = int.Parse(DataGridTypeFrais.SelectedRows[0].Cells[2].Value.ToString());
            TypeFraisForfait typeFraisForfait = TypesFraisForfait.FirstOrDefault(frais => frais.IdFraisForfait == idTypFrais);

            if (ajouterModifierTypeFraisForfait == null || ajouterModifierTypeFraisForfait.IsDisposed)
            {
                ajouterModifierTypeFraisForfait = new AjouterModifierTypeFraisForfait("modifier", typeFraisForfait);
                ajouterModifierTypeFraisForfait.StartPosition = FormStartPosition.Manual;
                ajouterModifierTypeFraisForfait.TypeFraisForfaitEvenement += MettreAJourDataGrids;
                ajouterModifierTypeFraisForfait.Location = new System.Drawing.Point(this.Location.X - 1000, this.Location.Y + 350);
                ajouterModifierTypeFraisForfait.TopLevel = true;
            }
            ajouterModifierTypeFraisForfait.Show();
        }

        public void AjouterTypeFrais()
        {

            if (ajouterModifierTypeFraisForfait == null || ajouterModifierTypeFraisForfait.IsDisposed)
            {
                ajouterModifierTypeFraisForfait = new AjouterModifierTypeFraisForfait("ajouter");
                ajouterModifierTypeFraisForfait.StartPosition = FormStartPosition.Manual;
                ajouterModifierTypeFraisForfait.TypeFraisForfaitEvenement += MettreAJourDataGrids;
                ajouterModifierTypeFraisForfait.Location = new System.Drawing.Point(this.Location.X - 1000, this.Location.Y + 350);
                ajouterModifierTypeFraisForfait.TopLevel = true;
            }
            ajouterModifierTypeFraisForfait.Show();

        }
    }
}
