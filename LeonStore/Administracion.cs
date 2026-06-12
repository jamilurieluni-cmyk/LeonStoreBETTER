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
    public partial class Administracion : Form
    {





        private string nombre, cedulacliente, numero_telefono, Direccion, ciudad, departamento;

        // Leer todos los ComboBox de una vez
        private void GuardarValores()
        {
            nombre = cbnombrecliente.Text;
            cedulacliente = cbcedula.Text;
            numero_telefono = cbnumerotelefono.Text;
            Direccion = cbdireccion.Text;
            ciudad = cbciudad.Text;
            departamento = cbdepartamento.Text;
        }

        private void LimpiarCampos()
        {
            nombre = cedulacliente = numero_telefono = Direccion = ciudad = departamento = string.Empty;
            cbnombrecliente.Text = cbcedula.Text = cbnumerotelefono.Text = cbdireccion.Text = cbciudad.Text = cbdepartamento.Text = string.Empty;
        }
        public Administracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbnombrecliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombre = cbnombrecliente.Text;
        }

        private void cbcedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            cedulacliente = cbcedula.Text;
        }

        private void cbnumerotelefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            numero_telefono = cbnumerotelefono.Text;


        }

        private void cbdireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Direccion = cbdireccion.Text;
        }

        private void cbciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudad = cbciudad.Text;
        }

        private void cbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            departamento = cbdepartamento.Text;
        }

        private void btnAdmisnistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
    $"La información introducida es:\n" +
    $"Nombre: {nombre}\n" +
    $"Cédula: {cedulacliente}\n" +
    $"Teléfono: {numero_telefono}\n" +
    $"Dirección: {Direccion}\n" +
    $"Ciudad: {ciudad}\n" +
    $"Departamento: {departamento}\n\n" +
    $"Correo: {cbcorreo.Text}\n\n" +
    $"¿Esta información es correcta?",
    "Confirmar información",         // título de la ventana
    MessageBoxButtons.YesNo          // FUERA del string
    );
            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Informacion guardada correctamente");
            }
            else
            {
                LimpiarCampos();
            }

            SqlConnection sqlConnection = new SqlConnection("Server=MSI;Database=LeonStorePruebita;Trusted_Connection=true; TrustServerCertificate=true");
            string Consulta =
                @"INSERT INTO Clientes (Cedula, Nombre, Correo, Telefono, Departamento, Ciudad, Direccion) VALUES (@Cedula, @Nombre, @Correo, @Telefono, @Departamento, @Ciudad, @Direccion)";
            SqlCommand cmd = new SqlCommand(Consulta, sqlConnection);

            cmd.Parameters.AddWithValue("@Cedula", cbcedula.Text);
            cmd.Parameters.AddWithValue("@Nombre", cbnombrecliente.Text);
            cmd.Parameters.AddWithValue("@Correo", cbcorreo.Text);
            cmd.Parameters.AddWithValue("@Telefono", cbnumerotelefono.Text);
            cmd.Parameters.AddWithValue("@Departamento", cbdepartamento.Text);
            cmd.Parameters.AddWithValue("@Ciudad", cbciudad.Text);
            cmd.Parameters.AddWithValue("@Direccion", cbdireccion.Text);

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Datos guardados correctamente");
        }

        private void cbnombrecliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection POS_DBLeonStore = new SqlConnection("Server=MSI;Database=LeonStorePruebita;Trusted_Connection=true; TrustServerCertificate=true");
        }
    }
}
