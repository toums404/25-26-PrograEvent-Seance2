using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _25_26_PrograEvent_Seance2
{
    public partial class FenetreExplorateur : Form
    {
        public FenetreExplorateur()
        {
            InitializeComponent();
        }

        private void FenetreExplorateur_Load(object sender, EventArgs e)
        {
            lvFichier.View = View.Details;
            tvRepertoire.ImageList = ilTreeView;
            lvFichier.LargeImageList = ilGrand;
            lvFichier.SmallImageList = ilPetit;
            tvRepertoire.BeforeExpand += tvRepertoire_BeforeExpand;
            RemplirTreeView();
        }

        private void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear();
            TreeNode racine = new TreeNode("Poste de travail");
            //servira de point de départ pour afficher les disques durs et les dossiers
            racine.Tag = "RACINE";
            racine.ImageIndex = 0;
            racine.SelectedImageIndex = 0;

            tvRepertoire.Nodes.Add(racine);

            LireDisques(racine);
            racine.Expand();
        }
        private void LireDisques(TreeNode noeudParent)
        {
            string[] disques = Environment.GetLogicalDrives();//demande a windows les disques branchés

            foreach (string disque in disques)//pour chaque disque on crée un noeud
            {
                TreeNode noeudDisque = new TreeNode(disque);
                noeudDisque.Tag = disque;
                noeudDisque.ImageIndex = 1;
                noeudDisque.SelectedImageIndex = 1;
                TreeNode noeudFictif = new TreeNode("...");
                noeudFictif.Tag = "*DUMMY*";//force windows a croire que ce noeud a des enfants pour afficher le "+" à côté du lecteur
                noeudDisque.Nodes.Add(noeudFictif);

                noeudParent.Nodes.Add(noeudDisque);
            }
        }
        private void LireRepertoires(TreeNode noeudParent)
        {
            string cheminParent = noeudParent.Tag.ToString();

            try
            {
                if (Directory.Exists(cheminParent))
                {
                    string[] repertoires = Directory.GetDirectories(cheminParent);//demande a windows les dossiers présents dans le dossier sélectionné
                    foreach (string rep in repertoires)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(rep);
                        TreeNode noeudEnfant = new TreeNode(dirInfo.Name);
                        noeudEnfant.Tag = dirInfo.FullName;
                        noeudEnfant.ImageIndex = 2;
                        noeudEnfant.SelectedImageIndex = 2;

                        // ajout du nœud fictif pour permettre l'expansion future de CE sous-dossier
                        TreeNode noeudFictif = new TreeNode("...");
                        noeudFictif.Tag = "*DUMMY*";
                        noeudEnfant.Nodes.Add(noeudFictif);

                        noeudParent.Nodes.Add(noeudEnfant);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                // dossier protégé alors erreur
            }
            catch (Exception ex)
            {
                slMessage.Text = "Erreur de lecture : " + ex.Message;
            }
        }
        private void tvRepertoire_BeforeExpand(object sender, TreeViewCancelEventArgs e)//ia
        {
            //methode lazy loading : on ne charge les sous-dossiers que lorsque l'utilisateur clique pour déployer un nœud, et pas avant, accélere l'app
            if (e.Node.Tag != null && e.Node.Tag.ToString() == "RACINE")
                return;

            // verif si le nœud contient notre nœud fictif
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Tag?.ToString() == "*DUMMY*")
            {
                //retire le nœud fictif
                e.Node.Nodes.Clear();

                //charge les vrais répertoires pour ce nœud
                LireRepertoires(e.Node);
            }
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // On vérifie si on a cliqué sur "Poste de travail"
            if (e.Node.Tag != null && e.Node.Tag.ToString() == "RACINE")
            {
                lvFichier.Items.Clear();
                slMessage.Text = "Sélectionnez un lecteur ou un dossier.";
                return;
            }

            string cheminSelectionne = e.Node.Tag.ToString();
            LireFichiers(cheminSelectionne);
        }
        private void LireFichiers(string chemin)
        {
            lvFichier.Items.Clear();

            try
            {
                string[] fichiers = Directory.GetFiles(chemin);//recupere les fichiers du dossier sélectionné

                foreach (string fichier in fichiers)
                {
                    FileInfo info = new FileInfo(fichier);//donne des infos sur le fichier (taille, date de création, etc)
                    ListViewItem item = new ListViewItem(NomFichier(fichier));
                    item.ImageIndex = 0;
                    long tailleKo = info.Length / 1024;
                    item.SubItems.Add(tailleKo.ToString() + " Ko");
                    item.SubItems.Add(info.CreationTime.ToString("dd/MM/yyyy HH:mm"));
                    item.SubItems.Add(info.LastWriteTime.ToString("dd/MM/yyyy HH:mm"));

                    lvFichier.Items.Add(item);
                }

                slMessage.Text = $"{fichiers.Length} fichier(s) trouvé(s).";
            }
            catch (UnauthorizedAccessException)
            {
                slMessage.Text = "Accès refusé à ce dossier.";
            }

        }
        private string NomFichier(string cheminFichier)
        {
            return Path.GetFileName(cheminFichier);//garde que le nom et l'extension du fichier, pas le chemin complet
        }

        private void tsaPetitesIcones_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.SmallIcon;

        }

        private void tsaGrandesIcones_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.LargeIcon;
        }

        private void tsaListe_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.List;
        }

        private void tsaDetail_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.Details;
        }

        private void tsbQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
