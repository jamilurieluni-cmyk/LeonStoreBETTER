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
    public partial class Logistica : Form
    {

        string filtro;

        public Logistica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.Show();
            this.Hide();
        }

        private void Logistica_Load(object sender, EventArgs e)
        {
            SqlConnection POS_DBLeonStore = new SqlConnection("Server=MSI;Database=LeonStorePruebita;Trusted_Connection=true; TrustServerCertificate=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Envios", POS_DBLeonStore);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEstadoEnvio.DataSource = dt;
        }

        private void dgvEstadoEnvio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnIdPedidos_Click(object sender, EventArgs e)
        {

        }
    }
}
