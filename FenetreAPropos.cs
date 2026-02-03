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
    public partial class FenetreAPropos : Form
    {
        public FenetreAPropos()
        {
            InitializeComponent();
            string cheminCur = Path.Combine(Application.StartupPath, "Ressources", "LogoTomCorp.cur");
            if (File.Exists(cheminCur))
            {
                Cursor curseurPerso = new Cursor(cheminCur);
                panel1.Cursor = curseurPerso;
            }
            else
            {
                MessageBox.Show("Le fichier de curseur personnalisé est introuvable. Le curseur par défaut sera utilisé.", "Fichier introuvable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FenetreAPropos_Load(object sender, EventArgs e)
        {

        }
    }
}
