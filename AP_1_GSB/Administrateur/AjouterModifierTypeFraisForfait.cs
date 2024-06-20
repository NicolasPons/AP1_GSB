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
        TypeFraisForfait typeFraisForfaitAModifier;
        public event Action TypeFraisForfaitEvenement;
        string version;
        public AjouterModifierTypeFraisForfait(string version)
        {
            InitializeComponent();
            lblModifierType.Visible = false;
            this.version = version;
            typeFraisForfaitBindingSource.DataSource = new TypeFraisForfait();
        }
        public AjouterModifierTypeFraisForfait(string version, TypeFraisForfait typeFraisForfaitAModifier)
        {
            InitializeComponent();
            lblCreer.Visible = false;
            this.typeFraisForfaitAModifier = typeFraisForfaitAModifier;
            this.version = version;
            typeFraisForfaitBindingSource.DataSource = typeFraisForfaitAModifier;
            ChargerComposants(typeFraisForfaitAModifier);
        }

        private void ChargerComposants(TypeFraisForfait type)
        {
            nomTextBox.DataBindings.Clear();
            montantNumericUpDown.DataBindings.Clear();

            nomTextBox.DataBindings.Add("Text", typeFraisForfaitBindingSource, "Nom", true, DataSourceUpdateMode.OnPropertyChanged);
            montantNumericUpDown.DataBindings.Add("Value", typeFraisForfaitBindingSource, "Montant", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (version == "ajouter")
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
            else
            {
                typeFraisForfaitBindingSource.EndEdit();

                TypeFraisForfait typeFraisForfaitModifie = typeFraisForfaitBindingSource.Current as TypeFraisForfait;
                if (typeFraisForfaitModifie != null)
                {
                    ValidationContext context = new ValidationContext(typeFraisForfaitModifie, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(typeFraisForfaitModifie, context, errors, true))
                    {
                        foreach (ValidationResult validationResult in errors)
                        {
                            MessageBox.Show(validationResult.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        typeFraisForfaitModifie.IdFraisForfait = typeFraisForfaitAModifier.IdFraisForfait;
                        bool valeurRetour = Services.TypeFraisForfaitService.ModifierTypeFraisForfait(typeFraisForfaitModifie);
                        if (valeurRetour)
                            MessageBox.Show("Type de frais forfait modifié avec succés");
                        TypeFraisForfaitEvenement?.Invoke();
                        this.Close();
                    }
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
