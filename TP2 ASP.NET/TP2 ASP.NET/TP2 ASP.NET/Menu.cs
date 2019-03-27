using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_ASP.NET
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Joueur1Prenom.Clear();
            Joueur2Prenom.Clear();
            Joueur3Prenom.Clear();
            Joueur4Prenom.Clear();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Form1 Jeu = new Form1();
            Jeu.UserName1 = Joueur1Prenom.Text;
            Jeu.UserName2 = Joueur2Prenom.Text;
            if(!string.IsNullOrWhiteSpace(Joueur3Prenom.Text))
            {
                Jeu.UserName3 = Joueur3Prenom.Text;
            }
            if (!string.IsNullOrWhiteSpace(Joueur4Prenom.Text))
            {
                Jeu.UserName4 = Joueur4Prenom.Text;
            }
            Jeu.ShowDialog();
        }

        private void Joueur2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Joueur1Prenom.Text) && !string.IsNullOrWhiteSpace(Joueur2Prenom.Text))
            {
                Start.Enabled = true;
            }
            else
            {
                Start.Enabled = false;
            }
        }

        private void Joueur2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Joueur1Prenom.Text) && !string.IsNullOrWhiteSpace(Joueur2Prenom.Text))
            {
                Start.Enabled = true;
            }
            else
            {
                Start.Enabled = false;
            }
        }
    }
}
