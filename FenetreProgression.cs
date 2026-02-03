namespace _25_26_PrograEvent_Seance2
{
    public partial class FenetreProgression : Form
    {
        public FenetreProgression()
        {
            InitializeComponent();

            ProgBPrincipale.Minimum = 0;
            ProgBPrincipale.Maximum = 10;
            ProgBPrincipale.Value = 0;

            ProgBSecondaire.Minimum = 0;
            ProgBSecondaire.Maximum = 10;
            ProgBSecondaire.Value = 0;

            timer1.Interval = 500; // Intervalle de 500 ms
            timer1.Tick += timer1_Tick;
        }

        private void FenetreProgression_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgBSecondaire.Value++;
            if (ProgBSecondaire.Value >= ProgBSecondaire.Maximum)
            {
                ProgBSecondaire.Value = ProgBSecondaire.Minimum;
                ProgBPrincipale.Value++;
            }
            if (ProgBPrincipale.Value >= ProgBPrincipale.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Traitement terminé !");
                this.Close();
            }
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void bReprendre_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
    }
}
