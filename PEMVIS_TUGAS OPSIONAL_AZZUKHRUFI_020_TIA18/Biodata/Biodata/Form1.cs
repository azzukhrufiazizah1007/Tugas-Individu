using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biodata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Biodata(object sender, EventArgs e)
        {
            DataNama.Text = "";
            DataNim.Text = "";
            DataAlamat.Text = "";
            DataTempat.Text = "";
            DataTanggal.Text = "";
            DataJenis.Text = "";
            DataAgama.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataNama.Text = nama.Text;
            DataNim.Text = nim.Text;
            DataAlamat.Text = alamat.Text;
            DataTempat.Text = tempat_lahir.Text;
            DataTanggal.Text = tanggal.Text;

            if (laki.Checked == true)
            {
                DataJenis.Text = laki.Text;
            }
            else if (perempuan.Checked == true)
            {
                DataJenis.Text = perempuan.Text;
            }

            if (islam.Checked == true)
            {
                DataAgama.Text = islam.Text;
            }
            else if (kristen.Checked == true)
            {
                DataAgama.Text = kristen.Text;
            }
            else if (hindu.Checked == true)
            {
                DataAgama.Text = hindu.Text;
            }
            else if (budha.Checked == true)
            {
                DataAgama.Text = budha.Text;
            }

        }
    }
}
