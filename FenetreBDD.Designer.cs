namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreBDD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreBDD));
            lbConsole = new ListBox();
            panel1 = new Panel();
            lPrenom = new Label();
            lNom = new Label();
            tbNom = new TextBox();
            tbPrenom = new TextBox();
            bAjouter = new Button();
            bDenombrer = new Button();
            bConsulter = new Button();
            splitContainer1 = new SplitContainer();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lbConsole
            // 
            lbConsole.Dock = DockStyle.Fill;
            lbConsole.FormattingEnabled = true;
            lbConsole.ItemHeight = 25;
            lbConsole.Location = new Point(0, 0);
            lbConsole.Name = "lbConsole";
            lbConsole.Size = new Size(710, 572);
            lbConsole.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lPrenom);
            panel1.Controls.Add(lNom);
            panel1.Controls.Add(tbNom);
            panel1.Controls.Add(tbPrenom);
            panel1.Controls.Add(bAjouter);
            panel1.Controls.Add(bDenombrer);
            panel1.Controls.Add(bConsulter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 572);
            panel1.TabIndex = 8;
            // 
            // lPrenom
            // 
            lPrenom.AutoSize = true;
            lPrenom.Location = new Point(75, 300);
            lPrenom.Name = "lPrenom";
            lPrenom.Size = new Size(74, 25);
            lPrenom.TabIndex = 14;
            lPrenom.Text = "Prénom";
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(75, 213);
            lNom.Name = "lNom";
            lNom.Size = new Size(52, 25);
            lNom.TabIndex = 13;
            lNom.Text = "Nom";
            // 
            // tbNom
            // 
            tbNom.Location = new Point(75, 241);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(150, 31);
            tbNom.TabIndex = 12;
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(75, 328);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(150, 31);
            tbPrenom.TabIndex = 11;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(75, 396);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(150, 34);
            bAjouter.TabIndex = 10;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // bDenombrer
            // 
            bDenombrer.Location = new Point(75, 104);
            bDenombrer.Name = "bDenombrer";
            bDenombrer.Size = new Size(150, 34);
            bDenombrer.TabIndex = 9;
            bDenombrer.Text = "Dénombrer";
            bDenombrer.UseVisualStyleBackColor = true;
            bDenombrer.Click += bDenombrer_Click;
            // 
            // bConsulter
            // 
            bConsulter.Location = new Point(75, 20);
            bConsulter.Name = "bConsulter";
            bConsulter.Size = new Size(150, 34);
            bConsulter.TabIndex = 8;
            bConsulter.Text = "Consulter";
            bConsulter.UseVisualStyleBackColor = true;
            bConsulter.Click += bConsulter_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbConsole);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1029, 572);
            splitContainer1.SplitterDistance = 710;
            splitContainer1.TabIndex = 15;
            // 
            // FenetreBDD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 572);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FenetreBDD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Base de données";
            Load += FenetreBDD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbConsole;
        private Panel panel1;
        private Label lPrenom;
        private Label lNom;
        private TextBox tbNom;
        private TextBox tbPrenom;
        private Button bAjouter;
        private Button bDenombrer;
        private Button bConsulter;
        private SplitContainer splitContainer1;
    }
}