namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreProgression
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ProgBSecondaire = new ProgressBar();
            ProgBPrincipale = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ProgBSecondaire);
            panel1.Controls.Add(ProgBPrincipale);
            panel1.Location = new Point(58, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 353);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 102);
            label2.Name = "label2";
            label2.Size = new Size(199, 25);
            label2.TabIndex = 3;
            label2.Text = "Chargement secondaire";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 14);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 2;
            label1.Text = "Chargement total";
            // 
            // ProgBSecondaire
            // 
            ProgBSecondaire.Location = new Point(40, 130);
            ProgBSecondaire.Name = "ProgBSecondaire";
            ProgBSecondaire.Size = new Size(190, 36);
            ProgBSecondaire.TabIndex = 1;
            // 
            // ProgBPrincipale
            // 
            ProgBPrincipale.Location = new Point(40, 42);
            ProgBPrincipale.Name = "ProgBPrincipale";
            ProgBPrincipale.Size = new Size(190, 34);
            ProgBPrincipale.TabIndex = 0;
            // 
            // FenetreProgression
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 584);
            Controls.Add(panel1);
            Name = "FenetreProgression";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FenetreProgression";
            Load += FenetreProgression_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ProgressBar ProgBPrincipale;
        private Label label1;
        private ProgressBar ProgBSecondaire;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}