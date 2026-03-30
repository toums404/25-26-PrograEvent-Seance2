using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace _25_26_PrograEvent_Seance2
{
    // La classe miroir de MonPoint
    

    public partial class MonHistogramme : UserControl
    {
        public class HistoPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        // Les propriétés demandées dans l'énoncé
        [Category("Affichage")]
        public int MinX { get; set; } = 0;

        [Category("Affichage")]
        public int MaxX { get; set; } = 100;

        [Category("Affichage")]
        public int MinY { get; set; } = -100;

        [Category("Affichage")]
        public int MaxY { get; set; } = 100;

        [Category("Apparence")]
        public Color Trait { get; set; } = Color.Red;

        // La liste de données
        private List<HistoPoint> data = new List<HistoPoint>();

        // Méthode pour injecter les données dans le contrôle
        public void SetData(List<HistoPoint> points)
        {
            this.data = points;
            this.Invalidate(); // Force le redessin à chaque nouvelle donnée
        }

        public MonHistogramme()
        {
            InitializeComponent();
            // Important pour éviter le clignotement lors du dessin :
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
{
    base.OnPaint(e);

    if (data == null || data.Count == 0) return;

    Graphics g = e.Graphics;
    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

    float rectWidth = this.ClientRectangle.Width;
    float rectHeight = this.ClientRectangle.Height;

    float ecartX = (MaxX - MinX) == 0 ? 1 : (MaxX - MinX);
    float ecartY = (MaxY - MinY) == 0 ? 1 : (MaxY - MinY);

    // 1. Calcul de la position de l'axe Y=0 sur l'écran (la base de nos barres)
    float axeZeroEcran = rectHeight - (((float)(0 - MinY) / ecartY) * rectHeight);

    // 2. On parcourt chaque point pour dessiner son rectangle
    for (int i = 0; i < data.Count; i++)
    {
        // Position X sur l'écran
        float screenX = ((float)(data[i].X - MinX) / ecartX) * rectWidth;
        
        // Valeur Y sur l'écran
        float screenY = rectHeight - (((float)(data[i].Y - MinY) / ecartY) * rectHeight);

        // 3. Calcul de la largeur de la barre (jusqu'au point suivant)
        float largeurBarre;
        if (i < data.Count - 1)
        {
            float nextX = ((float)(data[i + 1].X - MinX) / ecartX) * rectWidth;
            largeurBarre = nextX - screenX;
        }
        else
        {
            // Pour le tout dernier point, on étire la barre jusqu'au bord droit
            largeurBarre = rectWidth - screenX; 
        }

        // 4. Calcul de la hauteur et du point de départ (Haut-Gauche)
        float topY = Math.Min(screenY, axeZeroEcran);
        float hauteurBarre = Math.Abs(screenY - axeZeroEcran);

        // Si la hauteur est nulle, on met un minimum de 1 pixel pour qu'elle soit visible
        if (hauteurBarre < 1f) hauteurBarre = 1f;

        // 5. Dessin du rectangle avec la couleur choisie
        using (SolidBrush pinceau = new SolidBrush(Trait))
        {
            g.FillRectangle(pinceau, screenX, topY, largeurBarre, hauteurBarre);
        }

        // Optionnel : On dessine une bordure noire autour de chaque barre pour bien les séparer
        using (Pen bordure = new Pen(Color.Black, 1f))
        {
            g.DrawRectangle(bordure, screenX, topY, largeurBarre, hauteurBarre);
        }
    }
}
    }
}