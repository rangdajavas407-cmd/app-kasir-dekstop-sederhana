using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KasirApp
{
    partial class TambahBarang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextLabel = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Expired = new System.Windows.Forms.Label();
            this.panelNav = new System.Windows.Forms.Panel();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnBatal = new System.Windows.Forms.Button();
            this.DtpExpireddate = new System.Windows.Forms.DateTimePicker();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.GbxTypeProduct = new System.Windows.Forms.GroupBox();
            this.radCemilan = new System.Windows.Forms.RadioButton();
            this.radMinuman = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMargin = new System.Windows.Forms.TextBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.GbxTypeProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextLabel
            // 
            this.richTextLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextLabel.Location = new System.Drawing.Point(0, 0);
            this.richTextLabel.Name = "richTextLabel";
            this.richTextLabel.Size = new System.Drawing.Size(630, 58);
            this.richTextLabel.TabIndex = 0;
            this.richTextLabel.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gudang Penyimpanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Barang";
            // 
            // tbKode
            // 
            this.tbKode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKode.Location = new System.Drawing.Point(177, 80);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(168, 26);
            this.tbKode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = ":";
            // 
            // tbNama
            // 
            this.tbNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNama.Location = new System.Drawing.Point(177, 123);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(409, 26);
            this.tbNama.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nama Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Brand";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = ":";
            // 
            // Expired
            // 
            this.Expired.AutoSize = true;
            this.Expired.Location = new System.Drawing.Point(81, 306);
            this.Expired.Name = "Expired";
            this.Expired.Size = new System.Drawing.Size(94, 20);
            this.Expired.TabIndex = 30;
            this.Expired.Text = "Kadarluarsa";
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.Transparent;
            this.panelNav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNav.Controls.Add(this.BtnKeluar);
            this.panelNav.Controls.Add(this.BtnRefresh);
            this.panelNav.Controls.Add(this.BtnSimpan);
            this.panelNav.Controls.Add(this.BtnBatal);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNav.Location = new System.Drawing.Point(0, 440);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(630, 66);
            this.panelNav.TabIndex = 36;
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.BtnKeluar.BackgroundImage = global::KasirApp.Properties.Resources.logout__1_;
            this.BtnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnKeluar.Location = new System.Drawing.Point(64, 11);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(48, 42);
            this.BtnKeluar.TabIndex = 45;
            this.BtnKeluar.UseVisualStyleBackColor = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(376, 11);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(100, 42);
            this.BtnRefresh.TabIndex = 44;
            this.BtnRefresh.Text = "&Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(483, 11);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(100, 42);
            this.BtnSimpan.TabIndex = 42;
            this.BtnSimpan.Text = "&Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnBatal
            // 
            this.BtnBatal.Location = new System.Drawing.Point(122, 11);
            this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Size = new System.Drawing.Size(100, 42);
            this.BtnBatal.TabIndex = 41;
            this.BtnBatal.Text = "&Batal";
            this.BtnBatal.UseVisualStyleBackColor = true;
            // 
            // DtpExpireddate
            // 
            this.DtpExpireddate.Location = new System.Drawing.Point(180, 302);
            this.DtpExpireddate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpExpireddate.Name = "DtpExpireddate";
            this.DtpExpireddate.Size = new System.Drawing.Size(248, 26);
            this.DtpExpireddate.TabIndex = 37;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(178, 163);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(180, 28);
            this.cmbBrand.TabIndex = 38;
            // 
            // GbxTypeProduct
            // 
            this.GbxTypeProduct.Controls.Add(this.radCemilan);
            this.GbxTypeProduct.Controls.Add(this.radMinuman);
            this.GbxTypeProduct.Controls.Add(this.radioButton1);
            this.GbxTypeProduct.Location = new System.Drawing.Point(180, 202);
            this.GbxTypeProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbxTypeProduct.Name = "GbxTypeProduct";
            this.GbxTypeProduct.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GbxTypeProduct.Size = new System.Drawing.Size(408, 88);
            this.GbxTypeProduct.TabIndex = 39;
            this.GbxTypeProduct.TabStop = false;
            this.GbxTypeProduct.Text = "type Product";
            // 
            // radCemilan
            // 
            this.radCemilan.AutoSize = true;
            this.radCemilan.Location = new System.Drawing.Point(282, 32);
            this.radCemilan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radCemilan.Name = "radCemilan";
            this.radCemilan.Size = new System.Drawing.Size(91, 24);
            this.radCemilan.TabIndex = 2;
            this.radCemilan.TabStop = true;
            this.radCemilan.Text = "Cemilan";
            this.radCemilan.UseVisualStyleBackColor = true;
            // 
            // radMinuman
            // 
            this.radMinuman.AutoSize = true;
            this.radMinuman.Location = new System.Drawing.Point(158, 32);
            this.radMinuman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMinuman.Name = "radMinuman";
            this.radMinuman.Size = new System.Drawing.Size(99, 24);
            this.radMinuman.TabIndex = 1;
            this.radMinuman.TabStop = true;
            this.radMinuman.Text = "Minuman";
            this.radMinuman.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 32);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Makanan";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Jumlah";
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(435, 165);
            this.nudJumlah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(80, 26);
            this.nudJumlah.TabIndex = 41;
            this.nudJumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Harga Beli";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = ":";
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHargaBeli.Location = new System.Drawing.Point(180, 351);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.Size = new System.Drawing.Size(168, 26);
            this.txtHargaBeli.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Margin%";
            // 
            // txtMargin
            // 
            this.txtMargin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMargin.Location = new System.Drawing.Point(431, 351);
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.Size = new System.Drawing.Size(61, 26);
            this.txtMargin.TabIndex = 46;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHargaJual.Location = new System.Drawing.Point(180, 394);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(168, 26);
            this.txtHargaJual.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 20);
            this.label13.TabIndex = 48;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 398);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 47;
            this.label14.Text = "Harga Jual";
            // 
            // TambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 506);
            this.Controls.Add(this.txtHargaJual);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMargin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHargaBeli);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudJumlah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GbxTypeProduct);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.DtpExpireddate);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Expired);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextLabel);
            this.Name = "TambahBarang";
            this.Text = "Tambah Barang";
            this.panelNav.ResumeLayout(false);
            this.GbxTypeProduct.ResumeLayout(false);
            this.GbxTypeProduct.PerformLayout();
            this.Load += new System.EventHandler(this.TambahBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextLabel;
        private Label label1;
        private Label label2;
        private TextBox tbKode;
        private Label label3;
        private Label label4;
        private TextBox tbNama;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label Expired;
        private Panel panelNav;
        private Button BtnKeluar;
        private Button BtnRefresh;
        private Button BtnSimpan;
        private Button BtnBatal;
        private DateTimePicker DtpExpireddate;
        private ComboBox cmbBrand;
        private GroupBox GbxTypeProduct;
        private RadioButton radCemilan;
        private RadioButton radMinuman;
        private RadioButton radioButton1;
        private Label label8;
        private NumericUpDown nudJumlah;
        private Label label9;
        private Label label11;
        private TextBox txtHargaBeli;
        private Label label12;
        private TextBox txtMargin;
        private TextBox txtHargaJual;
        private Label label13;
        private Label label14;


    }
}
