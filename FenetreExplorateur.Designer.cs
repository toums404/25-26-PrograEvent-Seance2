namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreExplorateur
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreExplorateur));
            toolStrip1 = new ToolStrip();
            tsbQuitter = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsddbApparence = new ToolStripDropDownButton();
            tsaPetitesIcones = new ToolStripMenuItem();
            tsaGrandesIcones = new ToolStripMenuItem();
            tsaListe = new ToolStripMenuItem();
            tsaDetail = new ToolStripMenuItem();
            ssMessage = new StatusStrip();
            slMessage = new ToolStripStatusLabel();
            scSeparateur = new SplitContainer();
            tvRepertoire = new TreeView();
            lvFichier = new ListView();
            Nom = new ColumnHeader();
            Taille = new ColumnHeader();
            Création = new ColumnHeader();
            Modification = new ColumnHeader();
            ilTreeView = new ImageList(components);
            ilGrand = new ImageList(components);
            ilPetit = new ImageList(components);
            toolStrip1.SuspendLayout();
            ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scSeparateur).BeginInit();
            scSeparateur.Panel1.SuspendLayout();
            scSeparateur.Panel2.SuspendLayout();
            scSeparateur.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbQuitter, toolStripSeparator1, tsddbApparence });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            tsbQuitter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbQuitter.Image = Properties.Resources.quitterFichier;
            tsbQuitter.ImageTransparentColor = Color.Magenta;
            tsbQuitter.Name = "tsbQuitter";
            tsbQuitter.Size = new Size(34, 28);
            tsbQuitter.Text = "toolStripButton1";
            tsbQuitter.Click += tsbQuitter_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // tsddbApparence
            // 
            tsddbApparence.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsddbApparence.DropDownItems.AddRange(new ToolStripItem[] { tsaPetitesIcones, tsaGrandesIcones, tsaListe, tsaDetail });
            tsddbApparence.Image = (Image)resources.GetObject("tsddbApparence.Image");
            tsddbApparence.ImageTransparentColor = Color.Magenta;
            tsddbApparence.Name = "tsddbApparence";
            tsddbApparence.Size = new Size(42, 28);
            tsddbApparence.Text = "toolStripDropDownButton1";
            // 
            // tsaPetitesIcones
            // 
            tsaPetitesIcones.Name = "tsaPetitesIcones";
            tsaPetitesIcones.Size = new Size(235, 34);
            tsaPetitesIcones.Text = "Petites Icones";
            tsaPetitesIcones.Click += tsaPetitesIcones_Click;
            // 
            // tsaGrandesIcones
            // 
            tsaGrandesIcones.Name = "tsaGrandesIcones";
            tsaGrandesIcones.Size = new Size(235, 34);
            tsaGrandesIcones.Text = "Grandes Icones";
            tsaGrandesIcones.Click += tsaGrandesIcones_Click;
            // 
            // tsaListe
            // 
            tsaListe.Name = "tsaListe";
            tsaListe.Size = new Size(235, 34);
            tsaListe.Text = "Liste";
            tsaListe.Click += tsaListe_Click;
            // 
            // tsaDetail
            // 
            tsaDetail.Name = "tsaDetail";
            tsaDetail.Size = new Size(235, 34);
            tsaDetail.Text = "Détail";
            tsaDetail.Click += tsaDetail_Click;
            // 
            // ssMessage
            // 
            ssMessage.ImageScalingSize = new Size(24, 24);
            ssMessage.Items.AddRange(new ToolStripItem[] { slMessage });
            ssMessage.Location = new Point(0, 418);
            ssMessage.Name = "ssMessage";
            ssMessage.Size = new Size(800, 32);
            ssMessage.TabIndex = 1;
            ssMessage.Text = "statusStrip1";
            // 
            // slMessage
            // 
            slMessage.Name = "slMessage";
            slMessage.Size = new Size(218, 25);
            slMessage.Text = "Bienvenue à la TomCorp®";
            // 
            // scSeparateur
            // 
            scSeparateur.Dock = DockStyle.Fill;
            scSeparateur.Location = new Point(0, 33);
            scSeparateur.Name = "scSeparateur";
            // 
            // scSeparateur.Panel1
            // 
            scSeparateur.Panel1.Controls.Add(tvRepertoire);
            // 
            // scSeparateur.Panel2
            // 
            scSeparateur.Panel2.Controls.Add(lvFichier);
            scSeparateur.Size = new Size(800, 385);
            scSeparateur.SplitterDistance = 266;
            scSeparateur.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            tvRepertoire.Dock = DockStyle.Fill;
            tvRepertoire.Location = new Point(0, 0);
            tvRepertoire.Name = "tvRepertoire";
            tvRepertoire.Size = new Size(266, 385);
            tvRepertoire.TabIndex = 0;
            tvRepertoire.AfterSelect += tvRepertoire_AfterSelect;
            // 
            // lvFichier
            // 
            lvFichier.Columns.AddRange(new ColumnHeader[] { Nom, Taille, Création, Modification });
            lvFichier.Dock = DockStyle.Fill;
            lvFichier.Location = new Point(0, 0);
            lvFichier.Name = "lvFichier";
            lvFichier.Size = new Size(530, 385);
            lvFichier.TabIndex = 0;
            lvFichier.UseCompatibleStateImageBehavior = false;
            lvFichier.View = View.Details;
            // 
            // Nom
            // 
            Nom.Text = "Nom";
            Nom.Width = 150;
            // 
            // Taille
            // 
            Taille.Text = "Taille";
            Taille.Width = 100;
            // 
            // Création
            // 
            Création.Text = "Création";
            Création.Width = 100;
            // 
            // Modification
            // 
            Modification.Text = "Modification";
            Modification.Width = 140;
            // 
            // ilTreeView
            // 
            ilTreeView.ColorDepth = ColorDepth.Depth32Bit;
            ilTreeView.ImageStream = (ImageListStreamer)resources.GetObject("ilTreeView.ImageStream");
            ilTreeView.TransparentColor = Color.Transparent;
            ilTreeView.Images.SetKeyName(0, "iconeOrdi.png");
            ilTreeView.Images.SetKeyName(1, "DisqueDur.png");
            ilTreeView.Images.SetKeyName(2, "Dossier.png");
            // 
            // ilGrand
            // 
            ilGrand.ColorDepth = ColorDepth.Depth32Bit;
            ilGrand.ImageStream = (ImageListStreamer)resources.GetObject("ilGrand.ImageStream");
            ilGrand.TransparentColor = Color.Transparent;
            ilGrand.Images.SetKeyName(0, "Fichier.png");
            // 
            // ilPetit
            // 
            ilPetit.ColorDepth = ColorDepth.Depth32Bit;
            ilPetit.ImageStream = (ImageListStreamer)resources.GetObject("ilPetit.ImageStream");
            ilPetit.TransparentColor = Color.Transparent;
            ilPetit.Images.SetKeyName(0, "Fichier.png");
            // 
            // FenetreExplorateur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scSeparateur);
            Controls.Add(ssMessage);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FenetreExplorateur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Explorateur";
            Load += FenetreExplorateur_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ssMessage.ResumeLayout(false);
            ssMessage.PerformLayout();
            scSeparateur.Panel1.ResumeLayout(false);
            scSeparateur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scSeparateur).EndInit();
            scSeparateur.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbQuitter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsddbApparence;
        private ToolStripMenuItem tsaPetitesIcones;
        private ToolStripMenuItem tsaGrandesIcones;
        private ToolStripMenuItem tsaListe;
        private ToolStripMenuItem tsaDetail;
        private StatusStrip ssMessage;
        private ToolStripStatusLabel slMessage;
        private SplitContainer scSeparateur;
        private TreeView tvRepertoire;
        private ListView lvFichier;
        private ColumnHeader Nom;
        private ColumnHeader Taille;
        private ColumnHeader Création;
        private ColumnHeader Modification;
        private ImageList ilTreeView;
        private ImageList ilGrand;
        private ImageList ilPetit;
    }
}