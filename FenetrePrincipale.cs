namespace _25_26_PrograEvent_Seance2
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
            /*string cheminCur = Path.Combine(Application.StartupPath, "Ressources", "LogoTomCorp.cur");
            if (File.Exists(cheminCur))
            {
                Cursor curseurPerso = new Cursor(cheminCur);
                this.Cursor = curseurPerso;
            }
            else
            {
                MessageBox.Show("Le fichier de curseur personnalisé est introuvable. Le curseur par défaut sera utilisé.", "Fichier introuvable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AffichageEnConstruction(object sender, EventArgs e)
        {
            MessageBox.Show("Cette partie est en construction merci de revenir plus tard");
        }

        private void MiListe_Click(object sender, EventArgs e)
        {
            EcranListe form4 = new EcranListe();
            form4.ShowDialog();
        }

        private void MiBarreProg_Click(object sender, EventArgs e)
        {
            FenetreProgression form3 = new FenetreProgression();
            form3.ShowDialog();
        }

        private void MiEditeur_Click(object sender, EventArgs e)
        {
            FenetreEditeur form5 = new FenetreEditeur();
            form5.ShowDialog();
        }

        private void MiQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiApropos_Click(object sender, EventArgs e)
        {
            FenetreAPropos form2 = new FenetreAPropos();
            form2.ShowDialog();
        }

        private void MiMalware_Click(object sender, EventArgs e)
        {
            FenetreMalware fenetreMalware = new FenetreMalware();
            fenetreMalware.ShowDialog();
        }

        private void MiSpirographe_Click(object sender, EventArgs e)
        {
            FenetreSpirographe fenetreSpirographe = new FenetreSpirographe();
            fenetreSpirographe.ShowDialog();
        }

        private void MiHorloge_Click(object sender, EventArgs e)
        {
            FenetreHorloge fenetreHorloge = new FenetreHorloge();
            fenetreHorloge.ShowDialog();
        }

        private void clavierEtSourisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenetreSouris fenetreSouris = new FenetreSouris();
            fenetreSouris.ShowDialog();
        }

        private void explorateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenetreExplorateur fenetreExplorateur = new FenetreExplorateur();
            fenetreExplorateur.ShowDialog();
        }

        private void baseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenetreBDD fenetreBDD = new FenetreBDD();
            fenetreBDD.ShowDialog();
        }
    }
}
