namespace LeonStore
{
    partial class Administracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnatras = new Button();
            btnAdmisnistrar = new Button();
            btnguardar = new Button();
            cbdepartamento = new ComboBox();
            label3 = new Label();
            cbciudad = new ComboBox();
            lbciudad = new Label();
            cbdireccion = new ComboBox();
            direccion = new Label();
            txttelefonocliente = new Label();
            txtnombrecliente = new Label();
            txtCedula = new Label();
            cbnumerotelefono = new ComboBox();
            cbcedula = new ComboBox();
            cbnombrecliente = new ComboBox();
            label1 = new Label();
            cbcorreo = new ComboBox();
            SuspendLayout();
            // 
            // btnatras
            // 
            btnatras.Location = new Point(1006, 685);
            btnatras.Margin = new Padding(4, 5, 4, 5);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(120, 45);
            btnatras.TabIndex = 0;
            btnatras.Text = "Menu";
            btnatras.UseVisualStyleBackColor = true;
            btnatras.Click += button1_Click;
            // 
            // btnAdmisnistrar
            // 
            btnAdmisnistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmisnistrar.Location = new Point(606, 443);
            btnAdmisnistrar.Margin = new Padding(4, 5, 4, 5);
            btnAdmisnistrar.Name = "btnAdmisnistrar";
            btnAdmisnistrar.Size = new Size(217, 100);
            btnAdmisnistrar.TabIndex = 28;
            btnAdmisnistrar.Text = "Administrar cliente";
            btnAdmisnistrar.UseVisualStyleBackColor = true;
            btnAdmisnistrar.Click += btnAdmisnistrar_Click;
            // 
            // btnguardar
            // 
            btnguardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.Location = new Point(265, 443);
            btnguardar.Margin = new Padding(4, 5, 4, 5);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(217, 100);
            btnguardar.TabIndex = 27;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click_1;
            // 
            // cbdepartamento
            // 
            cbdepartamento.FormattingEnabled = true;
            cbdepartamento.Location = new Point(773, 280);
            cbdepartamento.Margin = new Padding(4, 5, 4, 5);
            cbdepartamento.Name = "cbdepartamento";
            cbdepartamento.Size = new Size(201, 33);
            cbdepartamento.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(591, 279);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 30);
            label3.TabIndex = 25;
            label3.Text = "Departamento";
            // 
            // cbciudad
            // 
            cbciudad.FormattingEnabled = true;
            cbciudad.Location = new Point(702, 174);
            cbciudad.Margin = new Padding(4, 5, 4, 5);
            cbciudad.Name = "cbciudad";
            cbciudad.Size = new Size(254, 33);
            cbciudad.TabIndex = 24;
            // 
            // lbciudad
            // 
            lbciudad.AutoSize = true;
            lbciudad.Font = new Font("Segoe UI", 11F);
            lbciudad.Location = new Point(591, 173);
            lbciudad.Margin = new Padding(4, 0, 4, 0);
            lbciudad.Name = "lbciudad";
            lbciudad.Size = new Size(81, 30);
            lbciudad.TabIndex = 23;
            lbciudad.Text = "Ciudad";
            // 
            // cbdireccion
            // 
            cbdireccion.FormattingEnabled = true;
            cbdireccion.Location = new Point(702, 73);
            cbdireccion.Margin = new Padding(4, 5, 4, 5);
            cbdireccion.Name = "cbdireccion";
            cbdireccion.Size = new Size(339, 33);
            cbdireccion.TabIndex = 22;
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Font = new Font("Segoe UI", 11F);
            direccion.Location = new Point(578, 72);
            direccion.Margin = new Padding(4, 0, 4, 0);
            direccion.Name = "direccion";
            direccion.Size = new Size(103, 30);
            direccion.TabIndex = 21;
            direccion.Text = "Direccion";
            // 
            // txttelefonocliente
            // 
            txttelefonocliente.AutoSize = true;
            txttelefonocliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttelefonocliente.Location = new Point(40, 279);
            txttelefonocliente.Margin = new Padding(4, 0, 4, 0);
            txttelefonocliente.Name = "txttelefonocliente";
            txttelefonocliente.Size = new Size(211, 30);
            txttelefonocliente.TabIndex = 20;
            txttelefonocliente.Text = "Numero de telefono";
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.AutoSize = true;
            txtnombrecliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombrecliente.Location = new Point(40, 71);
            txtnombrecliente.Margin = new Padding(4, 0, 4, 0);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.Size = new Size(163, 30);
            txtnombrecliente.TabIndex = 19;
            txtnombrecliente.Text = "Nombre cliente";
            // 
            // txtCedula
            // 
            txtCedula.AutoSize = true;
            txtCedula.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.Location = new Point(40, 173);
            txtCedula.Margin = new Padding(4, 0, 4, 0);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(153, 30);
            txtCedula.TabIndex = 18;
            txtCedula.Text = "Cedula Cliente";
            // 
            // cbnumerotelefono
            // 
            cbnumerotelefono.FormattingEnabled = true;
            cbnumerotelefono.Location = new Point(265, 280);
            cbnumerotelefono.Margin = new Padding(4, 5, 4, 5);
            cbnumerotelefono.Name = "cbnumerotelefono";
            cbnumerotelefono.Size = new Size(230, 33);
            cbnumerotelefono.TabIndex = 17;
            // 
            // cbcedula
            // 
            cbcedula.FormattingEnabled = true;
            cbcedula.Location = new Point(224, 174);
            cbcedula.Margin = new Padding(4, 5, 4, 5);
            cbcedula.Name = "cbcedula";
            cbcedula.Size = new Size(242, 33);
            cbcedula.TabIndex = 16;
            // 
            // cbnombrecliente
            // 
            cbnombrecliente.FormattingEnabled = true;
            cbnombrecliente.Location = new Point(211, 72);
            cbnombrecliente.Margin = new Padding(4, 5, 4, 5);
            cbnombrecliente.Name = "cbnombrecliente";
            cbnombrecliente.Size = new Size(221, 33);
            cbnombrecliente.TabIndex = 15;
            cbnombrecliente.SelectedIndexChanged += cbnombrecliente_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 360);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 29;
            label1.Text = "Correo Electronico";
            // 
            // cbcorreo
            // 
            cbcorreo.FormattingEnabled = true;
            cbcorreo.Location = new Point(552, 361);
            cbcorreo.Margin = new Padding(4, 5, 4, 5);
            cbcorreo.Name = "cbcorreo";
            cbcorreo.Size = new Size(230, 33);
            cbcorreo.TabIndex = 30;
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(cbcorreo);
            Controls.Add(label1);
            Controls.Add(btnAdmisnistrar);
            Controls.Add(btnguardar);
            Controls.Add(cbdepartamento);
            Controls.Add(label3);
            Controls.Add(cbciudad);
            Controls.Add(lbciudad);
            Controls.Add(cbdireccion);
            Controls.Add(direccion);
            Controls.Add(txttelefonocliente);
            Controls.Add(txtnombrecliente);
            Controls.Add(txtCedula);
            Controls.Add(cbnumerotelefono);
            Controls.Add(cbcedula);
            Controls.Add(cbnombrecliente);
            Controls.Add(btnatras);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Administracion";
            Text = "Administracion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnatras;
        private Button btnAdmisnistrar;
        private Button btnguardar;
        private ComboBox cbdepartamento;
        private Label label3;
        private ComboBox cbciudad;
        private Label lbciudad;
        private ComboBox cbdireccion;
        private Label direccion;
        private Label txttelefonocliente;
        private Label txtnombrecliente;
        private Label txtCedula;
        private ComboBox cbnumerotelefono;
        private ComboBox cbcedula;
        private ComboBox cbnombrecliente;
        private Label label1;
        private ComboBox cbcorreo;
    }
}