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
    public partial class TipeMotor : Form
    {
        private int param;
        public TipeMotor(int id)
        {
            InitializeComponent();
            param = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paket_motor paket_Motor = new paket_motor(param);
            paket_Motor.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            services services = new services(param);
            services.Show();
            this.Hide();
        }

        private void TipeMotor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            paketMotorKecil paketMotorKecil = new paketMotorKecil(param);
            paketMotorKecil.Show();
            this.Hide();
        }
    }
}
