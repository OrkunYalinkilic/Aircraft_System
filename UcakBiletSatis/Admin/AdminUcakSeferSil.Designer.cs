namespace UcakBiletSatis
{
    partial class AdminUcakSeferSil
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
            this.dataGridViewSeferSil = new System.Windows.Forms.DataGridView();
            this.ucakNeredenYerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakNereyeYerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakKalkisSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakVarisSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakKalkisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakSeferUcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakSeferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbUcakBiletSatisDataSet = new UcakBiletSatis.DbUcakBiletSatisDataSet();
            this.ucakSeferTableAdapter = new UcakBiletSatis.DbUcakBiletSatisDataSetTableAdapters.UcakSeferTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeferSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakSeferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcakBiletSatisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSeferSil
            // 
            this.dataGridViewSeferSil.AutoGenerateColumns = false;
            this.dataGridViewSeferSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeferSil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ucakNeredenYerDataGridViewTextBoxColumn,
            this.ucakNereyeYerDataGridViewTextBoxColumn,
            this.ucakKalkisSaatDataGridViewTextBoxColumn,
            this.ucakVarisSaatDataGridViewTextBoxColumn,
            this.ucakKalkisTarihDataGridViewTextBoxColumn,
            this.ucakSeferUcretDataGridViewTextBoxColumn});
            this.dataGridViewSeferSil.DataSource = this.ucakSeferBindingSource;
            this.dataGridViewSeferSil.Location = new System.Drawing.Point(1, 2);
            this.dataGridViewSeferSil.Name = "dataGridViewSeferSil";
            this.dataGridViewSeferSil.RowHeadersWidth = 51;
            this.dataGridViewSeferSil.RowTemplate.Height = 24;
            this.dataGridViewSeferSil.Size = new System.Drawing.Size(1072, 386);
            this.dataGridViewSeferSil.TabIndex = 0;
            this.dataGridViewSeferSil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeferSil_CellClick);
            this.dataGridViewSeferSil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeferSil_CellContentClick);
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
            // ucakSeferBindingSource
            // 
            this.ucakSeferBindingSource.DataMember = "UcakSefer";
            this.ucakSeferBindingSource.DataSource = this.dbUcakBiletSatisDataSet;
            // 
            // dbUcakBiletSatisDataSet
            // 
            this.dbUcakBiletSatisDataSet.DataSetName = "DbUcakBiletSatisDataSet";
            this.dbUcakBiletSatisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucakSeferTableAdapter
            // 
            this.ucakSeferTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(315, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silmek istediğiniz sefere tıklayarak seçebilirsiniz";
            // 
            // AdminUcakSeferSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSeferSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminUcakSeferSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçak Sefer Sil (Admin)";
            this.Load += new System.EventHandler(this.AdminUcakSeferSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeferSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakSeferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUcakBiletSatisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSeferSil;
        private DbUcakBiletSatisDataSet dbUcakBiletSatisDataSet;
        private System.Windows.Forms.BindingSource ucakSeferBindingSource;
        private DbUcakBiletSatisDataSetTableAdapters.UcakSeferTableAdapter ucakSeferTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakNeredenYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakNereyeYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakKalkisSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakVarisSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakKalkisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakSeferUcretDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}