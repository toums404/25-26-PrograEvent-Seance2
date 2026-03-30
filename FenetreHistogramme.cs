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
using static _25_26_PrograEvent_Seance2.MonHistogramme;

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

            int nbPoints = 15;
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
            // 1. On met à jour le Panel classique (déclenche pDessin_Paint)
            pDessin.Invalidate();

            // 2. On prépare la "copie" des données pour le nouveau contrôle
            List<HistoPoint> copiePourComposant = new List<HistoPoint>();

            foreach (MonPoint pointOriginal in alData)
            {
                // On crée une copie exacte avec le type HistoPoint
                HistoPoint nouveauPoint = new HistoPoint();
                nouveauPoint.X = pointOriginal.X;
                nouveauPoint.Y = pointOriginal.Y;

                copiePourComposant.Add(nouveauPoint);
            }

            // 3. On envoie cette liste au contrôle utilisateur
            if (HistoPerso != null)
            {
                HistoPerso.SetData(copiePourComposant);
            }
        }
        private void pDessin_Paint(object sender, PaintEventArgs e)
        {
            if (alData.Count < 2) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // On cherche les valeurs extrêmes pour adapter le dessin à la taille du Panel
            int minX = alData.First().X;
            int maxX = alData.Last().X;
            int minY = alData.Min(p => p.Y);
            int maxY = alData.Max(p => p.Y);

            // Sécurité anti-division par zéro
            if (maxX == minX) maxX++;
            if (maxY == minY) maxY++;

            float rectWidth = pDessin.ClientRectangle.Width;
            float rectHeight = pDessin.ClientRectangle.Height;

            // 1. Calcul de l'axe Y=0 sur l'écran pour la base des barres
            float axeZeroEcran = rectHeight - (((float)(0 - minY) / (maxY - minY)) * rectHeight);

            for (int i = 0; i < alData.Count; i++)
            {
                // Position X et Y sur l'écran
                float screenX = ((float)(alData[i].X - minX) / (maxX - minX)) * rectWidth;
                float screenY = rectHeight - (((float)(alData[i].Y - minY) / (maxY - minY)) * rectHeight);

                // 2. Calcul de la largeur de la barre (avec l'ajustement pour la dernière)
                float largeurBarre;
                if (alData.Count == 1)
                {
                    largeurBarre = 20f;
                }
                else if (i < alData.Count - 1)
                {
                    float nextX = ((float)(alData[i + 1].X - minX) / (maxX - minX)) * rectWidth;
                    largeurBarre = nextX - screenX;
                }
                else
                {
                    float prevX = ((float)(alData[i - 1].X - minX) / (maxX - minX)) * rectWidth;
                    largeurBarre = screenX - prevX;
                    if (largeurBarre < 5f) largeurBarre = 5f;
                }

                // 3. Calcul de la hauteur et du point de départ Y
                float topY = Math.Min(screenY, axeZeroEcran);
                float hauteurBarre = Math.Abs(screenY - axeZeroEcran);
                if (hauteurBarre < 1f) hauteurBarre = 1f;

                // 4. Dessin du rectangle plein (Couleur au choix, ici Navy)
                using (SolidBrush pinceau = new SolidBrush(Color.Navy))
                {
                    g.FillRectangle(pinceau, screenX, topY, largeurBarre, hauteurBarre);
                }

                // 5. Bordure noire pour délimiter les barres
                using (Pen bordure = new Pen(Color.Black, 1f))
                {
                    g.DrawRectangle(bordure, screenX, topY, largeurBarre, hauteurBarre);
                }
            }
        }
    }
}
