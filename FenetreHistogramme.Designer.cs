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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            boutonColore1 = new Mes_Controles.BoutonColore();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // boutonColore1
            // 
            boutonColore1.CouleurDroite = Color.MediumTurquoise;
            boutonColore1.CouleurGauche = Color.Crimson;
            boutonColore1.Location = new Point(191, 104);
            boutonColore1.Name = "boutonColore1";
            boutonColore1.Size = new Size(401, 215);
            boutonColore1.TabIndex = 0;
            boutonColore1.Text = "boutonColore1";
            boutonColore1.TransparenceDroite = 128;
            boutonColore1.TransparenceGauche = 64;
            boutonColore1.UseVisualStyleBackColor = true;
            // 
            // FenetreHistogramme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boutonColore1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FenetreHistogramme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histogramme";
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Mes_Controles.BoutonColore boutonColore1;
    }
}