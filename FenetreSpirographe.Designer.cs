namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreSpirographe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreSpirographe));
            GbParametrage = new GroupBox();
            bGo = new Button();
            bFond = new Button();
            bTrait = new Button();
            TbSommet = new TrackBar();
            TbDensite = new TrackBar();
            TbProfondeur = new TrackBar();
            lSommet = new Label();
            lDensite = new Label();
            lProfondeur = new Label();
            colorDialog1 = new ColorDialog();
            GbParametrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TbSommet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TbDensite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TbProfondeur).BeginInit();
            SuspendLayout();
            // 
            // GbParametrage
            // 
            GbParametrage.Controls.Add(lSommet);
            GbParametrage.Controls.Add(lDensite);
            GbParametrage.Controls.Add(lProfondeur);
            GbParametrage.Controls.Add(TbProfondeur);
            GbParametrage.Controls.Add(TbDensite);
            GbParametrage.Controls.Add(TbSommet);
            GbParametrage.Controls.Add(bGo);
            GbParametrage.Location = new Point(2, 2);
            GbParametrage.Name = "GbParametrage";
            GbParametrage.Size = new Size(300, 348);
            GbParametrage.TabIndex = 0;
            GbParametrage.TabStop = false;
            GbParametrage.Text = "Paramétrage";
            // 
            // bGo
            // 
            bGo.Cursor = Cursors.Hand;
            bGo.Dock = DockStyle.Bottom;
            bGo.Location = new Point(3, 311);
            bGo.Name = "bGo";
            bGo.Size = new Size(294, 34);
            bGo.TabIndex = 1;
            bGo.Text = "GO !";
            bGo.UseVisualStyleBackColor = true;
            // 
            // bFond
            // 
            bFond.Cursor = Cursors.Hand;
            bFond.Location = new Point(167, 356);
            bFond.Name = "bFond";
            bFond.Size = new Size(135, 65);
            bFond.TabIndex = 2;
            bFond.Text = "Couleur de fond";
            bFond.UseVisualStyleBackColor = true;
            // 
            // bTrait
            // 
            bTrait.Cursor = Cursors.Hand;
            bTrait.ImageAlign = ContentAlignment.MiddleLeft;
            bTrait.Location = new Point(2, 356);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(135, 65);
            bTrait.TabIndex = 3;
            bTrait.Text = "Couleur du trait";
            bTrait.UseVisualStyleBackColor = true;
            // 
            // TbSommet
            // 
            TbSommet.Location = new Point(0, 86);
            TbSommet.Name = "TbSommet";
            TbSommet.Size = new Size(288, 69);
            TbSommet.TabIndex = 4;
            // 
            // TbDensite
            // 
            TbDensite.Location = new Point(0, 161);
            TbDensite.Name = "TbDensite";
            TbDensite.Size = new Size(288, 69);
            TbDensite.TabIndex = 5;
            // 
            // TbProfondeur
            // 
            TbProfondeur.Location = new Point(3, 236);
            TbProfondeur.Name = "TbProfondeur";
            TbProfondeur.Size = new Size(288, 69);
            TbProfondeur.TabIndex = 6;
            // 
            // lSommet
            // 
            lSommet.AutoSize = true;
            lSommet.Location = new Point(6, 58);
            lSommet.Name = "lSommet";
            lSommet.Size = new Size(228, 25);
            lSommet.TabIndex = 4;
            lSommet.Text = "Nombre de sommet (3 à 8)";
            // 
            // lDensite
            // 
            lDensite.AutoSize = true;
            lDensite.Location = new Point(3, 130);
            lDensite.Name = "lDensite";
            lDensite.Size = new Size(223, 25);
            lDensite.TabIndex = 5;
            lDensite.Text = "Densité de dessins (5 à 20)";
            // 
            // lProfondeur
            // 
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(6, 208);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(264, 25);
            lProfondeur.TabIndex = 6;
            lProfondeur.Text = "Profondeur de dessins (20 à 80)";
            // 
            // FenetreSpirographe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bFond);
            Controls.Add(bTrait);
            Controls.Add(GbParametrage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FenetreSpirographe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spirographe";
            GbParametrage.ResumeLayout(false);
            GbParametrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TbSommet).EndInit();
            ((System.ComponentModel.ISupportInitialize)TbDensite).EndInit();
            ((System.ComponentModel.ISupportInitialize)TbProfondeur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbParametrage;
        private Button bGo;
        private Button bFond;
        private Button bTrait;
        private Label lSommet;
        private Label lDensite;
        private Label lProfondeur;
        private TrackBar TbProfondeur;
        private TrackBar TbDensite;
        private TrackBar TbSommet;
        private ColorDialog colorDialog1;
    }
}