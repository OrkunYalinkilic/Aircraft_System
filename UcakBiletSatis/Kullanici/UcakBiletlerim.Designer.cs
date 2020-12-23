namespace UcakBiletSatis
{
    partial class UcakBiletlerim
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
            this.flowLayoutPanelBiletlerim = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBiletlerim
            // 
            this.flowLayoutPanelBiletlerim.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelBiletlerim.Name = "flowLayoutPanelBiletlerim";
            this.flowLayoutPanelBiletlerim.Size = new System.Drawing.Size(851, 426);
            this.flowLayoutPanelBiletlerim.TabIndex = 0;
            // 
            // UcakBiletlerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.flowLayoutPanelBiletlerim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UcakBiletlerim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçak Biletlerim";
            this.Load += new System.EventHandler(this.UcakBiletlerim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBiletlerim;
    }
}