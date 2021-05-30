

namespace UcakBiletSatis
{
    partial class AdminSeferListele
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucakNeredenYerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakNereyeYerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakKalkisSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakVarisSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakKalkisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakSeferUcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakSeferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbUcakBiletSatisDataSet3 = new UcakBiletSatis.DbUcakBiletSatisDataSet3();
            this.ucakSeferTableAdapter = new UcakBiletSatis.DbUcakBiletSatisDataSet3TableAdapters.UcakSeferTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakSeferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcakBiletSatisDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ucakNeredenYerDataGridViewTextBoxColumn,
            this.ucakNereyeYerDataGridViewTextBoxColumn,
            this.ucakKalkisSaatDataGridViewTextBoxColumn,
            this.ucakVarisSaatDataGridViewTextBoxColumn,
            this.ucakKalkisTarihDataGridViewTextBoxColumn,
            this.ucakSeferUcretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ucakSeferBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // ucakNeredenYerDataGridViewTextBoxColumn
            // 
            this.ucakNeredenYerDataGridViewTextBoxColumn.DataPropertyName = "UcakNeredenYer";
            this.ucakNeredenYerDataGridViewTextBoxColumn.HeaderText = "Hareket Yeri";
            this.ucakNeredenYerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucakNeredenYerDataGridViewTextBoxColumn.Name = "ucakNeredenYerDataGridViewTextBoxColumn";
            this.ucakNeredenYerDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucakNereyeYerDataGridViewTextBoxColumn
            // 
            this.ucakNereyeYerDataGridViewTextBoxColumn.DataPropertyName = "UcakNereyeYer";
            this.ucakNereyeYerDataGridViewTextBoxColumn.HeaderText = "Varış Yeri";
            this.ucakNereyeYerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucakNereyeYerDataGridViewTextBoxColumn.Name = "ucakNereyeYerDataGridViewTextBoxColumn";
            this.ucakNereyeYerDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucakKalkisSaatDataGridViewTextBoxColumn
            // 
            this.ucakKalkisSaatDataGridViewTextBoxColumn.DataPropertyName = "UcakKalkisSaat";
            this.ucakKalkisSaatDataGridViewTextBoxColumn.HeaderText = "Kalkış Saati";
            this.ucakKalkisSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucakKalkisSaatDataGridViewTextBoxColumn.Name = "ucakKalkisSaatDataGridViewTextBoxColumn";
            this.ucakKalkisSaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucakVarisSaatDataGridViewTextBoxColumn
            // 
            this.ucakVarisSaatDataGridViewTextBoxColumn.DataPropertyName = "UcakVarisSaat";
            this.ucakVarisSaatDataGridViewTextBoxColumn.HeaderText = "Varış Saati";
            this.ucakVarisSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucakVarisSaatDataGridViewTextBoxColumn.Name = "ucakVarisSaatDataGridViewTextBoxColumn";
            this.ucakVarisSaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucakKalkisTarihDataGridViewTextBoxColumn
            // 
            this.ucakKalkisTarihDataGridViewTextBoxColumn.DataPropertyName = "UcakKalkisTarih";
            this.ucakKalkisTarihDataGridViewTextBoxColumn.HeaderText = "Kalkış Saati";
            this.ucakKalkisTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucakKalkisTarihDataGridViewTextBoxColumn.Name = "ucakKalkisTarihDataGridViewTextBoxColumn";
            this.ucakKalkisTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucakSeferUcretDataGridViewTextBoxColumn
            // 
            this.ucakSeferUcretDataGridViewTextBoxColumn.DataPropertyName = "UcakSeferUcret";
            this.ucakSeferUcretDataGridViewTextBoxColumn.HeaderText = "Bilet Fiyatı";
            this.ucakSeferUcretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucakSeferUcretDataGridViewTextBoxColumn.Name = "ucakSeferUcretDataGridViewTextBoxColumn";
            this.ucakSeferUcretDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucakSeferBindingSource
            // 
            this.ucakSeferBindingSource.DataMember = "UcakSefer";
            this.ucakSeferBindingSource.DataSource = this.dbUcakBiletSatisDataSet3;
            // 
            // dbUcakBiletSatisDataSet3
            // 
            this.dbUcakBiletSatisDataSet3.DataSetName = "DbUcakBiletSatisDataSet3";
            this.dbUcakBiletSatisDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucakSeferTableAdapter
            // 
            this.ucakSeferTableAdapter.ClearBeforeFill = true;
            // 
            // AdminSeferListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 333);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminSeferListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçak Sefer Listesi (Admin)";
            this.Load += new System.EventHandler(this.AdminSeferListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakSeferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcakBiletSatisDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbUcakBiletSatisDataSet3 dbUcakBiletSatisDataSet3;
        private System.Windows.Forms.BindingSource ucakSeferBindingSource;
        private DbUcakBiletSatisDataSet3TableAdapters.UcakSeferTableAdapter ucakSeferTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakNeredenYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakNereyeYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakKalkisSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakVarisSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakKalkisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakSeferUcretDataGridViewTextBoxColumn;
    }
}