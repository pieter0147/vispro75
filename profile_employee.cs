using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;


namespace Final_Project_Vispro
{
    public partial class profile_employee : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        private int id_user;
        public profile_employee(int param)
        {
            alamat = "server=localhost; database=db_carwashh; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
            id_user = param;
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Profile_employee_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            try
            {
                query = string.Format("select * from tbl_login where user_id = '{0}'", id_user);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                //adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow kolom = ds.Tables[0].Rows[0];
                    lblName.Text = kolom["name"].ToString();
                    lblPosisi.Text = kolom["posisi"].ToString();
                    lblUsername.Text = kolom["username"].ToString();
                    lblId.Text = kolom["user_id"].ToString();
                    lblTgglLahir.Text = kolom["tanggal_lahir"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Data tidak ada !!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //koneksi.Close();
        }

    }

}




