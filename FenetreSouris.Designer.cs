namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreSouris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreSouris));
            pSouris = new Panel();
            lClavier = new Label();
            lCGauche = new Label();
            lCDroit = new Label();
            lPositionX = new Label();
            lPositionY = new Label();
            lbClavier = new ListBox();
            bRAZ = new Button();
            tbGauche = new TextBox();
            tbX = new TextBox();
            tbY = new TextBox();
            tbDroit = new TextBox();
            SuspendLayout();
            // 
            // pSouris
            // 
            pSouris.BorderStyle = BorderStyle.Fixed3D;
            pSouris.Location = new Point(310, 84);
            pSouris.Name = "pSouris";
            pSouris.Size = new Size(472, 365);
            pSouris.TabIndex = 0;
            // 
            // lClavier
            // 
            lClavier.AutoSize = true;
            lClavier.Location = new Point(12, 20);
            lClavier.Name = "lClavier";
            lClavier.Size = new Size(187, 25);
            lClavier.TabIndex = 1;
            lClavier.Text = "Interception du clavier";
            // 
            // lCGauche
            // 
            lCGauche.AutoSize = true;
            lCGauche.Location = new Point(310, 9);
            lCGauche.Name = "lCGauche";
            lCGauche.Size = new Size(101, 25);
            lCGauche.TabIndex = 2;
            lCGauche.Text = "Clic gauche";
            // 
            // lCDroit
            // 
            lCDroit.AutoSize = true;
            lCDroit.Location = new Point(440, 9);
            lCDroit.Name = "lCDroit";
            lCDroit.Size = new Size(82, 25);
            lCDroit.TabIndex = 3;
            lCDroit.Text = "Clic droit";
            // 
            // lPositionX
            // 
            lPositionX.AutoSize = true;
            lPositionX.Location = new Point(563, 9);
            lPositionX.Name = "lPositionX";
            lPositionX.Size = new Size(88, 25);
            lPositionX.TabIndex = 4;
            lPositionX.Text = "Position x";
            // 
            // lPositionY
            // 
            lPositionY.AutoSize = true;
            lPositionY.Location = new Point(681, 9);
            lPositionY.Name = "lPositionY";
            lPositionY.Size = new Size(89, 25);
            lPositionY.TabIndex = 5;
            lPositionY.Text = "Position y";
            // 
            // lbClavier
            // 
            lbClavier.FormattingEnabled = true;
            lbClavier.ItemHeight = 25;
            lbClavier.Location = new Point(12, 60);
            lbClavier.Name = "lbClavier";
            lbClavier.Size = new Size(274, 329);
            lbClavier.TabIndex = 6;
            // 
            // bRAZ
            // 
            bRAZ.Location = new Point(55, 395);
            bRAZ.Name = "bRAZ";
            bRAZ.Size = new Size(187, 34);
            bRAZ.TabIndex = 7;
            bRAZ.Text = "Remise a zéro";
            bRAZ.UseVisualStyleBackColor = true;
            // 
            // tbGauche
            // 
            tbGauche.Location = new Point(310, 47);
            tbGauche.Name = "tbGauche";
            tbGauche.ReadOnly = true;
            tbGauche.Size = new Size(101, 31);
            tbGauche.TabIndex = 0;
            // 
            // tbX
            // 
            tbX.Location = new Point(563, 47);
            tbX.Name = "tbX";
            tbX.ReadOnly = true;
            tbX.Size = new Size(101, 31);
            tbX.TabIndex = 8;
            // 
            // tbY
            // 
            tbY.Location = new Point(681, 47);
            tbY.Name = "tbY";
            tbY.ReadOnly = true;
            tbY.Size = new Size(101, 31);
            tbY.TabIndex = 9;
            // 
            // tbDroit
            // 
            tbDroit.Location = new Point(440, 47);
            tbDroit.Name = "tbDroit";
            tbDroit.ReadOnly = true;
            tbDroit.Size = new Size(101, 31);
            tbDroit.TabIndex = 10;
            // 
            // FenetreSouris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(tbY);
            Controls.Add(tbDroit);
            Controls.Add(tbX);
            Controls.Add(tbGauche);
            Controls.Add(bRAZ);
            Controls.Add(lbClavier);
            Controls.Add(lPositionY);
            Controls.Add(lPositionX);
            Controls.Add(lCDroit);
            Controls.Add(lCGauche);
            Controls.Add(lClavier);
            Controls.Add(pSouris);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "FenetreSouris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monitoring du clavier et de la souris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pSouris;
        private Label lClavier;
        private Label lCGauche;
        private Label lCDroit;
        private Label lPositionX;
        private Label lPositionY;
        private ListBox lbClavier;
        private Button bRAZ;
        private TextBox tbGauche;
        private TextBox tbX;
        private TextBox tbY;
        private TextBox tbDroit;
    }
}