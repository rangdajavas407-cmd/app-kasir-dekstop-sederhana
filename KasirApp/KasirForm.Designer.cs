using System.Windows.Forms;

namespace KasirApp
{
    partial class KasirForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasirForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblkodeBarang = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHargaTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbayar = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPajak = new System.Windows.Forms.CheckBox();
            this.lblPajakTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalDisc = new System.Windows.Forms.TextBox();
            this.txtPajakLainnya = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(748, 50);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(10, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(179, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DATA KASIR";
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKeranjang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKeranjang.ColumnHeadersHeight = 34;
            this.dgvKeranjang.Location = new System.Drawing.Point(20, 114);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.RowHeadersWidth = 62;
            this.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeranjang.Size = new System.Drawing.Size(675, 144);
            this.dgvKeranjang.TabIndex = 1;
            this.dgvKeranjang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeranjang_CellClick);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(20, 78);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(116, 26);
            this.txtNamaBarang.TabIndex = 8;
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Location = new System.Drawing.Point(20, 57);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(115, 20);
            this.lblNamaBarang.TabIndex = 10;
            this.lblNamaBarang.Text = "&Nama Barang :";
            // 
            // lblkodeBarang
            // 
            this.lblkodeBarang.AutoSize = true;
            this.lblkodeBarang.Location = new System.Drawing.Point(142, 56);
            this.lblkodeBarang.Name = "lblkodeBarang";
            this.lblkodeBarang.Size = new System.Drawing.Size(106, 20);
            this.lblkodeBarang.TabIndex = 12;
            this.lblkodeBarang.Text = "Kode &Barang:";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(142, 77);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(116, 26);
            this.txtKodeBarang.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Disc % :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total Harga :";
            // 
            // txtHargaTotal
            // 
            this.txtHargaTotal.Location = new System.Drawing.Point(565, 307);
            this.txtHargaTotal.Name = "txtHargaTotal";
            this.txtHargaTotal.Size = new System.Drawing.Size(130, 26);
            this.txtHargaTotal.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bayar";
            // 
            // txtbayar
            // 
            this.txtbayar.Location = new System.Drawing.Point(565, 330);
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.Size = new System.Drawing.Size(130, 26);
            this.txtbayar.TabIndex = 20;
            this.txtbayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(565, 283);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(43, 26);
            this.txtTotal.TabIndex = 21;
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(420, 77);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(100, 26);
            this.txtDisc.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Disc (%) :";
            // 
            // chkPajak
            // 
            this.chkPajak.AutoSize = true;
            this.chkPajak.Location = new System.Drawing.Point(424, 55);
            this.chkPajak.Name = "chkPajak";
            this.chkPajak.Size = new System.Drawing.Size(110, 24);
            this.chkPajak.TabIndex = 24;
            this.chkPajak.Text = "Pajak 11%";
            this.chkPajak.UseVisualStyleBackColor = true;
            this.chkPajak.CheckedChanged += new System.EventHandler(this.chkPajak_CheckedChanged);
            // 
            // lblPajakTotal
            // 
            this.lblPajakTotal.AutoSize = true;
            this.lblPajakTotal.Location = new System.Drawing.Point(111, 298);
            this.lblPajakTotal.Name = "lblPajakTotal";
            this.lblPajakTotal.Size = new System.Drawing.Size(14, 20);
            this.lblPajakTotal.TabIndex = 26;
            this.lblPajakTotal.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Pajak :";
            // 
            // txtTotalDisc
            // 
            this.txtTotalDisc.Location = new System.Drawing.Point(652, 283);
            this.txtTotalDisc.Name = "txtTotalDisc";
            this.txtTotalDisc.Size = new System.Drawing.Size(43, 26);
            this.txtTotalDisc.TabIndex = 27;
            this.txtTotalDisc.TextChanged += new System.EventHandler(this.txtTotalDisc_TextChanged);
            // 
            // txtPajakLainnya
            // 
            this.txtPajakLainnya.Location = new System.Drawing.Point(108, 322);
            this.txtPajakLainnya.Name = "txtPajakLainnya";
            this.txtPajakLainnya.Size = new System.Drawing.Size(100, 26);
            this.txtPajakLainnya.TabIndex = 31;
            this.txtPajakLainnya.TextChanged += new System.EventHandler(this.txtPajakLainnya_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Pajak Lainnya :";
            // 
            // btnCari
            // 
            this.btnCari.BackgroundImage = global::KasirApp.Properties.Resources.cihuy;
            this.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCari.Location = new System.Drawing.Point(270, 77);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(30, 22);
            this.btnCari.TabIndex = 9;
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Teal;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = global::KasirApp.Properties.Resources.add__1_;
            this.btnTambah.Location = new System.Drawing.Point(444, 405);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(112, 41);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Firebrick;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Image = global::KasirApp.Properties.Resources.X;
            this.btnHapus.Location = new System.Drawing.Point(565, 405);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(127, 41);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = global::KasirApp.Properties.Resources.exit__1_;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut.Location = new System.Drawing.Point(24, 405);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(43, 41);
            this.btnLogOut.TabIndex = 32;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(73, 405);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 41);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtKembalian
            // 
            this.txtKembalian.Location = new System.Drawing.Point(565, 355);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.Size = new System.Drawing.Size(130, 26);
            this.txtKembalian.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Total Kembalian :";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Image = global::KasirApp.Properties.Resources.pencil;
            this.btnSimpan.Location = new System.Drawing.Point(326, 405);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(112, 41);
            this.btnSimpan.TabIndex = 38;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "&Generate to Exel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // KasirForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(748, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKembalian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtPajakLainnya);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalDisc);
            this.Controls.Add(this.lblPajakTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkPajak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtbayar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHargaTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblkodeBarang);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.lblNamaBarang);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KasirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesin Kasir";
            this.Load += new System.EventHandler(this.KasirForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblkodeBarang;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHargaTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbayar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPajak;
        private System.Windows.Forms.Label lblPajakTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalDisc;
        private System.Windows.Forms.TextBox txtPajakLainnya;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtKembalian;
        private System.Windows.Forms.Label label7;
        private Button btnSimpan;
        private Button button1;
    }
}
