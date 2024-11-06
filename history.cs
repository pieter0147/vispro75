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
    public partial class history : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public history()
        {
            alamat = "server=localhost; database=db_carwashh; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSearch1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername1.Text != "")
                {
                    query = string.Format("select * from tbl_history where package = '{0}'", txtUsername1.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {


                        dataGridView1.DataSource = ds.Tables[0];
;

                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        History_Load(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void History_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_history");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "Date";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "License Plate";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Package";
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[3].HeaderText = "Cost";

                txtUsername1.Clear();
                btnSearch1.Enabled = true;


                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Columns[0].Width = 100;
                dataGridView2.Columns[0].HeaderText = "Date";
                dataGridView2.Columns[1].Width = 150;
                dataGridView2.Columns[1].HeaderText = "License Plate";
                dataGridView2.Columns[2].Width = 120;
                dataGridView2.Columns[2].HeaderText = "Package";
                dataGridView2.Columns[3].Width = 120;
                dataGridView2.Columns[3].HeaderText = "Cost";

                txtUsername2.Clear();
                btnSearch2.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void BtnSearch2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername2.Text != "")
                {
                    query = string.Format("select * from tbl_history where package = '{0}'", txtUsername2.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {


                        dataGridView1.DataSource = ds.Tables[0];
      

                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        History_Load(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtUsername1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
