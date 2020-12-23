namespace UcakBiletSatis
{
    partial class BiletKoltukSecimi
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
            this.labelSeferBilgi = new System.Windows.Forms.Label();
            this.btnKoltukSecimTamamla = new System.Windows.Forms.Button();
            this.flowLayoutPanelKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelSeferBilgi
            // 
            this.labelSeferBilgi.AutoSize = true;
            this.labelSeferBilgi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSeferBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSeferBilgi.Location = new System.Drawing.Point(75, 19);
            this.labelSeferBilgi.Name = "labelSeferBilgi";
            this.labelSeferBilgi.Size = new System.Drawing.Size(627, 39);
            this.labelSeferBilgi.TabIndex = 137;
            this.labelSeferBilgi.Text = "21.10.2020 14:30 - İSTANBUL-İZMİR ";
            // 
            // btnKoltukSecimTamamla
            // 
            this.btnKoltukSecimTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoltukSecimTamamla.Location = new System.Drawing.Point(55, 607);
            this.btnKoltukSecimTamamla.Name = "btnKoltukSecimTamamla";
            this.btnKoltukSecimTamamla.Size = new System.Drawing.Size(673, 51);
            this.btnKoltukSecimTamamla.TabIndex = 163;
            this.btnKoltukSecimTamamla.Text = "KOLTUK SEÇİMİ TAMAMLA";
            this.btnKoltukSecimTamamla.UseVisualStyleBackColor = true;
            this.btnKoltukSecimTamamla.Click += new System.EventHandler(this.btnKoltukSecimTamamla_Click);
            // 
            // flowLayoutPanelKoltuklar
            // 
            this.flowLayoutPanelKoltuklar.Location = new System.Drawing.Point(45, 76);
            this.flowLayoutPanelKoltuklar.Name = "flowLayoutPanelKoltuklar";
            this.flowLayoutPanelKoltuklar.Size = new System.Drawing.Size(699, 513);
            this.flowLayoutPanelKoltuklar.TabIndex = 164;
            // 
            // BiletKoltukSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 679);
            this.Controls.Add(this.flowLayoutPanelKoltuklar);
            this.Controls.Add(this.btnKoltukSecimTamamla);
            this.Controls.Add(this.labelSeferBilgi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BiletKoltukSecimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet Koltuk Secimi";
            this.Load += new System.EventHandler(this.BiletKoltukSecimi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSeferBilgi;
        private System.Windows.Forms.Button btnKoltukSecimTamamla;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKoltuklar;
    }
}