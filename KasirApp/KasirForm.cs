using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KasirApp
{
    public partial class KasirForm : Form
    {
        private string connectionString = "Data Source=ANDRE-R\\SQLEXPRESS01;Initial Catalog=Pelatihan_Desktop;Integrated Security=True;TrustServerCertificate=True";

        private string cariKodeBarang = "";
        private string cariNamaBarang = "";
        private decimal cariHargaJual = 0;

        public KasirForm()
        {
            InitializeComponent();
            dgvKeranjang.Columns.Add("kode_barang", "Kode Barang");
            dgvKeranjang.Columns.Add("nama_barang", "Nama Barang");
            dgvKeranjang.Columns.Add("harga_jual", "Harga Jual");
        }

        private void KasirForm_Load(object sender, EventArgs e)
        {
            txtTotal.ReadOnly = true;
            txtTotalDisc.ReadOnly = true;
            txtHargaTotal.ReadOnly = true;
            txtKembalian.ReadOnly = true;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string kode = txtKodeBarang.Text.Trim().Replace("'", "''");
            string nama = txtNamaBarang.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(kode) && string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Masukkan kode barang atau nama barang!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query tanpa parameter, tapi tetap diatur prioritasnya
                    string query = $@"
                SELECT TOP 1 kode_barang, nama_barang, harga_jual 
                FROM barang 
                WHERE kode_barang = '{kode}'

                UNION ALL

                SELECT TOP 1 kode_barang, nama_barang, harga_jual 
                FROM barang 
                WHERE nama_barang LIKE '%{nama}%' AND kode_barang <> '{kode}'
            ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cariKodeBarang = reader["kode_barang"].ToString();
                            cariNamaBarang = reader["nama_barang"].ToString();
                            cariHargaJual = Convert.ToDecimal(reader["harga_jual"]);

                            MessageBox.Show($"Barang ditemukan: {cariNamaBarang} - Rp {cariHargaJual:N2}");
                        }
                        else
                        {
                            MessageBox.Show("Barang tidak ditemukan.");
                            cariKodeBarang = "";
                            cariNamaBarang = "";
                            cariHargaJual = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cariKodeBarang))
            {
                MessageBox.Show("Silakan cari barang terlebih dahulu!");
                return;
            }

            dgvKeranjang.Rows.Add(cariKodeBarang, cariNamaBarang, cariHargaJual);
            HitungTotal();

            cariKodeBarang = "";
            cariNamaBarang = "";
            cariHargaJual = 0;
        }

        private void HitungTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvKeranjang.Rows)
            {
                if (row.Cells["harga_jual"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["harga_jual"].Value);
                }
            }
            txtTotal.Text = total.ToString("N2");

            // Ambil diskon
            decimal disc = 0;
            decimal.TryParse(txtDisc.Text, out disc);
            txtTotalDisc.Text = disc.ToString("N2");

            // Hitung diskon
            decimal nilaiDiskon = total * (disc / 100);
            decimal subtotal = total - nilaiDiskon;

            // Hitung pajak
            decimal pajak = 0;
            if (chkPajak.Checked)
            {
                pajak += 11;
            }
            decimal pajakLain = 0;
            decimal.TryParse(txtPajakLainnya.Text, out pajakLain);
            pajak += pajakLain;
            lblPajakTotal.Text = pajak.ToString("N2") + "%";

            decimal nilaiPajak = subtotal * (pajak / 100);
            decimal hargaAkhir = subtotal + nilaiPajak;

            txtHargaTotal.Text = hargaAkhir.ToString("N2");

            HitungKembalian();
        }

        private void HitungKembalian()
        {
            decimal bayar = 0;
            decimal hargaTotal = 0;
            decimal.TryParse(txtbayar.Text, out bayar);
            decimal.TryParse(txtHargaTotal.Text, out hargaTotal);
            decimal kembalian = bayar - hargaTotal;
            txtKembalian.Text = kembalian.ToString("N2");
        }

        private void txtDisc_TextChanged(object sender, EventArgs e)
        {
        }

        private void chkPajak_CheckedChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void txtPajakLainnya_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            HitungKembalian();
        }

        private void txtKodeBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalDisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "select ";
            }
        }
        private void dgvKeranjang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKeranjang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris yang ingin dihapus!");
                return;
            }

            foreach (DataGridViewRow row in dgvKeranjang.SelectedRows)
            {
                dgvKeranjang.Rows.Remove(row);
            }

            HitungTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang kosong!");
                return;
            }

            string kodeTransaksi = "TRX" + DateTime.Now.ToString("yyyyMMddHHmmss");
            int kasirId = 1; 
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvKeranjang.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string kodeBarang = row.Cells["kode_barang"].Value?.ToString();
                        decimal hargaJual = Convert.ToDecimal(row.Cells["harga_jual"].Value);

                        string queryGetId = $"SELECT id FROM barang WHERE kode_barang = '{kodeBarang}'";
                        int barangId = 0;
                        using (SqlCommand cmdGetId = new SqlCommand(queryGetId, conn))
                        {
                            object result = cmdGetId.ExecuteScalar();
                            if (result != null)
                            {
                                barangId = Convert.ToInt32(result);
                            }
                            else
                            {
                                MessageBox.Show($"Barang {kodeBarang} tidak ditemukan.");
                                continue;
                            }
                        }

                        string queryInsert = $@"
                        INSERT INTO kasir (kode_transaksi, kasir_id, barang_id, jumlah, total_harga)
                        VALUES ('{kodeTransaksi}', {kasirId}, {barangId}, 1, {hargaJual})";

                        using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn))
                        {
                            cmdInsert.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"Transaksi {kodeTransaksi} berhasil disimpan!");
                    dgvKeranjang.Rows.Clear();
                    HitungTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}