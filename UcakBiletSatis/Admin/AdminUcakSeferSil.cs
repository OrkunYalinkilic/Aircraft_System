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
    public partial class AdminUcakSeferSil : Form
    {
        UcakSefer aktifUcakSefer = new UcakSefer();
        public AdminUcakSeferSil()
        {
            InitializeComponent();
        }

        private void AdminUcakSeferSil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbUcakBiletSatisDataSet.UcakSefer' table. You can move, or remove it, as needed.
            this.ucakSeferTableAdapter.Fill(this.dbUcakBiletSatisDataSet.UcakSefer);

        }

        private void dataGridViewSeferSil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            secilenIndex = dataGridViewSeferSil.SelectedCells[0].RowIndex;
          
            aktifUcakSefer.UcakNeredenYer = dataGridViewSeferSil.Rows[secilenIndex].Cells[0].Value.ToString();
            aktifUcakSefer.UcakNereyeYer = dataGridViewSeferSil.Rows[secilenIndex].Cells[1].Value.ToString();
            aktifUcakSefer.UcakKalkisSaat = dataGridViewSeferSil.Rows[secilenIndex].Cells[2].Value.ToString();
            aktifUcakSefer.UcakVarisSaat = dataGridViewSeferSil.Rows[secilenIndex].Cells[3].Value.ToString();
            aktifUcakSefer.UcakKalkisTarih = dataGridViewSeferSil.Rows[secilenIndex].Cells[4].Value.ToString();
            aktifUcakSefer.UcakSeferUcret = int.Parse(dataGridViewSeferSil.Rows[secilenIndex].Cells[5].Value.ToString());

            AdminSeferSilOnay frm = new AdminSeferSilOnay(aktifUcakSefer);
            frm.ShowDialog();
       
        }

        private void dataGridViewSeferSil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
