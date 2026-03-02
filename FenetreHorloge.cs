using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26_PrograEvent_Seance2
{
    public partial class FenetreHorloge : Form
    {
        public FenetreHorloge()
        {
            timerHorloge = new System.Windows.Forms.Timer();
            InitializeComponent();
            this.DoubleBuffered = true; //pour pas que ca scintille
            timerHorloge.Interval = 1000;
            timerHorloge.Tick += timerHorloge_Tick;
            timerHorloge.Start();

        }

        private void FenetreHorloge_Load(object sender, EventArgs e)
        {

        }

        private void timerHorloge_Tick(object sender, EventArgs e)
        {
            DateTime heureActuelle = DateTime.Now;
            this.Text = $"Horloge - {heureActuelle:HH:mm:ss}";
            this.Invalidate();
        }

        private void FenetreHorloge_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //determiner le centre de la fenêtre et le rayon maximum pour les aiguilles
            float cx = this.ClientSize.Width / 2f;
            float cy = this.ClientSize.Height / 2f;
            float rayonMax = Math.Min(cx, cy) - 20; // 20px de marge

            // cadran de l'horloge
            e.Graphics.DrawEllipse(Pens.White, cx - rayonMax, cy - rayonMax, rayonMax * 2, rayonMax * 2);

            DateTime t = DateTime.Now;

            // on retire Math.PI / 2 (90 degrés) pour démarrer à 12

            // angle des secondes
            double angleSecondes = (t.Second / 60.0) * 2 * Math.PI - (Math.PI / 2);

            // angle des minutes progressif avec % de secondes écoulées
            double angleMinutes = ((t.Minute + t.Second / 60.0) / 60.0) * 2 * Math.PI - (Math.PI / 2);

            // angle des heures comme minute 
            // on utilise t.Hour % 12 car le cadran fait 12 h et pas 24
            double angleHeures = (((t.Hour % 12) + t.Minute / 60.0) / 12.0) * 2 * Math.PI - (Math.PI / 2);

            //longueurs d'aiguilles
            float longueurSecondes = rayonMax * 0.9f;
            float longueurMinutes = rayonMax * 0.75f;
            float longueurHeures = rayonMax * 0.5f;

            // dessin des aiguilles
            DessinerAiguille(e.Graphics, cx, cy, angleHeures, longueurHeures, new Pen(Color.White, 6f));
            DessinerAiguille(e.Graphics, cx, cy, angleMinutes, longueurMinutes, new Pen(Color.Cyan, 4f));
            DessinerAiguille(e.Graphics, cx, cy, angleSecondes, longueurSecondes, new Pen(Color.Red, 2f));
        }

        private void DessinerAiguille(Graphics g, float cx, float cy, double angle, float longueur, Pen stylo)
        {
            // methode pour eviter de repeter le process pour chaque aiguille 
            float x = cx + (float)(longueur * Math.Cos(angle));
            float y = cy + (float)(longueur * Math.Sin(angle));

            //dessin du centre a la position calculée
            g.DrawLine(stylo, cx, cy, x, y);
        }
    }
}

