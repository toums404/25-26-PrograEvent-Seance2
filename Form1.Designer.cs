namespace _25_26_PrograEvent_Seance2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MsControles = new ToolStripMenuItem();
            MiListe = new ToolStripMenuItem();
            MiBarreProg = new ToolStripMenuItem();
            Separateur = new ToolStripSeparator();
            MiQuitter = new ToolStripMenuItem();
            MsApplications = new ToolStripMenuItem();
            MiEditeur = new ToolStripMenuItem();
            MsAide = new ToolStripMenuItem();
            MiApropos = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MsControles, MsApplications, MsAide });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MsControles
            // 
            MsControles.DropDownItems.AddRange(new ToolStripItem[] { MiListe, MiBarreProg, Separateur, MiQuitter });
            MsControles.Name = "MsControles";
            MsControles.Size = new Size(104, 29);
            MsControles.Text = "Contrôles";
            // 
            // MiListe
            // 
            MiListe.Name = "MiListe";
            MiListe.Size = new Size(279, 34);
            MiListe.Text = "Liste";
            MiListe.Click += MiListe_Click;
            // 
            // MiBarreProg
            // 
            MiBarreProg.Name = "MiBarreProg";
            MiBarreProg.Size = new Size(279, 34);
            MiBarreProg.Text = "Barre de progression";
            MiBarreProg.Click += MiBarreProg_Click;
            // 
            // Separateur
            // 
            Separateur.ForeColor = SystemColors.HotTrack;
            Separateur.Name = "Separateur";
            Separateur.Size = new Size(276, 6);
            // 
            // MiQuitter
            // 
            MiQuitter.Name = "MiQuitter";
            MiQuitter.Size = new Size(279, 34);
            MiQuitter.Text = "Quitter";
            // 
            // MsApplications
            // 
            MsApplications.DropDownItems.AddRange(new ToolStripItem[] { MiEditeur });
            MsApplications.Name = "MsApplications";
            MsApplications.Size = new Size(126, 29);
            MsApplications.Text = "Applications";
            // 
            // MiEditeur
            // 
            MiEditeur.Name = "MiEditeur";
            MiEditeur.Size = new Size(169, 34);
            MiEditeur.Text = "Editeur";
            MiEditeur.Click += MiEditeur_Click;
            // 
            // MsAide
            // 
            MsAide.DropDownItems.AddRange(new ToolStripItem[] { MiApropos });
            MsAide.Name = "MsAide";
            MsAide.Size = new Size(64, 29);
            MsAide.Text = "Aide";
            // 
            // MiApropos
            // 
            MiApropos.Name = "MiApropos";
            MiApropos.Size = new Size(188, 34);
            MiApropos.Text = "A Propos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MsControles;
        private ToolStripMenuItem MiListe;
        private ToolStripMenuItem MiBarreProg;
        private ToolStripSeparator Separateur;
        private ToolStripMenuItem MiQuitter;
        private ToolStripMenuItem MsApplications;
        private ToolStripMenuItem MiEditeur;
        private ToolStripMenuItem MsAide;
        private ToolStripMenuItem MiApropos;
    }
}
