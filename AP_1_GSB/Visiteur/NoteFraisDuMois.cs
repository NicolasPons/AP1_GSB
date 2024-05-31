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
    public partial class NoteFraisDuMois : Form
    {
        Utilisateur Utilisateur;
        public NoteFraisDuMois(Utilisateur utilisateur, FicheFrais ficheEnCours)
        {
            DateTime prochainMois = DateTime.Now.AddMonths(1);
            DateTime DateMin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 11);
            DateTime DateMax = new DateTime(DateTime.Now.Year, prochainMois.Month, 10);
            this.Utilisateur = utilisateur;
            InitializeComponent();
            DateFicheFrais.Text = "Fiche de frais du 11 " + DateTime.Now.ToString("MMMM yyyy") + " au 10 " + DateTime.Now.AddMonths(1).ToString("MMMM yyyy");
            dateTimePicker1.MinDate = DateMin;
            dateTimePicker1.MaxDate = DateMax;
        }
    }
}
