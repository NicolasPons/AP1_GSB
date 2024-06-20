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
    public class TypeFraisForfait
    {
        public int IdFraisForfait { get; set; }
        [Required, RegularExpression(@"^[a-zA-Z]+( [a-zA-Z]+)*$", ErrorMessage ="Veuillez saisir un nom de frais valide")] 
        public string Nom { get; set; }
        [Required]
        [Range (0, 5000)]
        public float Montant { get; set; }
    }
}


