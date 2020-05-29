using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ekspedisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTanggal.Text = tanggal.Text;
            DataResi.Text = no_resi.Text;
            DataNamaAdmin.Text = nama_admin.Text;
            DataNamaPengirim.Text = nama_pengirim.Text;
            DataAlamatPengirim.Text = alamat_pengirim.Text;
            DataKodePos.Text = kode_pos_pengirim.Text;
            DataHpPengirim.Text = no_hp_pengirim.Text;
            DataNamaPenerima.Text = nama_penerima.Text;
            DataAlamatPenerima.Text = nama_alamat_penerima.Text;
            DataKodePosPenerima.Text = kode_pos_penerima.Text;
            DataHpPenerima.Text = no_hp_penerima.Text;
            DataBerat.Text = berat.Text;
            DataJumlah.Text = jumlah.Text;
            DataBiayaKirim.Text = biaya_kirim.Text;
            DataBiayaLain.Text = biaya_ll.Text;
            DataAsuransi.Text = asuransi.Text;
            DataTotal.Text = total.Text;

            if (parsel.Checked == true)
            {
                DataJenisKiriman.Text = parsel.Text;
            }
            else if (surat.Checked == true)
            {
                DataJenisKiriman.Text = surat.Text;
            }
            else if (barang.Checked == true)
            {
                DataJenisKiriman.Text = barang.Text;
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataNamaAdmin.Text = "";
            DataNamaPengirim.Text = "";
            DataAlamatPengirim.Text = "";
            DataKodePos.Text = "";
            DataHpPengirim.Text = "";
            DataNamaPenerima.Text = "";
            DataAlamatPenerima.Text = "";
            DataKodePosPenerima.Text = "";
            DataHpPenerima.Text = "";
            DataBerat.Text = "";
            DataJumlah.Text = "";
            DataBiayaKirim.Text = "";
            DataBiayaLain.Text = "";
            DataAsuransi.Text = "";
            DataTotal.Text = "";
            DataTanggal.Text = "";
            DataResi.Text = "";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
