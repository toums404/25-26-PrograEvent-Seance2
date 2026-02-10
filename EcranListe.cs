using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26_PrograEvent_Seance2
{
    public partial class EcranListe : Form
    {
        public EcranListe()
        {
            InitializeComponent();
        }
        private void EcranListe_Load(object sender, EventArgs e)
        {
            Activer(true);
        }
        private string NomFichier = "";
        private int IndexSelectionne = -1;
        private void Activer(bool etat)
        {
            lbPersonne.Enabled = etat;
            bOuvrir.Enabled = etat;
            bEnregistrer.Enabled = etat;
            bAjouter.Enabled = etat;
            bSupprimer.Enabled = etat;

            gbDetail.Enabled = !etat;
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            tbNom.Clear();
            cbQualite.SelectedIndex = -1;
            IndexSelectionne = -1;
            Activer(false);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            IndexSelectionne = -1;
            Activer(true);
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)
            {
                lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex);
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            string item = tbNom.Text + "(" + cbQualite.Text + ")";
            if (IndexSelectionne >= 0)
            {
                lbPersonne.Items[IndexSelectionne] = item;
                IndexSelectionne = -1;
            }
            else
            { 
                lbPersonne.Items.Add(item);
            }
                
            Activer(true);
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                NomFichier = ofdOuvrir.FileName;
                lbPersonne.Items.Clear();

                foreach (string ligne in File.ReadAllLines(NomFichier))
                {
                    lbPersonne.Items.Add(ligne);
                }
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                NomFichier = sfdEnregistrer.FileName;

                List<string> lignes = new List<string>();
                foreach (var item in lbPersonne.Items)
                {
                    lignes.Add(item.ToString());
                }
                File.WriteAllLines(NomFichier, lignes);
            }
        }

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)
            {
                MessageBox.Show(
                    "Index :" + lbPersonne.SelectedIndex +
                    "\nValeur :" + lbPersonne.SelectedItem.ToString()
                    );
            }
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)
            {
                IndexSelectionne = lbPersonne.SelectedIndex;
                string item = lbPersonne.Items[IndexSelectionne].ToString();
                int position = item.IndexOf('(');
                if (position > 0)
                {
                    tbNom.Text = item.Substring(0, position);
                    cbQualite.Text = item.Substring(position + 1).Replace(")", "").Trim();
                }
                Activer(false);
                gbDetail.Enabled = true;
            }
        }
    }
}
