namespace _25_26_PrograEvent_Seance2
{
    partial class EcranListe
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
            lFichier = new Label();
            lNom = new Label();
            lQualite = new Label();
            gbDetail = new GroupBox();
            cbQualite = new ComboBox();
            tbNom = new TextBox();
            bConfirmer = new Button();
            bAnnuler = new Button();
            bOuvrir = new Button();
            bEnregistrer = new Button();
            bAjouter = new Button();
            bSupprimer = new Button();
            lbPersonne = new ListBox();
            ofdOuvrir = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            bModifier = new Button();
            gbDetail.SuspendLayout();
            SuspendLayout();
            // 
            // lFichier
            // 
            lFichier.AutoSize = true;
            lFichier.Location = new Point(23, 25);
            lFichier.Name = "lFichier";
            lFichier.Size = new Size(130, 25);
            lFichier.TabIndex = 0;
            lFichier.Text = "Nom du fichier";
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(27, 110);
            lNom.Name = "lNom";
            lNom.Size = new Size(52, 25);
            lNom.TabIndex = 1;
            lNom.Text = "Nom";
            // 
            // lQualite
            // 
            lQualite.AutoSize = true;
            lQualite.Location = new Point(27, 27);
            lQualite.Name = "lQualite";
            lQualite.Size = new Size(68, 25);
            lQualite.TabIndex = 2;
            lQualite.Text = "Qualité";
            // 
            // gbDetail
            // 
            gbDetail.BackColor = Color.LightGray;
            gbDetail.Controls.Add(cbQualite);
            gbDetail.Controls.Add(tbNom);
            gbDetail.Controls.Add(lQualite);
            gbDetail.Controls.Add(lNom);
            gbDetail.Controls.Add(bConfirmer);
            gbDetail.Controls.Add(bAnnuler);
            gbDetail.Location = new Point(173, 219);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(310, 242);
            gbDetail.TabIndex = 3;
            gbDetail.TabStop = false;
            gbDetail.Text = "Détail de la personne ";
            // 
            // cbQualite
            // 
            cbQualite.FormattingEnabled = true;
            cbQualite.Items.AddRange(new object[] { "Madame", "Mademoiselle", "Monsieur", "Mondamoiseau", "Indéfini " });
            cbQualite.Location = new Point(27, 56);
            cbQualite.Name = "cbQualite";
            cbQualite.Size = new Size(258, 33);
            cbQualite.TabIndex = 10;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(27, 138);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(258, 31);
            tbNom.TabIndex = 10;
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(27, 187);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(112, 38);
            bConfirmer.TabIndex = 4;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = true;
            bConfirmer.Click += bConfirmer_Click;
            // 
            // bAnnuler
            // 
            bAnnuler.Location = new Point(173, 187);
            bAnnuler.Name = "bAnnuler";
            bAnnuler.Size = new Size(112, 38);
            bAnnuler.TabIndex = 5;
            bAnnuler.Text = "Annuler";
            bAnnuler.UseVisualStyleBackColor = true;
            bAnnuler.Click += bAnnuler_Click;
            // 
            // bOuvrir
            // 
            bOuvrir.Location = new Point(23, 219);
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(112, 39);
            bOuvrir.TabIndex = 6;
            bOuvrir.Text = "Ouvrir";
            bOuvrir.UseVisualStyleBackColor = true;
            bOuvrir.Click += bOuvrir_Click;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(23, 264);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(112, 39);
            bEnregistrer.TabIndex = 7;
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.UseVisualStyleBackColor = true;
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(23, 332);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(112, 39);
            bAjouter.TabIndex = 8;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(23, 377);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(112, 39);
            bSupprimer.TabIndex = 9;
            bSupprimer.Text = "Supprimer";
            bSupprimer.UseVisualStyleBackColor = true;
            bSupprimer.Click += bSupprimer_Click;
            // 
            // lbPersonne
            // 
            lbPersonne.FormattingEnabled = true;
            lbPersonne.ItemHeight = 25;
            lbPersonne.Location = new Point(23, 53);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(460, 129);
            lbPersonne.TabIndex = 10;
            lbPersonne.DoubleClick += lbPersonne_DoubleClick;
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "openFileDialog1";
            // 
            // bModifier
            // 
            bModifier.Location = new Point(23, 422);
            bModifier.Name = "bModifier";
            bModifier.Size = new Size(112, 39);
            bModifier.TabIndex = 11;
            bModifier.Text = "Modifier";
            bModifier.UseVisualStyleBackColor = true;
            bModifier.Click += bModifier_Click;
            // 
            // EcranListe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 478);
            Controls.Add(bModifier);
            Controls.Add(lbPersonne);
            Controls.Add(bSupprimer);
            Controls.Add(bAjouter);
            Controls.Add(bEnregistrer);
            Controls.Add(bOuvrir);
            Controls.Add(gbDetail);
            Controls.Add(lFichier);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EcranListe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcranListe";
            Load += EcranListe_Load;
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lFichier;
        private Label lNom;
        private Label lQualite;
        private GroupBox gbDetail;
        private Button bConfirmer;
        private Button bAnnuler;
        private Button bOuvrir;
        private Button bEnregistrer;
        private Button bAjouter;
        private Button bSupprimer;
        private ComboBox cbQualite;
        private TextBox tbNom;
        private ListBox lbPersonne;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdEnregistrer;
        private Button bModifier;
    }
}