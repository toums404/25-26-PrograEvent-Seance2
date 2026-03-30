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
    public partial class MonHistogramme : UserControl
    {
        public class HistoPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
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

        private List<HistoPoint> data = new List<HistoPoint>();

        
        public void SetData(List<HistoPoint> points)//injecte les données dans le contrôle
        {
            this.data = points;
            this.Invalidate(); // force le redessin à chaque nouvelle donnée
        }

        public MonHistogramme()
        {
            InitializeComponent();
            
            this.DoubleBuffered = true;//e  viter le clignotement lors du dessin
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

   
    float axeZeroEcran = rectHeight - (((float)(0 - MinY) / ecartY) * rectHeight);

    
    for (int i = 0; i < data.Count; i++)
    {
        // position X sur l'écran
        float screenX = ((float)(data[i].X - MinX) / ecartX) * rectWidth;
        
        // valeur Y sur l'écran
        float screenY = rectHeight - (((float)(data[i].Y - MinY) / ecartY) * rectHeight);

        
        float largeurBarre;
        if (i < data.Count - 1)
        {
            float nextX = ((float)(data[i + 1].X - MinX) / ecartX) * rectWidth;
            largeurBarre = nextX - screenX;
        }
        else
        {
            // pour le tout dernier point -> barre jusqu'au bord droit
            largeurBarre = rectWidth - screenX; 
        }

        
        float topY = Math.Min(screenY, axeZeroEcran);
        float hauteurBarre = Math.Abs(screenY - axeZeroEcran);

                //si hauteur =0 on affiche une barre de 1 pixel pour la rendre visible
                if (hauteurBarre < 1f) hauteurBarre = 1f;

        
        using (SolidBrush pinceau = new SolidBrush(Trait))
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