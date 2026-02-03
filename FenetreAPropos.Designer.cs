namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreAPropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreAPropos));
            pbLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bOk = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(62, 68);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(196, 182);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 7);
            label1.Name = "label1";
            label1.Size = new Size(481, 40);
            label1.TabIndex = 1;
            label1.Text = "Première Version du Projet de la TomCorp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 124);
            label2.Name = "label2";
            label2.Size = new Size(185, 26);
            label2.TabIndex = 2;
            label2.Text = "Version sous Alpha 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(342, 159);
            label3.Name = "label3";
            label3.Size = new Size(335, 40);
            label3.TabIndex = 3;
            label3.Text = " CopyRight TomCorp ©";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(147, 278);
            label4.Name = "label4";
            label4.Size = new Size(406, 26);
            label4.TabIndex = 4;
            label4.Text = "TomCorp — Imaginez. Connectez. Transformez.";
            // 
            // bOk
            // 
            bOk.BackColor = Color.RoyalBlue;
            bOk.Cursor = Cursors.Hand;
            bOk.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            bOk.FlatAppearance.BorderSize = 100;
            bOk.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            bOk.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bOk.Location = new Point(315, 374);
            bOk.Name = "bOk";
            bOk.Size = new Size(185, 66);
            bOk.TabIndex = 5;
            bOk.Text = "OK";
            bOk.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pbLogo);
            panel1.Location = new Point(44, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 356);
            panel1.TabIndex = 6;
            // 
            // FenetreAPropos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(bOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FenetreAPropos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FenetreAPropos";
            Load += FenetreAPropos_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bOk;
        private Panel panel1;
    }
}