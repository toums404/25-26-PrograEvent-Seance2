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
    public partial class FenetreSouris : Form
    {
        private int nbGauche = 0;
        private int nbDroit = 0;
        public FenetreSouris()
        {
            InitializeComponent();
            
            this.KeyDown += new KeyEventHandler(FenetreSouris_KeyDown);

            pSouris.MouseMove += new MouseEventHandler(pSouris_MouseMove);
            pSouris.MouseClick += new MouseEventHandler(pSouris_MouseClick);
            pSouris.Paint += new PaintEventHandler(pSouris_Paint);

            bRAZ.Click += new EventHandler(bRAZ_Click);
            AfficherClic();
        }
        private void AfficherClic()
        {
            tbGauche.Text = nbGauche.ToString();
            tbDroit.Text = nbDroit.ToString();
        }
        private void bRAZ_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;

            AfficherClic();
            tbX.Text = "";
            tbY.Text = "";

            lbClavier.Items.Clear();
        }
        private void FenetreSouris_KeyDown(object sender, KeyEventArgs e)
        {
            lbClavier.Items.Add(e.KeyCode.ToString());
            lbClavier.TopIndex = lbClavier.Items.Count - 1; // scroll automatique vers le bas

        }
        private void pSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbX.Text = e.X.ToString();
            tbY.Text = e.Y.ToString();
        }
        private void pSouris_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                nbGauche++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                nbDroit++;
            }
            AfficherClic();

            int largeurCase = pSouris.Width / 3;
            int hauteurCase = pSouris.Height / 3;

            int col = Math.Min(e.X / largeurCase + 1, 3); // +1 pour passer de 0-2 à 1-3
            int ligne = Math.Min(e.Y / hauteurCase + 1, 3); 

            string typeClic = e.Button == MouseButtons.Left ? "Gauche" : "Droit";
            lbClavier.Items.Add($"{typeClic} : Case ({ligne}, {col})");
            lbClavier.TopIndex = lbClavier.Items.Count - 1; 

        }
        private void pSouris_Paint(object sender, PaintEventArgs e)
        {
            int largeurCase = pSouris.Width / 3;
            int hauteurCase = pSouris.Height / 3;
            for (int i = 1; i < 3; i++)
            {
                //lignes verticales
                e.Graphics.DrawLine(Pens.Black, i * largeurCase, 0, i * largeurCase, pSouris.Height);
                //lignes horizontales
                e.Graphics.DrawLine(Pens.Black, 0, i * hauteurCase, pSouris.Width, i * hauteurCase);
            }
        }
    }
}
