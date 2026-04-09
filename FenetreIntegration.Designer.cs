namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreIntegration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreIntegration));
            lGauche = new Label();
            lDroite = new Label();
            lNbInt = new Label();
            panel1 = new Panel();
            bPointeurTrigonometrique = new Button();
            bPointeurPolynome = new Button();
            bTrigonometrique = new Button();
            bPolynome = new Button();
            lbResultats = new ListBox();
            tbNbInt = new TextBox();
            tbDroite = new TextBox();
            tbGauche = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lGauche
            // 
            lGauche.AutoSize = true;
            lGauche.Location = new Point(39, 23);
            lGauche.Name = "lGauche";
            lGauche.Size = new Size(70, 25);
            lGauche.TabIndex = 0;
            lGauche.Text = "Gauche";
            // 
            // lDroite
            // 
            lDroite.AutoSize = true;
            lDroite.Location = new Point(193, 23);
            lDroite.Name = "lDroite";
            lDroite.Size = new Size(61, 25);
            lDroite.TabIndex = 1;
            lDroite.Text = "Droite";
            // 
            // lNbInt
            // 
            lNbInt.AutoSize = true;
            lNbInt.Location = new Point(364, 23);
            lNbInt.Name = "lNbInt";
            lNbInt.Size = new Size(119, 25);
            lNbInt.TabIndex = 2;
            lNbInt.Text = "Nb intervalles";
            // 
            // panel1
            // 
            panel1.Controls.Add(bPointeurTrigonometrique);
            panel1.Controls.Add(bPointeurPolynome);
            panel1.Controls.Add(bTrigonometrique);
            panel1.Controls.Add(bPolynome);
            panel1.Controls.Add(lbResultats);
            panel1.Controls.Add(tbNbInt);
            panel1.Controls.Add(tbDroite);
            panel1.Controls.Add(tbGauche);
            panel1.Controls.Add(lGauche);
            panel1.Controls.Add(lNbInt);
            panel1.Controls.Add(lDroite);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 638);
            panel1.TabIndex = 3;
            // 
            // bPointeurTrigonometrique
            // 
            bPointeurTrigonometrique.Cursor = Cursors.Hand;
            bPointeurTrigonometrique.Location = new Point(313, 565);
            bPointeurTrigonometrique.Name = "bPointeurTrigonometrique";
            bPointeurTrigonometrique.Size = new Size(170, 61);
            bPointeurTrigonometrique.TabIndex = 10;
            bPointeurTrigonometrique.Text = "Idem Pointeur";
            bPointeurTrigonometrique.UseVisualStyleBackColor = true;
            // 
            // bPointeurPolynome
            // 
            bPointeurPolynome.Cursor = Cursors.Hand;
            bPointeurPolynome.Location = new Point(313, 484);
            bPointeurPolynome.Name = "bPointeurPolynome";
            bPointeurPolynome.Size = new Size(170, 61);
            bPointeurPolynome.TabIndex = 9;
            bPointeurPolynome.Text = "Idem Pointeur";
            bPointeurPolynome.UseVisualStyleBackColor = true;
            // 
            // bTrigonometrique
            // 
            bTrigonometrique.Cursor = Cursors.Hand;
            bTrigonometrique.Location = new Point(39, 565);
            bTrigonometrique.Name = "bTrigonometrique";
            bTrigonometrique.Size = new Size(260, 61);
            bTrigonometrique.TabIndex = 8;
            bTrigonometrique.Text = "Trigonométrique : sin(x)";
            bTrigonometrique.UseVisualStyleBackColor = true;
            // 
            // bPolynome
            // 
            bPolynome.Cursor = Cursors.Hand;
            bPolynome.Location = new Point(39, 484);
            bPolynome.Name = "bPolynome";
            bPolynome.Size = new Size(260, 61);
            bPolynome.TabIndex = 7;
            bPolynome.Text = "Polynôme : x²+2";
            bPolynome.UseVisualStyleBackColor = true;
            // 
            // lbResultats
            // 
            lbResultats.FormattingEnabled = true;
            lbResultats.ItemHeight = 25;
            lbResultats.Location = new Point(39, 103);
            lbResultats.Name = "lbResultats";
            lbResultats.Size = new Size(444, 354);
            lbResultats.TabIndex = 6;
            // 
            // tbNbInt
            // 
            tbNbInt.Location = new Point(364, 51);
            tbNbInt.Name = "tbNbInt";
            tbNbInt.Size = new Size(119, 31);
            tbNbInt.TabIndex = 5;
            // 
            // tbDroite
            // 
            tbDroite.Location = new Point(193, 51);
            tbDroite.Name = "tbDroite";
            tbDroite.Size = new Size(119, 31);
            tbDroite.TabIndex = 4;
            // 
            // tbGauche
            // 
            tbGauche.Location = new Point(39, 51);
            tbGauche.Name = "tbGauche";
            tbGauche.Size = new Size(119, 31);
            tbGauche.TabIndex = 3;
            // 
            // FenetreIntegration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 638);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FenetreIntegration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Integration numérique";
            Load += FenetreIntegration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lGauche;
        private Label lDroite;
        private Label lNbInt;
        private Panel panel1;
        private Button bPointeurTrigonometrique;
        private Button bPointeurPolynome;
        private Button bTrigonometrique;
        private Button bPolynome;
        private ListBox lbResultats;
        private TextBox tbNbInt;
        private TextBox tbDroite;
        private TextBox tbGauche;
    }
}