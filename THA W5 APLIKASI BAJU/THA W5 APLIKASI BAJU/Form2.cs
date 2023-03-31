using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_APLIKASI_BAJU
{
    public partial class Form2 : Form
    {
        int c = 0;
        string indexdgvkat = "";
        int angkatertinggikat = 0;
        DataTable dtproduksimpan = new DataTable();
        DataTable dtkategori = new DataTable();
        DataTable dtfilter = new DataTable();
        DataTable dttampil = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dtproduksimpan.Columns.Add("ID Product");
            dtproduksimpan.Columns.Add("Nama Product");
            dtproduksimpan.Columns.Add("Harga");
            dtproduksimpan.Columns.Add("StoK");
            dtproduksimpan.Columns.Add("ID Category");
            dtproduksimpan.Rows.Add("J001", "Jas Hitam","100000" ,"10", "C1");
            dtproduksimpan.Rows.Add("T001", "T-Shirt Black Pin", "70000", "20", "C2");
            dtproduksimpan.Rows.Add("T002", "T-Shirt Obsessive", "75000", "10", "C2");
            dtproduksimpan.Rows.Add("R001", "Rok Mini", "70000", "20", "C3");
            dtproduksimpan.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtproduksimpan.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtproduksimpan.Rows.Add("C002", "CD Kewren", "1000000", "1", "C5");
            dtproduksimpan.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");
            dgvmain.DataSource = dtproduksimpan;

            dtkategori.Columns.Add("ID Kategori");
            dtkategori.Columns.Add("Nama Product");
            dtkategori.Rows.Add("C1", "Jas");
            dtkategori.Rows.Add("C2", "T-Shirt");
            dtkategori.Rows.Add("C3", "Rok");
            dtkategori.Rows.Add("C4", "Celana");
            dtkategori.Rows.Add("C5", "Cawat");
            c = 5;
            dgvkategori.DataSource = dtkategori;

            comboboxkategori.DataSource = dtkategori;
            comboboxkategori.DisplayMember = "Nama Product";
            comboboxkategori.ValueMember = "ID Kategori";

            ////////////////////////////////////////////////////////////

            dtfilter.Columns.Add("ID Product");
            dtfilter.Columns.Add("Nama Product");
            dtfilter.Columns.Add("Harga");
            dtfilter.Columns.Add("StoK");
            dtfilter.Columns.Add("ID Category");
            dgvfilter.DataSource = dtfilter;
            dgvfilter.Visible = false;

            comboboxfilter.DataSource = dtkategori;
            comboboxfilter.ValueMember = "ID Kategori";
            comboboxfilter.DisplayMember = "Nama Product";
        }

        private void comboboxfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtfilter.Rows.Clear();
            info.Text = "Jml jenis produk : "+dtproduksimpan.Rows.Count.ToString();
            if (comboboxfilter.Enabled == true)
            {
                for (int i = 0; i < dtproduksimpan.Rows.Count; i++)
                {
                    if (dtproduksimpan.Rows[i][4].ToString() == comboboxfilter.SelectedValue.ToString())
                    {
                        dtfilter.Rows.Add(dtproduksimpan.Rows[i][0], dtproduksimpan.Rows[i][1], dtproduksimpan.Rows[i][2], dtproduksimpan.Rows[i][3], dtproduksimpan.Rows[i][4]);
                    }
                }
            }
        }
        public void updatedgv()
        {
            for (int i = 0; i < dtproduksimpan.Rows.Count; i++)
            {
                if (dtproduksimpan.Rows[i][4].ToString() == comboboxkategori.SelectedValue.ToString())
                {
                    dtfilter.Rows.Add(dtproduksimpan.Rows[i][0], dtproduksimpan.Rows[i][1], dtproduksimpan.Rows[i][2], dtproduksimpan.Rows[i][3], dtproduksimpan.Rows[i][4]);
                }
            }
        }
        private void btnfilter_Click(object sender, EventArgs e)
        {
            comboboxfilter.Enabled = true;
            dgvfilter.Visible = true;
            dtfilter.Columns.Clear();
            dtfilter.Rows.Clear();
            dtfilter.Columns.Add("ID Product");
            dtfilter.Columns.Add("Nama Product");
            dtfilter.Columns.Add("Harga");
            dtfilter.Columns.Add("StoK");
            dtfilter.Columns.Add("ID Category");
            dgvfilter.DataSource = dtfilter;
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            comboboxfilter.Enabled = false;
            dgvfilter.Visible = false;
            dgvfilter.Enabled = false;
            dtfilter.Columns.Clear();
            dtfilter.Rows.Clear();
        }

        private void btnaddkategori_Click(object sender, EventArgs e)
        {
            int h = 0;
            angkatertinggikat = 0;
            foreach(DataRow row in dtkategori.Rows)
            {
                if (int.Parse(row[0].ToString().Substring(1)) >= angkatertinggikat)
                {
                    angkatertinggikat = int.Parse(row[0].ToString().Substring(1));
                }
            }
            if(txtboxnamabaru.Text != "")
            {
                foreach (DataRow row in dtkategori.Rows)
                {
                    if (row[1].ToString() == txtboxnamabaru.Text)
                    {
                        MessageBox.Show("SALAH SUDAH ADA NAMA YG SAMA");
                        h++;
                    }
                }
                if (h == 0)
                {
                    dtkategori.Rows.Add("C" +  (angkatertinggikat+1) , txtboxnamabaru.Text);
                }
            }
            else
            {
                MessageBox.Show("Etlis isi dlu lah boss");
            }
        }
        private void btnremovekategori_Click(object sender, EventArgs e)
        {
            foreach(DataRow row in dtkategori.Rows)
            {
                if(row[0].ToString() == indexdgvkat)
                {
                    dtkategori.Rows.Remove(row);
                    break;
                }
            }
            for(int i = dtproduksimpan.Rows.Count-1; i>=0; i--)
            {
                if (dtproduksimpan.Rows[i][4].ToString() == indexdgvkat)
                {
                    dtproduksimpan.Rows.Remove(dtproduksimpan.Rows[i]);
                }
            }
        }

        private void comboboxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboboxkategori_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void dgvkategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvkategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexdgvkat = dtkategori.Rows[e.RowIndex][0].ToString();
           // indexdgvkat = dgvkategori.SelectedCells[0].Value.ToString();
        }

        private void comboboxfilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboboxfilter_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            double b = 0;
            int formatlama = 0;
            string format = "";
            string code = "";
            if (txtnama.Text == "" || txtharga.Text =="" || txtstok.Text == "" || comboboxkategori.Text == "")
            {
                MessageBox.Show("Pastikan anda sudah mengisi semua data barang terlebih dahulu");
            }
            else
            {
                bool samename = false;
                for (int i = 0; i < dtproduksimpan.Rows.Count; i++) // generated id
                {
                    if (dtproduksimpan.Rows[i][1].ToString().Equals(txtnama.Text))
                    {
                        samename = true;
                    }
                }
                if(samename == true)
                {
                    MessageBox.Show("Anda sudah memiliki nama produk yang sama :p");
                }
                else
                {
                    string a = txtnama.Text.Substring(0, 1); // 0,1 HURUF DPN
                    for (int i = 0; i < dtproduksimpan.Rows.Count; i++) // generated id
                    {
                        if (dtproduksimpan.Rows[i][0].ToString().Contains(a.ToUpper()))
                        {
                            if (Convert.ToDouble(dtproduksimpan.Rows[i][0].ToString().Substring(1)) >= b)
                            {
                                b = Convert.ToDouble(dtproduksimpan.Rows[i][0].ToString().Substring(1));
                            }
                        }
                        code = comboboxkategori.SelectedValue.ToString();
                    }
                    //MessageBox.Show(a.ToUpper() + format + (b + 1));
                    formatlama = Convert.ToInt32(b + 1);
                    format = formatlama.ToString("D3");
                    dtproduksimpan.Rows.Add((a.ToUpper() + format), txtnama.Text, txtharga.Text, txtstok.Text, code);
                    if (comboboxfilter.Enabled == true) // realtime view di filter
                    {
                        dtfilter.Rows.Clear();
                        for (int i = 0; i < dtproduksimpan.Rows.Count; i++)
                        {
                            if (dtproduksimpan.Rows[i][4].ToString() == comboboxfilter.SelectedValue.ToString())
                            {
                                dtfilter.Rows.Add(dtproduksimpan.Rows[i][0], dtproduksimpan.Rows[i][1], dtproduksimpan.Rows[i][2], dtproduksimpan.Rows[i][3], dtproduksimpan.Rows[i][4]);
                            }
                        }
                    }
                }
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if(dtproduksimpan.Rows.Count>0)
            {
                dgvmain.Rows.RemoveAt(this.dgvmain.SelectedRows[0].Index);
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dtproduksimpan.Rows)
            {
                if (row[0].ToString() == dgvmain.SelectedCells[0].Value.ToString())
                {
                    if (Convert.ToInt32(txtstok.Text) <= 0)
                    {
                        dgvmain.Rows.RemoveAt(this.dgvmain.SelectedRows[0].Index);
                        break;
                    }
                    else
                    {
                        row[1] = txtnama.Text;
                        row[2] = txtharga.Text;
                        row[3] = txtstok.Text;
                        row[4] = comboboxkategori.SelectedValue.ToString();
                    }
                }
            }
        }
        private void dgvmain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvfilter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvmain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnama.Text = dgvmain.SelectedCells[1].Value.ToString();
            txtharga.Text = dgvmain.SelectedCells[2].Value.ToString();
            txtstok.Text = dgvmain.SelectedCells[3].Value.ToString();
            foreach(DataRow row in dtkategori.Rows)
            {
                if (row[0].ToString() == dgvmain.SelectedCells[4].Value.ToString())
                {
                    comboboxkategori.Text = row[1].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnama.Text = "";
            txtharga.Text = "";
            txtstok.Text = "";
            comboboxkategori.Text = "";
        }

        private void txtstok_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        int gbr = 0;
        private void gambar_Click(object sender, EventArgs e)
        {
            gbr++;
            if (gbr%2== 0 )
            {
                lisa.Visible = false;
                jiso.Visible = true;
            }
            else
            {
                lisa.Visible = true;
                jiso.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
