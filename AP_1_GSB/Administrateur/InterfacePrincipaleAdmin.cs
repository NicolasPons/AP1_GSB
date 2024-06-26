using AP_1_GSB.Data.Models;
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

            List<TypeFraisForfait> TypesFraisForfait = new List<TypeFraisForfait>();
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            TypesFraisForfait = Services.TypeFraisForfaitService.RecupererTypeFraisForfait();
            utilisateurs = Services.UtilisateurService.RecupererUtilisateurs();

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

        private void DataGridTypeFrais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
