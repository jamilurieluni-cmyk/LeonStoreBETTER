using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeonStore
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            admin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            admin.Show();
            this.Hide();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.Show();
            this.Hide();
        }

        private void txtbasededatos_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Logistica logistica = new Logistica();
            logistica.Show();
            this.Hide();
        }

        private void picpedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }

        private void lblnombre_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureadministracion_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picpedidos_Click_1(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }

        private void pictureadministracion_Click_1(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            admin.Show();
            this.Hide();
        }

        private void txtadministracion_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            admin.Show();
            this.Hide();
        }

        private void lblnombre_Click_1(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Logistica logistica = new Logistica();
            logistica.Show();
            this.Hide();
        }

        private void txtlogistica_Click(object sender, EventArgs e)
        {
            Logistica logistica = new Logistica();
            logistica.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Database database = new Database();
            database.Show();
            this.Hide();
        }

        private void txtbasededatos_Click_1(object sender, EventArgs e)
        {
            Database database = new Database();
            database.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea Cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
