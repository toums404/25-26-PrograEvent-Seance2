namespace _25_26_PrograEvent_Seance2
{
    public partial class Form1 : Form
    {
        public Form1()
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
            AffichageEnConstruction(sender, e);
        }

        private void MiBarreProg_Click(object sender, EventArgs e)
        {
            FenetreProgression form3 = new FenetreProgression();
            form3.ShowDialog();
        }

        private void MiEditeur_Click(object sender, EventArgs e)
        {
            AffichageEnConstruction(sender, e);
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
    }//test
}
