using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26_PrograEvent_Seance2
{

    public partial class FenetreHistogramme : Form
    {
        public class MonPoint
        {
            private int x;
            private int y;

            public int X { get { return x; } set { x = value; } }
            public int Y { get { return y; } set { y = value; } }

            public MonPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            // Surcharge de ToString pour un affichage propre dans la ListBox
            public override string ToString()
            {
                return $"Point(X: {X:000}, Y: {Y,4})";
            }
        }

        private List<MonPoint> alData = new List<MonPoint>();
        private Random rnd = new Random();

        public FenetreHistogramme()
        {
            InitializeComponent();
            // On s'assure que le Panel redessine tout s'il est redimensionné
            pDessin.Resize += (s, e) => pDessin.Invalidate();

            // On abonne l'événement Paint du Panel (à faire ici ou via le Concepteur)
            pDessin.Paint += pDessin_Paint;

        }

        private void FenetreHistogramme_Load(object sender, EventArgs e)
        {

        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            alData.Clear();
            lbMonPoint.Items.Clear();

            int nbPoints = rnd.Next(10, 50); // Un nombre aléatoire de points
            int currentX = 0;

            for (int i = 0; i < nbPoints; i++)
            {
                // X est généré de manière strictement croissante
                currentX += rnd.Next(1, 15);
                // Y varie entre -100 et 100
                int currentY = rnd.Next(-100, 101);

                MonPoint nouveauPoint = new MonPoint(currentX, currentY);
                alData.Add(nouveauPoint);

                // Ajout automatique dans la ListBox (qui utilisera ToString())
                lbMonPoint.Items.Add(nouveauPoint);
            }
        }

        private void bDessiner_Click(object sender, EventArgs e)
        {
            // Déclenche l'événement Paint du Panel
            pDessin.Invalidate();
        }
        private void pDessin_Paint(object sender, PaintEventArgs e)
        {
            if (alData.Count < 2) return; // Pas assez de points pour dessiner une ligne

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Pour un tracé lissé

            // On cherche les valeurs extrêmes pour adapter le dessin à la taille du Panel
            int minX = alData.First().X;
            int maxX = alData.Last().X;

            // Pour remplir *exactement* le panel, on prend les min/max réels des Y générés
            int minY = alData.Min(p => p.Y);
            int maxY = alData.Max(p => p.Y);

            // Sécurité anti-division par zéro
            if (maxX == minX) maxX++;
            if (maxY == minY) maxY++;

            float rectWidth = pDessin.ClientRectangle.Width;
            float rectHeight = pDessin.ClientRectangle.Height;

            // Tableau pour stocker les coordonnées converties pour l'écran
            PointF[] pointsEcran = new PointF[alData.Count];

            for (int i = 0; i < alData.Count; i++)
            {
                // Mise à l'échelle de X (Produit en croix)
                float screenX = ((float)(alData[i].X - minX) / (maxX - minX)) * rectWidth;

                // Mise à l'échelle de Y (Attention, l'axe Y de l'écran va vers le bas !)
                // On inverse donc la formule pour que les valeurs positives soient en haut
                float screenY = rectHeight - (((float)(alData[i].Y - minY) / (maxY - minY)) * rectHeight);

                pointsEcran[i] = new PointF(screenX, screenY);
            }

            // Dessin des lignes reliant les points
            using (Pen stylo = new Pen(Color.Navy, 2f))
            {
                g.DrawLines(stylo, pointsEcran);
            }
        }
    }
}
