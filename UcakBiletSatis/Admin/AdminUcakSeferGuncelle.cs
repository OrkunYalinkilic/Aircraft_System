using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletSatis
{
    public partial class AdminUcakSeferGuncelle : Form
    {
        UcakSefer aktifUcakSefer = new UcakSefer();
        public AdminUcakSeferGuncelle()
        {
            InitializeComponent();
        }

        private void AdminUcakSeferGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbUcakBiletSatisDataSet2.UcakSefer' table. You can move, or remove it, as needed.
            this.ucakSeferTableAdapter1.Fill(this.dbUcakBiletSatisDataSet2.UcakSefer);
            // TODO: This line of code loads data into the 'dbUcakBiletSatisDataSet1.UcakSefer' table. You can move, or remove it, as needed.
            this.ucakSeferTableAdapter.Fill(this.dbUcakBiletSatisDataSet1.UcakSefer);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;

            aktifUcakSefer.UcakNeredenYer = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            aktifUcakSefer.UcakNereyeYer = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
            aktifUcakSefer.UcakKalkisSaat = dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString();
            aktifUcakSefer.UcakVarisSaat = dataGridView1.Rows[secilenIndex].Cells[3].Value.ToString();
            aktifUcakSefer.UcakKalkisTarih = dataGridView1.Rows[secilenIndex].Cells[4].Value.ToString();
            aktifUcakSefer.UcakSeferUcret = int.Parse(dataGridView1.Rows[secilenIndex].Cells[5].Value.ToString());

            AdminSeferGuncelleIslem frm = new AdminSeferGuncelleIslem(aktifUcakSefer);
            frm.ShowDialog();
           
        }
    }
}
