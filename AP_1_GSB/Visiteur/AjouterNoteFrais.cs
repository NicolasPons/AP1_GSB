using AP_1_GSB.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Visiteur
{
    public partial class AjouterNoteFrais : Form
    {
        Utilisateur Utilisateur;
        public AjouterNoteFrais(Utilisateur utilisateur, FicheFrais ficheEnCours)
        {
            this.Utilisateur = utilisateur;
            InitializeComponent();
            DateFicheFrais.Text = "Fiche de frais du 10 " + DateTime.Now.ToString("MMMM yyyy") + " au 9 " + DateTime.Now.AddMonths(1).ToString("MMMM yyyy");
        }
    }
}
