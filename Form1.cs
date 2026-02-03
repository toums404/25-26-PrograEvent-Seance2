namespace _25_26_PrograEvent_Seance2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            AffichageEnConstruction(sender, e);
        }

        private void MiEditeur_Click(object sender, EventArgs e)
        {
            AffichageEnConstruction(sender, e);
        }

        private void MiQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
