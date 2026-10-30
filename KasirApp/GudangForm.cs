using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KasirApp
{
    public partial class GudangForm : Form
    {
        private string connectionString = "Data Source=ANDRE-R\\SQLEXPRESS01;Initial Catalog=Pelatihan_Desktop;Integrated Security=True;TrustServerCertificate=True";

        public GudangForm()
        {
            InitializeComponent();
        }

        private void GudangForm_Load(object sender, EventArgs e)
        {
            LoadDataBarang();
        }

        private void LoadDataBarang(string kodeBarang = "", string namaBarang = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT kode_barang, nama_barang, brand, type_produk, jumlah, " +
                                   "CONVERT(varchar, expired_date, 23) AS expired_date, " +
                                   "harga_beli, margin, harga_jual, " +
                                   "CONVERT(varchar, created_at, 120) AS created_at " +
                                   "FROM barang WHERE 1=1";

                    if (!string.IsNullOrEmpty(kodeBarang))
                    {
                        query += $" AND kode_barang LIKE '%{kodeBarang}%'";
                    }

                    if (!string.IsNullOrEmpty(namaBarang))
                    {
                        query += $" AND nama_barang LIKE '%{namaBarang}%'";
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvDaftarBarang.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string kodeBarang = txtKodeBarang.Text.Trim();
            string namaBarang = txtNamaBarang.Text.Trim();
            LoadDataBarang(kodeBarang, namaBarang);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahBarang tambahBarang = new TambahBarang();
            tambahBarang.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void txtKodeBarang_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNamaBarang_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            LoadDataBarang();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDaftarBarang.CurrentRow != null)
            {
                string kodeBarang = dgvDaftarBarang.CurrentRow.Cells["kode_barang"].Value.ToString();

                DialogResult result = MessageBox.Show($"Apakah yakin ingin menghapus barang dengan kode: {kodeBarang}?",
                                                      "Konfirmasi Hapus",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = $"DELETE FROM barang WHERE kode_barang = '{kodeBarang}'";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDataBarang();
                                }
                                else
                                {
                                    MessageBox.Show("Data gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih dulu data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDaftarBarang.CurrentRow != null)
            {
                string kodeBarang = dgvDaftarBarang.CurrentRow.Cells["kode_barang"].Value?.ToString();
                if (!string.IsNullOrEmpty(kodeBarang))
                {
                    TambahBarang editBarang = new TambahBarang();
                    editBarang.KodeBarangUntukEdit = kodeBarang;
                    editBarang.Show();
                }
                else
                {
                    MessageBox.Show("Kode barang tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Pilih dulu data yang ingin diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
