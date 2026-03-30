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

            
            public override string ToString()// surcharge ToString affichage propre dans la ListBox
            {
                return $"Point(X: {X:000}, Y: {Y,4})";
            }
        }

        private List<MonPoint> alData = new List<MonPoint>();
        private Random rnd = new Random();

        public FenetreHistogramme()
        {
            InitializeComponent();
            // panel redessine tout si redimensionné
            pDessin.Resize += (s, e) => pDessin.Invalidate();
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
                lbMonPoint.Items.Add(nouveauPoint);
            }
        }

        private void bDessiner_Click(object sender, EventArgs e)
        {
            pDessin.Invalidate();//maj du panel pour déclencher le Paint et dessiner les barres

            //preparation de la liste de points pour le contrôle utilisateur
            List<HistoPoint> copiePourComposant = new List<HistoPoint>();

            foreach (MonPoint pointOriginal in alData)
            {
                HistoPoint nouveauPoint = new HistoPoint();
                nouveauPoint.X = pointOriginal.X;
                nouveauPoint.Y = pointOriginal.Y;

                copiePourComposant.Add(nouveauPoint);
            }

            if (HistoPerso != null)//envoi de la liste au controle utiilsateur
            {
                HistoPerso.SetData(copiePourComposant);
            }
        }
        private void pDessin_Paint(object sender, PaintEventArgs e)
        {
            if (alData.Count < 2) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //recherche des valeurs extremes pour les axes X et Y
            int minX = alData.First().X;
            int maxX = alData.Last().X;
            int minY = alData.Min(p => p.Y);
            int maxY = alData.Max(p => p.Y);

            if (maxX == minX) maxX++;
            if (maxY == minY) maxY++;

            float rectWidth = pDessin.ClientRectangle.Width;
            float rectHeight = pDessin.ClientRectangle.Height;

            //calcul de la position de l'axe Y=0 sur l'écran
            float axeZeroEcran = rectHeight - (((float)(0 - minY) / (maxY - minY)) * rectHeight);

            for (int i = 0; i < alData.Count; i++)
            {
                float screenX = ((float)(alData[i].X - minX) / (maxX - minX)) * rectWidth;
                float screenY = rectHeight - (((float)(alData[i].Y - minY) / (maxY - minY)) * rectHeight);
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

                
                float topY = Math.Min(screenY, axeZeroEcran);
                float hauteurBarre = Math.Abs(screenY - axeZeroEcran);
                if (hauteurBarre < 1f) hauteurBarre = 1f;

                
                using (SolidBrush pinceau = new SolidBrush(Color.Navy))
                {
                    g.FillRectangle(pinceau, screenX, topY, largeurBarre, hauteurBarre);
                }

               
                using (Pen bordure = new Pen(Color.Black, 1f))
                {
                    g.DrawRectangle(bordure, screenX, topY, largeurBarre, hauteurBarre);
                }
            }
        }
    }
}
