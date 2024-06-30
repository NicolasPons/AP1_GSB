using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Data.Models
{
    //Attributs de la classe TypeFraisForfait et ses annotations qui définissent les règles de validation dans le forme dont le TypeFraisForfait est le DataSource
    public class TypeFraisForfait
    {
        public int IdFraisForfait { get; set; }
        [Required, RegularExpression(@"^[a-zA-ZÀ-ÿ]+( [a-zA-ZÀ-ÿ]+)*$", ErrorMessage = "Veuillez saisir un nom de frais valide")]

        public string Nom { get; set; }
        [Required]
        [Range (0, 5000)]
        public float Montant { get; set; }
    }
}


