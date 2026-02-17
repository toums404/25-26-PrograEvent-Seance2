namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreEditeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreEditeur));
            menuStrip1 = new MenuStrip();
            MsFichier = new ToolStripMenuItem();
            MiNouveau = new ToolStripMenuItem();
            MiOuvrir = new ToolStripMenuItem();
            MiEnregistrer = new ToolStripMenuItem();
            MiQuitter = new ToolStripMenuItem();
            MsEdition = new ToolStripMenuItem();
            MiCopier = new ToolStripMenuItem();
            MiCouper = new ToolStripMenuItem();
            MiColler = new ToolStripMenuItem();
            MsFormat = new ToolStripMenuItem();
            MiJustifier = new ToolStripMenuItem();
            centreToolStripMenuItem = new ToolStripMenuItem();
            gaucheToolStripMenuItem = new ToolStripMenuItem();
            droiteToolStripMenuItem = new ToolStripMenuItem();
            MiPolice = new ToolStripMenuItem();
            MiCaractere = new ToolStripMenuItem();
            Mi2Gras = new ToolStripMenuItem();
            Mi2Italique = new ToolStripMenuItem();
            Mi2Souligne = new ToolStripMenuItem();
            Mi2Barre = new ToolStripMenuItem();
            pMenu = new Panel();
            pbQuitter = new PictureBox();
            pbEnregistrer = new PictureBox();
            pbOuvrir = new PictureBox();
            pbNouveau = new PictureBox();
            rtbTexte = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MsFichier, MsEdition, MsFormat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MsFichier
            // 
            MsFichier.DropDownItems.AddRange(new ToolStripItem[] { MiNouveau, MiOuvrir, MiEnregistrer, MiQuitter });
            MsFichier.Name = "MsFichier";
            MsFichier.Size = new Size(78, 29);
            MsFichier.Text = "Fichier";
            // 
            // MiNouveau
            // 
            MiNouveau.Name = "MiNouveau";
            MiNouveau.Size = new Size(198, 34);
            MiNouveau.Text = "Nouveau";
            // 
            // MiOuvrir
            // 
            MiOuvrir.Name = "MiOuvrir";
            MiOuvrir.Size = new Size(198, 34);
            MiOuvrir.Text = "Ouvrir";
            // 
            // MiEnregistrer
            // 
            MiEnregistrer.Name = "MiEnregistrer";
            MiEnregistrer.Size = new Size(198, 34);
            MiEnregistrer.Text = "Enregistrer";
            // 
            // MiQuitter
            // 
            MiQuitter.Name = "MiQuitter";
            MiQuitter.Size = new Size(198, 34);
            MiQuitter.Text = "Quitter";
            // 
            // MsEdition
            // 
            MsEdition.DropDownItems.AddRange(new ToolStripItem[] { MiCopier, MiCouper, MiColler });
            MsEdition.Name = "MsEdition";
            MsEdition.Size = new Size(83, 29);
            MsEdition.Text = "Edition";
            // 
            // MiCopier
            // 
            MiCopier.Name = "MiCopier";
            MiCopier.Size = new Size(172, 34);
            MiCopier.Text = "Copier";
            // 
            // MiCouper
            // 
            MiCouper.Name = "MiCouper";
            MiCouper.Size = new Size(172, 34);
            MiCouper.Text = "Couper";
            // 
            // MiColler
            // 
            MiColler.Name = "MiColler";
            MiColler.Size = new Size(172, 34);
            MiColler.Text = "Coller";
            // 
            // MsFormat
            // 
            MsFormat.DropDownItems.AddRange(new ToolStripItem[] { MiJustifier, MiPolice, MiCaractere });
            MsFormat.Name = "MsFormat";
            MsFormat.Size = new Size(85, 29);
            MsFormat.Text = "Format";
            // 
            // MiJustifier
            // 
            MiJustifier.DropDownItems.AddRange(new ToolStripItem[] { centreToolStripMenuItem, gaucheToolStripMenuItem, droiteToolStripMenuItem });
            MiJustifier.Name = "MiJustifier";
            MiJustifier.Size = new Size(187, 34);
            MiJustifier.Text = "Justifier";
            // 
            // centreToolStripMenuItem
            // 
            centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            centreToolStripMenuItem.Size = new Size(172, 34);
            centreToolStripMenuItem.Text = "Centre";
            // 
            // gaucheToolStripMenuItem
            // 
            gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            gaucheToolStripMenuItem.Size = new Size(172, 34);
            gaucheToolStripMenuItem.Text = "Gauche";
            // 
            // droiteToolStripMenuItem
            // 
            droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            droiteToolStripMenuItem.Size = new Size(172, 34);
            droiteToolStripMenuItem.Text = "Droite";
            // 
            // MiPolice
            // 
            MiPolice.Name = "MiPolice";
            MiPolice.Size = new Size(187, 34);
            MiPolice.Text = "Police";
            // 
            // MiCaractere
            // 
            MiCaractere.DropDownItems.AddRange(new ToolStripItem[] { Mi2Gras, Mi2Italique, Mi2Souligne, Mi2Barre });
            MiCaractere.Name = "MiCaractere";
            MiCaractere.Size = new Size(187, 34);
            MiCaractere.Text = "Caractère";
            // 
            // Mi2Gras
            // 
            Mi2Gras.Name = "Mi2Gras";
            Mi2Gras.Size = new Size(183, 34);
            Mi2Gras.Text = "Gras";
            // 
            // Mi2Italique
            // 
            Mi2Italique.Name = "Mi2Italique";
            Mi2Italique.Size = new Size(183, 34);
            Mi2Italique.Text = "Italique";
            // 
            // Mi2Souligne
            // 
            Mi2Souligne.Name = "Mi2Souligne";
            Mi2Souligne.Size = new Size(183, 34);
            Mi2Souligne.Text = "Souligné";
            // 
            // Mi2Barre
            // 
            Mi2Barre.Name = "Mi2Barre";
            Mi2Barre.Size = new Size(183, 34);
            Mi2Barre.Text = "Barré";
            // 
            // pMenu
            // 
            pMenu.Controls.Add(pbQuitter);
            pMenu.Controls.Add(pbEnregistrer);
            pMenu.Controls.Add(pbOuvrir);
            pMenu.Controls.Add(pbNouveau);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 33);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(800, 41);
            pMenu.TabIndex = 1;
            // 
            // pbQuitter
            // 
            pbQuitter.Image = (Image)resources.GetObject("pbQuitter.Image");
            pbQuitter.Location = new Point(111, 3);
            pbQuitter.Name = "pbQuitter";
            pbQuitter.Size = new Size(30, 30);
            pbQuitter.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitter.TabIndex = 3;
            pbQuitter.TabStop = false;
            // 
            // pbEnregistrer
            // 
            pbEnregistrer.Image = (Image)resources.GetObject("pbEnregistrer.Image");
            pbEnregistrer.Location = new Point(75, 3);
            pbEnregistrer.Name = "pbEnregistrer";
            pbEnregistrer.Size = new Size(30, 30);
            pbEnregistrer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEnregistrer.TabIndex = 2;
            pbEnregistrer.TabStop = false;
            // 
            // pbOuvrir
            // 
            pbOuvrir.Image = (Image)resources.GetObject("pbOuvrir.Image");
            pbOuvrir.Location = new Point(39, 3);
            pbOuvrir.Name = "pbOuvrir";
            pbOuvrir.Size = new Size(30, 30);
            pbOuvrir.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOuvrir.TabIndex = 1;
            pbOuvrir.TabStop = false;
            // 
            // pbNouveau
            // 
            pbNouveau.Image = (Image)resources.GetObject("pbNouveau.Image");
            pbNouveau.Location = new Point(3, 3);
            pbNouveau.Name = "pbNouveau";
            pbNouveau.Size = new Size(30, 30);
            pbNouveau.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNouveau.TabIndex = 0;
            pbNouveau.TabStop = false;
            // 
            // rtbTexte
            // 
            rtbTexte.Dock = DockStyle.Bottom;
            rtbTexte.Location = new Point(0, 80);
            rtbTexte.Name = "rtbTexte";
            rtbTexte.Size = new Size(800, 370);
            rtbTexte.TabIndex = 0;
            rtbTexte.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FenetreEditeur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbTexte);
            Controls.Add(pMenu);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FenetreEditeur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FenetreEditeur";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQuitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MsFichier;
        private ToolStripMenuItem MsEdition;
        private ToolStripMenuItem MiNouveau;
        private ToolStripMenuItem MiOuvrir;
        private ToolStripMenuItem MiEnregistrer;
        private ToolStripMenuItem MiQuitter;
        private ToolStripMenuItem MiCopier;
        private ToolStripMenuItem MiCouper;
        private ToolStripMenuItem MiColler;
        private ToolStripMenuItem MsFormat;
        private ToolStripMenuItem MiJustifier;
        private ToolStripMenuItem centreToolStripMenuItem;
        private ToolStripMenuItem gaucheToolStripMenuItem;
        private ToolStripMenuItem droiteToolStripMenuItem;
        private ToolStripMenuItem MiPolice;
        private ToolStripMenuItem MiCaractere;
        private ToolStripMenuItem Mi2Gras;
        private ToolStripMenuItem Mi2Italique;
        private ToolStripMenuItem Mi2Souligne;
        private ToolStripMenuItem Mi2Barre;
        private Panel pMenu;
        private RichTextBox rtbTexte;
        private PictureBox pbQuitter;
        private PictureBox pbEnregistrer;
        private PictureBox pbOuvrir;
        private PictureBox pbNouveau;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
    }
}