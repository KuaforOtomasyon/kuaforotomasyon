namespace KuaforOtomasyon.Formlar
{
    partial class Islemler
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
            DevExpress.XtraEditors.PanelControl MasaListePanel;
            MasaListePanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(MasaListePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // MasaListePanel
            // 
            MasaListePanel.Location = new System.Drawing.Point(12, 12);
            MasaListePanel.Name = "MasaListePanel";
            MasaListePanel.Size = new System.Drawing.Size(535, 388);
            MasaListePanel.TabIndex = 0;
            // 
            // Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 494);
            this.Controls.Add(MasaListePanel);
            this.Name = "Islemler";
            this.Text = "Islemler";
            this.Load += new System.EventHandler(this.IslemlerYuklemeOlay);
            ((System.ComponentModel.ISupportInitialize)(MasaListePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}