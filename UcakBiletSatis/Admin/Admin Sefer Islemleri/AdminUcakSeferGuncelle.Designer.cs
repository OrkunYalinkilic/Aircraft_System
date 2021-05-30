
namespace UcakBiletSatis
{
    partial class AdminUcakSeferGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.dbUcakBiletSatisDataSet1 = new UcakBiletSatis.DbUcakBiletSatisDataSet1();
            this.ucakSeferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucakSeferTableAdapter = new UcakBiletSatis.DbUcakBiletSatisDataSet1TableAdapters.UcakSeferTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucakNeredenYerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakNereyeYerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakKalkisSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakVarisSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakKalkisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakSeferUcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakSeferBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbUcakBiletSatisDataSet2 = new UcakBiletSatis.DbUcakBiletSatisDataSet2();
            this.ucakSeferTableAdapter1 = new UcakBiletSatis.DbUcakBiletSatisDataSet2TableAdapters.UcakSeferTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcakBiletSatisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakSeferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakSeferBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcakBiletSatisDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(285, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Güncellemek istediğiniz sefere tıklayarak seçebilirsiniz";
            // 
            // dbUcakBiletSatisDataSet1
            // 
            this.dbUcakBiletSatisDataSet1.DataSetName = "DbUcakBiletSatisDataSet1";
            this.dbUcakBiletSatisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucakSeferBindingSource
            // 
            this.ucakSeferBindingSource.DataMember = "UcakSefer";
            this.ucakSeferBindingSource.DataSource = this.dbUcakBiletSatisDataSet1;
            // 
            // ucakSeferTableAdapter
            // 
            this.ucakSeferTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.ucakSeferBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 329);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.ucakKalkisTarihDataGridViewTextBoxColumn.HeaderText = "Kalkış Tarihi";
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
            // ucakSeferBindingSource1
            // 
            this.ucakSeferBindingSource1.DataMember = "UcakSefer";
            this.ucakSeferBindingSource1.DataSource = this.dbUcakBiletSatisDataSet2;
            // 
            // dbUcakBiletSatisDataSet2
            // 
            this.dbUcakBiletSatisDataSet2.DataSetName = "DbUcakBiletSatisDataSet2";
            this.dbUcakBiletSatisDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucakSeferTableAdapter1
            // 
            this.ucakSeferTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminUcakSeferGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminUcakSeferGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçak Sefer Güncelle Seçim (Admin)";
            this.Load += new System.EventHandler(this.AdminUcakSeferGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbUcakBiletSatisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakSeferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakSeferBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcakBiletSatisDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms .Label label1;
        private DbUcakBiletSatisDataSet1 dbUcakBiletSatisDataSet1;
        private System.Windows.Forms.BindingSource ucakSeferBindingSource;
        private DbUcakBiletSatisDataSet1TableAdapters.UcakSeferTableAdapter ucakSeferTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbUcakBiletSatisDataSet2 dbUcakBiletSatisDataSet2;
        private System.Windows.Forms.BindingSource ucakSeferBindingSource1;
        private DbUcakBiletSatisDataSet2TableAdapters.UcakSeferTableAdapter ucakSeferTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakNeredenYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakNereyeYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakKalkisSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakVarisSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakKalkisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakSeferUcretDataGridViewTextBoxColumn;
    }
}