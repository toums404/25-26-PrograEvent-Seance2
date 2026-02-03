namespace _25_26_PrograEvent_Seance2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            contrôlesToolStripMenuItem = new ToolStripMenuItem();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            barreDeProgressionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            editeurToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { contrôlesToolStripMenuItem, applicationsToolStripMenuItem, aideToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contrôlesToolStripMenuItem
            // 
            contrôlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeToolStripMenuItem, barreDeProgressionToolStripMenuItem, toolStripSeparator1, quitterToolStripMenuItem });
            contrôlesToolStripMenuItem.Name = "contrôlesToolStripMenuItem";
            contrôlesToolStripMenuItem.Size = new Size(104, 29);
            contrôlesToolStripMenuItem.Text = "Contrôles";
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editeurToolStripMenuItem });
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(126, 29);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(64, 29);
            aideToolStripMenuItem.Text = "Aide";
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(279, 34);
            listeToolStripMenuItem.Text = "Liste";
            // 
            // barreDeProgressionToolStripMenuItem
            // 
            barreDeProgressionToolStripMenuItem.Name = "barreDeProgressionToolStripMenuItem";
            barreDeProgressionToolStripMenuItem.Size = new Size(279, 34);
            barreDeProgressionToolStripMenuItem.Text = "Barre de progression";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(276, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(279, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            // 
            // editeurToolStripMenuItem
            // 
            editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            editeurToolStripMenuItem.Size = new Size(270, 34);
            editeurToolStripMenuItem.Text = "Editeur";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(270, 34);
            aProposToolStripMenuItem.Text = "A Propos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contrôlesToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem barreDeProgressionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem editeurToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
    }
}
