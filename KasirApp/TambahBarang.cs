using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KasirApp
{
    public partial class TambahBarang : Form
    {
        private string connectionString = "Data Source=ANDRE-R\\SQLEXPRESS01;Initial Catalog=Pelatihan_Desktop;Integrated Security=True;TrustServerCertificate=True";
        public string KodeBarangUntukEdit { get; set; }

        public TambahBarang()
        {
            InitializeComponent();
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void TambahBarang_Load(object sender, EventArgs e)
        {
            LoadBrandList();
            LoadDataBarangUntukEdit();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string kodeBarang = tbKode.Text.Trim().Replace("'", "''");
            string namaBarang = tbNama.Text.Trim().Replace("'", "''");
            string brand = cmbBrand.Text.Trim().Replace("'", "''");
            string typeProduk = "";

            if (radioButton1.Checked)
                typeProduk = "Makanan";
            else if (radMinuman.Checked)
                typeProduk = "Minuman";
            else if (radCemilan.Checked)
                typeProduk = "Cemilan";

            typeProduk = typeProduk.Replace("'", "''");
            int jumlah = (int)nudJumlah.Value;
            string expiredDate = DtpExpireddate.Value.ToString("yyyy-MM-dd");
            string hargaBeli = string.IsNullOrEmpty(txtHargaBeli.Text) ? "0" : txtHargaBeli.Text;
            string margin = string.IsNullOrEmpty(txtMargin.Text) ? "0" : txtMargin.Text;
            string hargaJual = string.IsNullOrEmpty(txtHargaJual.Text) ? "0" : txtHargaJual.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string cekQuery = $"SELECT COUNT(*) FROM barang WHERE kode_barang = '{kodeBarang}'";
                    using (SqlCommand cekCmd = new SqlCommand(cekQuery, conn))
                    {
                        int count = (int)cekCmd.ExecuteScalar();
                        string query;
                        if (count > 0)
                        {
                            query = $@"
                                UPDATE barang SET
                                nama_barang = '{namaBarang}',
                                brand = '{brand}',
                                type_produk = '{typeProduk}',
                                jumlah = {jumlah},
                                expired_date = '{expiredDate}',
                                harga_beli = {hargaBeli},
                                margin = {margin},
                                harga_jual = {hargaJual}
                                WHERE kode_barang = '{kodeBarang}'";
                        }
                        else
                        {
                            query = $@"
                                INSERT INTO barang
                                (kode_barang, nama_barang, brand, type_produk, jumlah, expired_date, harga_beli, margin, harga_jual)
                                VALUES
                                ('{kodeBarang}', '{namaBarang}', '{brand}', '{typeProduk}', {jumlah}, '{expiredDate}', {hargaBeli}, {margin}, {hargaJual})";
                        }

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Data berhasil disimpan / diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm();
                                LoadBrandList();
                            }
                            else
                            {
                                MessageBox.Show("Data gagal disimpan / diupdate.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            tbKode.Text = "";
            tbNama.Text = "";
            cmbBrand.SelectedIndex = -1;
            cmbBrand.Text = "";
            radioButton1.Checked = false;
            radMinuman.Checked = false;
            radCemilan.Checked = false;
            nudJumlah.Value = 1;
            DtpExpireddate.Value = DateTime.Now;
            txtHargaBeli.Text = "";
            txtMargin.Text = "";
            txtHargaJual.Text = "";
        }

        private void LoadDataBarangUntukEdit()
        {
            if (string.IsNullOrEmpty(KodeBarangUntukEdit))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"SELECT kode_barang, nama_barang, brand, type_produk, jumlah, expired_date, harga_beli, margin, harga_jual FROM barang WHERE kode_barang = '{KodeBarangUntukEdit.Replace("'", "''")}'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbKode.Text = reader["kode_barang"].ToString();
                            tbNama.Text = reader["nama_barang"].ToString();
                            cmbBrand.Text = reader["brand"].ToString();
                            string typeProduk = reader["type_produk"].ToString();
                            if (typeProduk == "Makanan")
                                radioButton1.Checked = true;
                            else if (typeProduk == "Minuman")
                                radMinuman.Checked = true;
                            else if (typeProduk == "Cemilan")
                                radCemilan.Checked = true;
                            nudJumlah.Value = Convert.ToDecimal(reader["jumlah"]);
                            DtpExpireddate.Value = Convert.ToDateTime(reader["expired_date"]);
                            txtHargaBeli.Text = reader["harga_beli"].ToString();
                            txtMargin.Text = reader["margin"].ToString();
                            txtHargaJual.Text = reader["harga_jual"].ToString();
                            tbKode.ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("Data barang tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error saat load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBrandList()
        {
            try
            {
                cmbBrand.Items.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT brand FROM barang WHERE brand IS NOT NULL AND brand <> ''";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbBrand.Items.Add(reader["brand"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data brand: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
