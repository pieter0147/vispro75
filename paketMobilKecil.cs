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
    public partial class paketMobilKecil : Form
    {
        private int param;
        public paketMobilKecil(int id)
        {
            InitializeComponent();
            param =id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TipeMobil tipemobil = new TipeMobil(param);
            tipemobil.Show();
            this.Hide();
        }
    }
}
