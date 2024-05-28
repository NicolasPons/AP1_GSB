using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace AP_1_GSB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.Sql.Connect();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sur le click du LOGIN

            //Co sur la BDD MySQL.
            Data.Sql.Connection.Open();
            //Vérification des informations du login. (username / password)


            //En fonction du login (switch case) ouvrir le bon forms.
            //1 - Visiteur
            //2 - Comptable
            //3 - Admin*



        }
    }
}
