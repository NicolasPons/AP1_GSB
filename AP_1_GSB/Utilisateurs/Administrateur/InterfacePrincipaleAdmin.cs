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
        CreerUtilisateur creerModifierUtilisateur = null;
        AjouterTypeFraisForfait ajouterModifierTypeFraisForfait = null;

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
                creerModifierUtilisateur = new CreerUtilisateur("ajouter");
                creerModifierUtilisateur.StartPosition = FormStartPosition.Manual;
                creerModifierUtilisateur.UtilisateurEvenement += MettreAJourDataGrids;
                creerModifierUtilisateur.Location = new System.Drawing.Point(this.Location.X - 1100, this.Location.Y + 350);
                creerModifierUtilisateur.TopLevel = true;
            }
            creerModifierUtilisateur.Show();
        }

        public void AjouterTypeFrais()
        {

            if (ajouterModifierTypeFraisForfait == null || ajouterModifierTypeFraisForfait.IsDisposed)
            {
                ajouterModifierTypeFraisForfait = new AjouterTypeFraisForfait("ajouter");
                ajouterModifierTypeFraisForfait.StartPosition = FormStartPosition.Manual;
                ajouterModifierTypeFraisForfait.TypeFraisForfaitEvenement += MettreAJourDataGrids;
                ajouterModifierTypeFraisForfait.Location = new System.Drawing.Point(this.Location.X - 1000, this.Location.Y + 350);
                ajouterModifierTypeFraisForfait.TopLevel = true;
            }
            ajouterModifierTypeFraisForfait.Show();

        }
    }
}
