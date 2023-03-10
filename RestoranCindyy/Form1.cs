using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestoranCindyy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NEW_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost;user id=root;password=;database=inventory";
            string query = "INSERT INTO barang(id, nama, kategori, stok, harga)VALUES('" + this.id.Text + "', '" + this.nama.Text + "', '" + this.kategori.Text + "', '" + this.stock.Text + "', '" + this.harga.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Succesfully saved");
            conn.Close();
        }

        private void LOAD_DATA_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=inventory";
            string query = "SELECT * FROM barang";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=inventory";
            string query = "UPDATE barang SET nama = '" + this.nama.Text + "', kategori = '" + this.label3.Text + "', stok = '" + this.stok.Text + "', harga = '" + this.label5.Text + "' WHERE id = '" + this.label11.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated successfully");
            conn.Close();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=inventory";
            string query = "DELETE FROM barang WHERE id ='" + this.label11.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been successfully deleted!");
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void harga_jual_TextChanged(object sender, EventArgs e)
        {

        }

        private void harga_beli_TextChanged(object sender, EventArgs e)
        {

        }

        private void stok_Click(object sender, EventArgs e)
        {

        }

        private void harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void harga_Changed(object sender, EventArgs e)
        {

        }

        private void stock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
