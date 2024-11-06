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
    public partial class employe_log : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        private int id;
        public employe_log()
        {
            alamat = "server=localhost; database=db_carwashh; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
             
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            sign_in_employe sign_In_Employe = new sign_in_employe();
            sign_In_Employe.Show();
            this.Hide();
            //try
            //{
            //    if (txtUsername.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            //    {

            //        query = string.Format("insert into tbl_login  values ('{0}','{1}');", txtUsername.Text, txtPassword.Text);


            //        koneksi.Open();
            //        perintah = new MySqlCommand(query, koneksi);
            //        adapter = new MySqlDataAdapter(perintah);
            //        int res = perintah.ExecuteNonQuery();
            //        koneksi.Close();
            //        if (res == 1)
            //        {
            //            MessageBox.Show("Insert Data Suksess ...");
            //            employe_log_Load(null, null);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Gagal inser Data . . . ");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Data Tidak lengkap !!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void Employe_log_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_login");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("select * from tbl_login where username = '{0}'", txtUsername.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        
                        sandi = kolom["password"].ToString();

                        string id_user = kolom["user_id"].ToString();
                        int id;
                        id = Convert.ToInt32(id_user);
                      

                        if (sandi == txtPassword.Text)
                        {
                            
                            services services = new services(id);
                            services.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Anda salah input password");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
