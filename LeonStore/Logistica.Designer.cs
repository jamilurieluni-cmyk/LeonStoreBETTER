namespace LeonStore
{
    partial class Logistica
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
            btnMenu = new Button();
            panel1 = new Panel();
            btnFechaEntrega = new Button();
            BtnEstadoLogistico = new Button();
            btnTipoEnvio = new Button();
            btnCostoEnvio = new Button();
            BtnIDenvio = new Button();
            BtnIdPedidos = new Button();
            lbFiltro = new Label();
            panel2 = new Panel();
            dgvEstadoEnvio = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoEnvio).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(845, 14);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(107, 38);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(btnFechaEntrega);
            panel1.Controls.Add(BtnEstadoLogistico);
            panel1.Controls.Add(btnTipoEnvio);
            panel1.Controls.Add(btnCostoEnvio);
            panel1.Controls.Add(BtnIDenvio);
            panel1.Controls.Add(BtnIdPedidos);
            panel1.Controls.Add(lbFiltro);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 645);
            panel1.TabIndex = 2;
            // 
            // btnFechaEntrega
            // 
            btnFechaEntrega.Location = new Point(36, 535);
            btnFechaEntrega.Name = "btnFechaEntrega";
            btnFechaEntrega.Size = new Size(112, 60);
            btnFechaEntrega.TabIndex = 9;
            btnFechaEntrega.Text = "Fecha entrega";
            btnFechaEntrega.UseVisualStyleBackColor = true;
            // 
            // BtnEstadoLogistico
            // 
            BtnEstadoLogistico.Location = new Point(36, 450);
            BtnEstadoLogistico.Name = "BtnEstadoLogistico";
            BtnEstadoLogistico.Size = new Size(112, 60);
            BtnEstadoLogistico.TabIndex = 8;
            BtnEstadoLogistico.Text = "Estado Logistico";
            BtnEstadoLogistico.UseVisualStyleBackColor = true;
            // 
            // btnTipoEnvio
            // 
            btnTipoEnvio.Location = new Point(36, 364);
            btnTipoEnvio.Name = "btnTipoEnvio";
            btnTipoEnvio.Size = new Size(112, 60);
            btnTipoEnvio.TabIndex = 7;
            btnTipoEnvio.Text = "Tipo envio";
            btnTipoEnvio.UseVisualStyleBackColor = true;
            // 
            // btnCostoEnvio
            // 
            btnCostoEnvio.Location = new Point(36, 287);
            btnCostoEnvio.Name = "btnCostoEnvio";
            btnCostoEnvio.Size = new Size(112, 60);
            btnCostoEnvio.TabIndex = 6;
            btnCostoEnvio.Text = "Costo Envio";
            btnCostoEnvio.UseVisualStyleBackColor = true;
            // 
            // BtnIDenvio
            // 
            BtnIDenvio.Location = new Point(36, 205);
            BtnIDenvio.Name = "BtnIDenvio";
            BtnIDenvio.Size = new Size(112, 60);
            BtnIDenvio.TabIndex = 5;
            BtnIDenvio.Text = "ID Envios";
            BtnIDenvio.UseVisualStyleBackColor = true;
            BtnIDenvio.Click += button2_Click;
            // 
            // BtnIdPedidos
            // 
            BtnIdPedidos.Location = new Point(36, 124);
            BtnIdPedidos.Name = "BtnIdPedidos";
            BtnIdPedidos.Size = new Size(112, 60);
            BtnIdPedidos.TabIndex = 4;
            BtnIdPedidos.Text = "ID pedidos";
            BtnIdPedidos.UseVisualStyleBackColor = true;
            BtnIdPedidos.Click += BtnIdPedidos_Click;
            // 
            // lbFiltro
            // 
            lbFiltro.AutoSize = true;
            lbFiltro.BackColor = SystemColors.ControlLightLight;
            lbFiltro.Location = new Point(23, 65);
            lbFiltro.Name = "lbFiltro";
            lbFiltro.Size = new Size(152, 25);
            lbFiltro.TabIndex = 3;
            lbFiltro.Text = "Filtrado de cliente";
            lbFiltro.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(btnMenu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(210, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(981, 65);
            panel2.TabIndex = 3;
            // 
            // dgvEstadoEnvio
            // 
            dgvEstadoEnvio.AllowUserToAddRows = false;
            dgvEstadoEnvio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadoEnvio.Dock = DockStyle.Fill;
            dgvEstadoEnvio.Location = new Point(210, 65);
            dgvEstadoEnvio.Name = "dgvEstadoEnvio";
            dgvEstadoEnvio.RowHeadersWidth = 62;
            dgvEstadoEnvio.Size = new Size(981, 580);
            dgvEstadoEnvio.TabIndex = 4;
            dgvEstadoEnvio.CellContentClick += dgvEstadoEnvio_CellContentClick;
            // 
            // Logistica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 645);
            Controls.Add(dgvEstadoEnvio);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Logistica";
            Text = "Logistica";
            Load += Logistica_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstadoEnvio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvEstadoEnvio;
        private Label lbFiltro;
        private Button btnFechaEntrega;
        private Button BtnEstadoLogistico;
        private Button btnTipoEnvio;
        private Button btnCostoEnvio;
        private Button BtnIDenvio;
        private Button BtnIdPedidos;
    }
}