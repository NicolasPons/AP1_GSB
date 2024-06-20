using AP_1_GSB.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Administrateur
{
    public partial class AjouterModifierTypeFraisForfait : Form
    {
        public event Action TypeFraisForfaitEvenement;
        public AjouterModifierTypeFraisForfait(string version)
        {
            InitializeComponent();
            typeFraisForfaitBindingSource.DataSource = new TypeFraisForfait();
        }
        public AjouterModifierTypeFraisForfait(int id, string version)
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            typeFraisForfaitBindingSource.EndEdit(); 

            TypeFraisForfait typeFraisForfait = typeFraisForfaitBindingSource.Current as TypeFraisForfait;
            if (typeFraisForfait != null)
            {
                ValidationContext context = new ValidationContext(typeFraisForfait, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(typeFraisForfait, context, errors, true))
                {
                    foreach (ValidationResult validationResult in errors)
                    {
                        MessageBox.Show(validationResult.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    bool valeurRetour = Services.TypeFraisForfaitService.CreerTypeFraisForfait(typeFraisForfait);
                    if (valeurRetour)
                        MessageBox.Show("Type de frais forfait créé avec succés");
                    TypeFraisForfaitEvenement?.Invoke();
                    this.Close();
                }
            }
        }
    }
}
