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
using System.Runtime.InteropServices;

namespace _25_26_PrograEvent_Seance2
{
    public partial class EcranListe : Form
    {
        public EcranListe()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int smLire = 0x0199;
        private const int smEcrire = 0x019A;

        private string NomFichier = "";
        private int IndexSelectionne = -1;
        private int compteurEncodage = 1;
        private List<int> encodages = new List<int>();



        private void EcranListe_Load(object sender, EventArgs e)
        {
            Activer(true);
        }
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
                int index = lbPersonne.SelectedIndex;
                lbPersonne.Items.RemoveAt(index);
                encodages.RemoveAt(index);
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
                encodages.Add(compteurEncodage);
                // Stocker l'encodage via SendMessage (numéro de création)
                SendMessage(lbPersonne.Handle, smEcrire, lbPersonne.Items.Count - 1, compteurEncodage);
                compteurEncodage++;
            }

            TrierListe();
            Activer(true);
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                NomFichier = ofdOuvrir.FileName;
                lbPersonne.Items.Clear();
                encodages.Clear();
                compteurEncodage = 1;

                foreach (string ligne in File.ReadAllLines(NomFichier))
                {
                    lbPersonne.Items.Add(ligne);
                    encodages.Add(compteurEncodage);
                    compteurEncodage++;
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
                //int encodage = SendMessage(lbPersonne.Handle, smLire, lbPersonne.SelectedIndex, 0);
                int index = lbPersonne.SelectedIndex +1;
                int encodage = encodages[lbPersonne.SelectedIndex];
                MessageBox.Show(
                    "Index :" + index +
                    "\nValeur :" + lbPersonne.SelectedItem.ToString() +
                    "\nEncodage :" + encodage
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
        private void TrierListe() 
        {
            //var liste = lbPersonne.Items.Cast<string>().OrderBy(x => x).ToList();

            //lbPersonne.Items.Clear();
            //lbPersonne.Items.AddRange(liste.ToArray());
            var combine = lbPersonne.Items.Cast<string>()
        .Select((text, i) => new { Text = text, Enc = encodages[i] })
        .OrderBy(x => x.Text)
        .ToList();

            lbPersonne.Items.Clear();
            encodages.Clear();

            foreach (var item in combine)
            {
                lbPersonne.Items.Add(item.Text);
                encodages.Add(item.Enc); // garde l'encodage d'origine
            }
        }

    }
}

