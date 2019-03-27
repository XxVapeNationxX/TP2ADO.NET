using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TP2_ASP.NET
{
    public partial class Form1 : Form
    {
        public User Joueur1;
        public User Joueur2;
        public User Joueur3;
        public User Joueur4;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            User1.Text = Joueur1.Prenom;
            User2.Text = Joueur2.Prenom;
            if(Joueur3.Id != -1)
            {
                User3.Text = Joueur3.Prenom;
                if(Joueur4.Id != -1)
                {
                    User4.Text = Joueur4.Prenom;
                }
            }
            else
            {
                User3.Text = "";
                User4.Text = "";
            }
        }
    }
}
