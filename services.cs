using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Final_Project_Vispro
{
    public partial class services : Form
    {
       
        private int id;
        public services(int param)
        {
        

            InitializeComponent();
            id = param;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TipeMobil tipemobil = new TipeMobil(id);
            tipemobil.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TipeMotor tipemotor = new TipeMotor(id);
            tipemotor.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            sign_in_employe sign_In_Employe = new sign_in_employe();
            sign_In_Employe.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void services_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            profile_employee frmprof = new profile_employee(id);
            frmprof.Show();
            this.Hide();
        }
    }
}
