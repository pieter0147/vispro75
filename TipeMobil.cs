using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Vispro
{
    public partial class TipeMobil : Form
    {
        private int param;
        public TipeMobil(int id)
        {
            InitializeComponent();
            param = id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            services services = new services(param);
            services.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paket_mobil paket_mobil = new paket_mobil(param);
            paket_mobil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paketMobilKecil paketMobilKecil = new paketMobilKecil(param);
            paketMobilKecil.Show();
            this.Show();
        }
    }
}
