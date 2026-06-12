using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeonStore
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.Show();
            this.Hide();
        }
        List<string> clientes = new List<string>();
        private void Database_Load(object sender, EventArgs e)
        {
            SqlConnection LeonStorePruebita = new SqlConnection("Server=MSI;Database=POS_DBLeonStore;Trusted_Connection=true; TrustServerCertificate=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes", LeonStorePruebita);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvgListaClientes.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.Show();
            this.Hide();
        }
    }
}
