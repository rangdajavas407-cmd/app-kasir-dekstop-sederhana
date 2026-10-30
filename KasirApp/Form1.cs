using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KasirApp
{
    public partial class LoginForm : Form
    {
        SqlConnection anes = new SqlConnection("Data Source=ANDRE-R\\SQLEXPRESS01;Initial Catalog=Pelatihan_Desktop;Integrated Security=True;TrustServerCertificate=True");

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                anes.Open();

                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                string query = "SELECT role FROM regis WHERE username = '" + username + "' AND password = '" + password + "'";

                SqlCommand cmd = new SqlCommand(query, anes);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();

                    MessageBox.Show($"Login berhasil sebagai {role}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (role.Equals("Pegawai Kasir", StringComparison.OrdinalIgnoreCase))
                    {
                        KasirForm kasirForm = new KasirForm();
                        kasirForm.Show();
                        this.Hide();
                    }
                    else if (role.Equals("Orang Gudang", StringComparison.OrdinalIgnoreCase))
                    {
                        GudangForm gudangForm = new GudangForm();
                        gudangForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Role tidak dikenali!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (anes.State == ConnectionState.Open)
                {
                    anes.Close();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
