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
    public partial class paket_motor : Form
    {
        private int param;
        public paket_motor(int id)
        {
            
            InitializeComponent();
            param = id;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            services services = new services(param);
            services.Show();
            this.Hide();
            
        }

        private void Paket_motor_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmStruk frmStruk = new FrmStruk();
            frmStruk.Show();
            this.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
