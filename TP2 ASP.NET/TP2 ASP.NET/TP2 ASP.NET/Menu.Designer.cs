namespace TP2_ASP.NET
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Joueur1 = new System.Windows.Forms.TextBox();
            this.Joueur2 = new System.Windows.Forms.TextBox();
            this.Joueur3 = new System.Windows.Forms.TextBox();
            this.Joueur4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "TriviaCrook";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP2_ASP.NET.Properties.Resources.Emojione_1F3AE_svg;
            this.pictureBox1.Location = new System.Drawing.Point(459, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Firebrick;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.Start.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(268, 350);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(287, 66);
            this.Start.TabIndex = 2;
            this.Start.Text = "Jouer!";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Joueur 1:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Joueur 2:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Joueur 3:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Joueur 4:";
            // 
            // Joueur1
            // 
            this.Joueur1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur1.Location = new System.Drawing.Point(250, 140);
            this.Joueur1.Name = "Joueur1";
            this.Joueur1.Size = new System.Drawing.Size(326, 29);
            this.Joueur1.TabIndex = 8;
            this.Joueur1.TextChanged += new System.EventHandler(this.Joueur2_TextChanged);
            this.Joueur1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Joueur2_KeyPress);
            // 
            // Joueur2
            // 
            this.Joueur2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur2.Location = new System.Drawing.Point(250, 187);
            this.Joueur2.Name = "Joueur2";
            this.Joueur2.Size = new System.Drawing.Size(326, 29);
            this.Joueur2.TabIndex = 9;
            this.Joueur2.TextChanged += new System.EventHandler(this.Joueur2_TextChanged);
            this.Joueur2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Joueur2_KeyPress);
            // 
            // Joueur3
            // 
            this.Joueur3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur3.Location = new System.Drawing.Point(250, 238);
            this.Joueur3.Name = "Joueur3";
            this.Joueur3.Size = new System.Drawing.Size(326, 29);
            this.Joueur3.TabIndex = 10;
            this.Joueur3.TextChanged += new System.EventHandler(this.Joueur2_TextChanged);
            this.Joueur3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Joueur2_KeyPress);
            // 
            // Joueur4
            // 
            this.Joueur4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur4.Location = new System.Drawing.Point(250, 289);
            this.Joueur4.Name = "Joueur4";
            this.Joueur4.Size = new System.Drawing.Size(326, 29);
            this.Joueur4.TabIndex = 11;
            this.Joueur4.TextChanged += new System.EventHandler(this.Joueur2_TextChanged);
            this.Joueur4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Joueur2_KeyPress);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Joueur4);
            this.Controls.Add(this.Joueur3);
            this.Controls.Add(this.Joueur2);
            this.Controls.Add(this.Joueur1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Joueur1;
        private System.Windows.Forms.TextBox Joueur2;
        private System.Windows.Forms.TextBox Joueur3;
        private System.Windows.Forms.TextBox Joueur4;
    }
}