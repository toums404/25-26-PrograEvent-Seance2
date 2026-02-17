using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26_PrograEvent_Seance2
{
    public partial class FenetreEditeur : Form
    {
        string sFichier;
        bool bModifier;
        public FenetreEditeur()
        {
            InitializeComponent();
        }

        private void FenetreEditeur_Load(object sender, EventArgs e)
        {
            sFichier = string.Empty;
            bModifier = false;
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }
        private void FichierEnregistrer()
        {
            if (string.IsNullOrEmpty(sFichier))
            {
                if (ofdSave.ShowDialog() == DialogResult.OK)
                {
                    sFichier = ofdSave.FileName;
                }
                else
                {
                    return;
                }
            }
            rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.RichText);
            bModifier = false;
        }
        private bool VerifierSauver()
        {
            if (!bModifier)
            {
                return true;
            }
            DialogResult dr = MessageBox.Show("Voulez-vous enregistrer les modifications ?", "Enregistrer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FichierEnregistrer();
                return true;
            }
            else if (dr == DialogResult.No)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Nouveau_Click()
        {
            if (!VerifierSauver())
            {
                return;
            }
            rtbTexte.Clear();
            sFichier = string.Empty;
            bModifier = false;
        }
        private void Ouvrir_Click()
        {
            if (!VerifierSauver())
            {
                return;
            }
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                sFichier = ofdOpen.FileName;
                rtbTexte.LoadFile(sFichier, RichTextBoxStreamType.RichText);
                bModifier = false;
            }
        }
        private void Enregistrer_Click()
        {
            FichierEnregistrer();
        }
        private void Quitter_Click()
        {
            if (!VerifierSauver())
            {
                return;
            }
            this.Close();
        }
        private void CombinaisonStyle(FontStyle style)
        {
            if (rtbTexte.SelectionFont == null)
            {
                return;
            }
            Font courante = rtbTexte.SelectionFont;
            FontStyle nouveauStyle;

            if (courante.Style.HasFlag(style))
            {
                nouveauStyle = courante.Style & ~style;//retire le style
            }
            else
            {
                nouveauStyle = courante.Style | style;//ajoute le style
            }
            rtbTexte.SelectionFont = new Font(courante, nouveauStyle);
            //https://learn.microsoft.com/fr-fr/dotnet/api/system.windows.forms.richtextbox.selectionfont?view=windowsdesktop-10.0

        }

        private void MiCopier_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy();
        }

        private void MiCouper_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut();
        }

        private void MiColler_Click(object sender, EventArgs e)
        {
            rtbTexte.Paste();
        }

        private void gaucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void droiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void MiPolice_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbTexte.SelectionFont = fontDialog1.Font;
            }
        }

        private void Mi2Gras_Click(object sender, EventArgs e)
        {
            CombinaisonStyle(FontStyle.Bold);
        }

        private void Mi2Italique_Click(object sender, EventArgs e)
        {
            CombinaisonStyle(FontStyle.Italic);
        }

        private void Mi2Souligne_Click(object sender, EventArgs e)
        {
            CombinaisonStyle(FontStyle.Underline);
        }

        private void Mi2Barre_Click(object sender, EventArgs e)
        {
            CombinaisonStyle(FontStyle.Strikeout);
        }

        private void MiNouveau_Click(object sender, EventArgs e)
        {
            Nouveau_Click();
        }

        private void pbNouveau_Click(object sender, EventArgs e)
        {
            Nouveau_Click();
        }

        private void MiOuvrir_Click(object sender, EventArgs e)
        {
            Ouvrir_Click();
        }

        private void pbOuvrir_Click(object sender, EventArgs e)
        {
            Ouvrir_Click();
        }

        private void MiEnregistrer_Click(object sender, EventArgs e)
        {
            Enregistrer_Click();
        }

        private void pbEnregistrer_Click(object sender, EventArgs e)
        {
            Enregistrer_Click();
        }

        private void MiQuitter_Click(object sender, EventArgs e)
        {
            Quitter_Click();
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            Quitter_Click();
        }
    }
}
