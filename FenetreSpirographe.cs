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
using static System.Net.Mime.MediaTypeNames;

namespace _25_26_PrograEvent_Seance2
{
    public partial class FenetreSpirographe : Form
    {
        private Color cFond;
        private Color cTrait;
        private GraphicsPath gpSauvegarde = null;
        private const int Marge = 302;//largeur du gb
        public FenetreSpirographe()
        {
            InitializeComponent();

            cFond = Color.Black;
            cTrait = Color.Cyan;
            gpSauvegarde = null;

            this.ResizeRedraw = true;
        }

        private void FenetreSpirographe_Load(object sender, EventArgs e)
        {

        }

        private void FenetreSpirographe_Paint(object sender, PaintEventArgs e)
        {
            // anticrénelage pour dessin plus lisse
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // dessin zone de tracé
            Rectangle zoneDessin = new Rectangle(new Point(Marge, 0),
                new Size(this.ClientSize.Width - Marge, this.ClientSize.Height));

            e.Graphics.FillRectangle(new SolidBrush(cFond), zoneDessin);

            
            if (gpSauvegarde != null)
            {
                e.Graphics.DrawPath(new Pen(cTrait, 1.5f), gpSauvegarde);
            }
        }

        private void bFond_Click(object sender, EventArgs e)
        {
            if (CdCouleur.ShowDialog() == DialogResult.OK)
            {
                cFond = CdCouleur.Color;
                this.Invalidate(new Rectangle(Marge, 0, this.ClientSize.Width - Marge, this.ClientSize.Height)); // Redessine la fenêtre pour appliquer la nouvelle couleur de fond
            }
        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            if (CdCouleur.ShowDialog() == DialogResult.OK)
            {
                cTrait = CdCouleur.Color;
                this.Invalidate(new Rectangle(Marge, 0, this.ClientSize.Width - Marge, this.ClientSize.Height));
            }
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            int largeurDessin = this.ClientSize.Width - Marge;
            int hauteurDessin = this.ClientSize.Height;
            int iSommets = TbSommet.Value;
            int iDensite = TbDensite.Value;
            int iProfondeur = TbProfondeur.Value;

            double[] sx = new double[iSommets + 1];
            double[] sy = new double[iSommets + 1];

            // centre du cercle et rayon
            double xc = Marge + (largeurDessin / 2.0);
            double yc = hauteurDessin / 2.0;
            // adaptation du rayon a la plus petite dimension pour pas deborder
            double rayon = Math.Min(largeurDessin, hauteurDessin) / 2.0 - 10;

            // protection contre division par zéro
            if (iDensite < 1) iDensite = 1;
            //sommets du polygone
            for (int i = 0; i <= iSommets; i++)
            {
                sx[i] = xc + rayon * Math.Cos(2 * Math.PI * i / iSommets);
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets);
            }

            // je ne comprenais pas comment continuer donc le code qui suit a ete fait par ia.
            gpSauvegarde = new GraphicsPath();
            double limiteDistance = rayon * (iProfondeur / 100.0);

            while (true)
            {
                // Création d'un tableau de PointF pour le tracé de l'itération actuelle
                PointF[] points = new PointF[iSommets + 1];
                for (int i = 0; i <= iSommets; i++)
                {
                    points[i] = new PointF((float)sx[i], (float)sy[i]);
                }

                // Ajout du polygone au chemin
                gpSauvegarde.AddLines(points);

                // Vérification de la condition d'arrêt (distance du centre au premier sommet)
                double distanceActuelle = Math.Sqrt(Math.Pow(sx[0] - xc, 2) + Math.Pow(sy[0] - yc, 2));
                if (distanceActuelle <= limiteDistance)
                {
                    break;
                }

                //Calcul des nouveaux sommets (rapprochement)
                for (int i = 0; i < iSommets; i++)
                {
                    sx[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    sy[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }

                // Fermeture du polygone pour la prochaine itération
                // Le dernier point doit être identique au premier
                sx[iSommets] = sx[0];
                sy[iSommets] = sy[0];
            }

            //Demander à la fenêtre de se redessiner
            this.Invalidate(new Rectangle(Marge, 0, largeurDessin, hauteurDessin));
        }
    }
}
