namespace _25_26_PrograEvent_Seance2
{
    partial class FenetreHorloge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreHorloge));
            timerHorloge = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timerHorloge
            // 
            timerHorloge.Tick += timerHorloge_Tick;
            // 
            // FenetreHorloge
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FenetreHorloge";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Horloge";
            Load += FenetreHorloge_Load;
            Paint += FenetreHorloge_Paint;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerHorloge;
    }
}