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
    public partial class FenetreIntegration : Form
    {
        public delegate double fctAIntegrer(double x);//type de delegate pour les fonctions a integrer
        public FenetreIntegration()
        {
            InitializeComponent();
        }

        private double ATrapeze(double a, double b, double largeur)
        {
            return ((a + b) / 2.0) * largeur;
        }
        private void bPolynome_Click(object sender, EventArgs e)
        {
            calcul("POLYNOME");
        }
        private void bTrigonometrique_Click(object sender, EventArgs e)
        {
            calcul("TRIGONOMETRIQUE");
        }
        private void calcul(string typeFonction)
        {
            if (!double.TryParse(tbGauche.Text, out double xGauche) ||
                !double.TryParse(tbDroite.Text, out double xDroit) ||
                !int.TryParse(tbNbInt.Text, out int nBase) || nBase < 1)
            {
                MessageBox.Show("veuillez entrer des valeurs numériques plus grande ou egales a 1.");
                return;
            }
            lbResultats.Items.Clear();
            lbResultats.Items.Add($"--- Méthode Tradi : {typeFonction} ---");

            for (int mult = 1; mult <= 16; mult *= 2)
            {
                int n = nBase * mult;
                double largeurIntervalle = (xDroit - xGauche) / n;
                double aireTotale = 0;

                // 2) Boucle qui parcourt les trapèzes
                for (int i = 0; i < n; i++)
                {
                    double x1 = xGauche + (i * largeurIntervalle);
                    double x2 = xGauche + ((i + 1) * largeurIntervalle);

                    double y1 = 0, y2 = 0;

                    // Calcul "en dur" selon le bouton cliqué
                    if (typeFonction == "POLYNOME")
                    {
                        y1 = (x1 * x1) + (2 * x1); // Exemple : x^2 + 2x
                        y2 = (x2 * x2) + (2 * x2);
                    }
                    else if (typeFonction == "TRIGONOMETRIQUE")
                    {
                        y1 = Math.Sin(x1); // Exemple : sin(x)
                        y2 = Math.Sin(x2);
                    }

                    aireTotale += ATrapeze(y1, y2, largeurIntervalle);
                }

                lbResultats.Items.Add($"Intervalles: {n} | Résultat: {aireTotale:F4}");
            }
        }

        // methode delegate
        private double IntegrationTrapeze(fctAIntegrer f, double xGauche, double xDroit, int nInterval)//fctAIntegrer f veut dire que f est une fonction qui prend un double en parametre et retourne un double
        {
            double largeurIntervalle = (xDroit - xGauche) / nInterval;
            double aireTotale = 0;

            for (int i = 0; i < nInterval; i++)
            {
                double x1 = xGauche + (i * largeurIntervalle);
                double x2 = xGauche + ((i + 1) * largeurIntervalle);

                aireTotale += ATrapeze(f(x1), f(x2), largeurIntervalle);//f(x1) et f(x2) permettent d'appeler la fonction passée en parametre pour calculer les y1 et y2 de manière générique
            }

            return aireTotale;
        }
        private double FonctionPolynome(double x)
        {
            return (x * x) + (2 * x);
        }
        private double FonctionTrigo(double x)
        {
            return Math.Sin(x);
        }
        private void bPointeurPolynome_Click(object sender, EventArgs e)
        {
            CalculerAvecDelegate("Polynôme (Delegate)", FonctionPolynome);
        }
        private void bPointeurTrigonometrique_Click(object sender, EventArgs e)
        {
            CalculerAvecDelegate("Trigo (Delegate)", FonctionTrigo);
        }
        private void CalculerAvecDelegate(string nomAffichage, fctAIntegrer fonction)
        {
            if (!double.TryParse(tbGauche.Text, out double xGauche) ||
                !double.TryParse(tbDroite.Text, out double xDroit) ||
                !int.TryParse(tbNbInt.Text, out int nBase) || nBase < 1)
            {
                MessageBox.Show("Veuillez entrer des valeurs valides.");
                return;
            }

            lbResultats.Items.Clear();
            lbResultats.Items.Add($"--- Méthode Delegate : {nomAffichage} ---");

            for (int mult = 1; mult <= 16; mult *= 2)
            {
                int n = nBase * mult;
                double resultat = IntegrationTrapeze(fonction, xGauche, xDroit, n);

                lbResultats.Items.Add($"Intervalles: {n} | Résultat: {resultat:F4}");
            }
        }
    }
}
