namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreHistogramme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreHistogramme));
            bCreer = new Mes_Controles.BoutonColore();
            bDessiner = new Mes_Controles.BoutonColore();
            pDessin = new Panel();
            lbMonPoint = new ListBox();
            HistoPerso = new MonHistogramme();
            label1 = new Label();
            SuspendLayout();
            // 
            // bCreer
            // 
            bCreer.CouleurDroite = Color.MediumTurquoise;
            bCreer.CouleurGauche = Color.Crimson;
            bCreer.Location = new Point(39, 27);
            bCreer.Name = "bCreer";
            bCreer.Size = new Size(223, 39);
            bCreer.TabIndex = 0;
            bCreer.Text = "Créer";
            bCreer.TransparenceDroite = 128;
            bCreer.TransparenceGauche = 64;
            bCreer.UseVisualStyleBackColor = true;
            bCreer.Click += bCreer_Click;
            // 
            // bDessiner
            // 
            bDessiner.CouleurDroite = Color.Cyan;
            bDessiner.CouleurGauche = Color.BlueViolet;
            bDessiner.Location = new Point(533, 27);
            bDessiner.Name = "bDessiner";
            bDessiner.Size = new Size(223, 39);
            bDessiner.TabIndex = 1;
            bDessiner.Text = "Dessiner";
            bDessiner.TransparenceDroite = 64;
            bDessiner.TransparenceGauche = 64;
            bDessiner.UseVisualStyleBackColor = true;
            bDessiner.Click += bDessiner_Click;
            // 
            // pDessin
            // 
            pDessin.Location = new Point(39, 89);
            pDessin.Name = "pDessin";
            pDessin.Size = new Size(495, 334);
            pDessin.TabIndex = 2;
            // 
            // lbMonPoint
            // 
            lbMonPoint.FormattingEnabled = true;
            lbMonPoint.ItemHeight = 25;
            lbMonPoint.Location = new Point(540, 89);
            lbMonPoint.Name = "lbMonPoint";
            lbMonPoint.Size = new Size(216, 129);
            lbMonPoint.TabIndex = 3;
            // 
            // HistoPerso
            // 
            HistoPerso.Location = new Point(540, 249);
            HistoPerso.MaxX = 216;
            HistoPerso.MaxY = 199;
            HistoPerso.MinX = 0;
            HistoPerso.MinY = -100;
            HistoPerso.Name = "HistoPerso";
            HistoPerso.Size = new Size(216, 174);
            HistoPerso.TabIndex = 4;
            HistoPerso.Trait = Color.Red;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(540, 221);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 5;
            label1.Text = "histogramme perso : ";
            // 
            // FenetreHistogramme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(HistoPerso);
            Controls.Add(lbMonPoint);
            Controls.Add(pDessin);
            Controls.Add(bDessiner);
            Controls.Add(bCreer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FenetreHistogramme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histogramme";
            Load += FenetreHistogramme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Mes_Controles.BoutonColore bCreer;
        private Mes_Controles.BoutonColore bDessiner;
        private Panel pDessin;
        private ListBox lbMonPoint;
        private MonHistogramme HistoPerso;
        private Label label1;
    }
}