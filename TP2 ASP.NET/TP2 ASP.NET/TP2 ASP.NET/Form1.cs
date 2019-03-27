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
        public string UserName1;
        public string UserName2;
        public string UserName3;
        public string UserName4;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User1.Text = UserName1;
            User2.Text = UserName2;
            if(UserName3 != null)
            {
                User3.Text = UserName3;
                if(UserName4 != null)
                {
                    User4.Text = UserName4;
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
