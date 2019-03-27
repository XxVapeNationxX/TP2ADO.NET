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
            Joueur1.Clear();
            Joueur2.Clear();
            Joueur3.Clear();
            Joueur4.Clear();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Form1 Jeu = new Form1();
            Jeu.UserName1 = Joueur1.Text;
            Jeu.UserName2 = Joueur2.Text;
            if(!string.IsNullOrWhiteSpace(Joueur3.Text))
            {
                Jeu.UserName3 = Joueur3.Text;
            }
            if (!string.IsNullOrWhiteSpace(Joueur4.Text))
            {
                Jeu.UserName4 = Joueur4.Text;
            }
            Jeu.ShowDialog();
        }

        private void Joueur2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Joueur1.Text) && !string.IsNullOrWhiteSpace(Joueur2.Text))
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
            if (!string.IsNullOrWhiteSpace(Joueur1.Text) && !string.IsNullOrWhiteSpace(Joueur2.Text))
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
