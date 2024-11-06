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
using System.Xml.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Final_Project_Vispro
{
    public partial class admin: Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public admin()
        {
            alamat = "server=localhost; database=db_carwashh; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    using (var koneksi = new MySqlConnection(alamat))
                    {
                        koneksi.Open();
                        query = "INSERT INTO tbl_login (username, password, name) VALUES (@username, @password, @name)";
                        perintah = new MySqlCommand(query, koneksi);
                        perintah.Parameters.AddWithValue("@username", txtUsername.Text);
                        perintah.Parameters.AddWithValue("@password", txtPassword.Text);
                        perintah.Parameters.AddWithValue("@name", txtName.Text);

                        int res = perintah.ExecuteNonQuery();
                        if (res == 1)
                        {
                            MessageBox.Show("Insert Data Suksess ...");
                            admin_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Gagal Insert Data . . . ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "")
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
                            txtUsername.Text = kolom["username"].ToString();

                        }
                        dataGridView1.DataSource = ds.Tables[0];

                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        admin_Load(null, null);
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

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "")
                {
                    if (MessageBox.Show("Anda Yakin Menghapus Data Ini ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("Delete from tbl_login where username = '{0}'", txtUsername.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("Delete Data Suksess ...");
                        }
                        else
                        {
                            MessageBox.Show("Gagal Delete data");
                        }
                    }
                    admin_Load(null, null);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    query = "UPDATE tbl_login SET password = @password, name = @name WHERE username = @username";

                    using (var koneksi = new MySqlConnection(alamat))
                    {
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        perintah.Parameters.AddWithValue("@password", txtPassword.Text);
                        perintah.Parameters.AddWithValue("@name", txtName.Text);
                        perintah.Parameters.AddWithValue("@username", txtUsername.Text);

                        int res = perintah.ExecuteNonQuery();
                        if (res == 1)
                        {
                            MessageBox.Show("Update Data Suksess ...");
                            admin_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Gagal Update Data . . . ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtName.Clear();

                admin_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void admin_Load(object sender, EventArgs e)
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
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID Pengguna";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Username";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Password";
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[3].HeaderText = "Nama Pengguna";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Level";


 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
