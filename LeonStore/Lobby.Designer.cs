namespace LeonStore
{
    partial class Lobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            lblnombre = new Label();
            picpedidos = new PictureBox();
            txtbasededatos = new Label();
            txtlogistica = new Label();
            txtadministracion = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureadministracion = new PictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picpedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureadministracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ButtonFace;
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(iconPictureBox1);
            splitContainer1.Panel2.Controls.Add(lblnombre);
            splitContainer1.Panel2.Controls.Add(picpedidos);
            splitContainer1.Panel2.Controls.Add(txtbasededatos);
            splitContainer1.Panel2.Controls.Add(txtlogistica);
            splitContainer1.Panel2.Controls.Add(txtadministracion);
            splitContainer1.Panel2.Controls.Add(pictureBox4);
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(pictureadministracion);
            splitContainer1.Size = new Size(1197, 805);
            splitContainer1.SplitterDistance = 339;
            splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(77, 591);
            button1.Name = "button1";
            button1.Size = new Size(172, 78);
            button1.TabIndex = 19;
            button1.Text = "Cerrar sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-39, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 369);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(80, 247);
            lblnombre.Margin = new Padding(4, 0, 4, 0);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(104, 32);
            lblnombre.TabIndex = 20;
            lblnombre.Text = "Pedidos";
            lblnombre.Click += lblnombre_Click_1;
            // 
            // picpedidos
            // 
            picpedidos.Image = (Image)resources.GetObject("picpedidos.Image");
            picpedidos.Location = new Point(66, 94);
            picpedidos.Margin = new Padding(4, 5, 4, 5);
            picpedidos.Name = "picpedidos";
            picpedidos.Size = new Size(149, 136);
            picpedidos.SizeMode = PictureBoxSizeMode.StretchImage;
            picpedidos.TabIndex = 19;
            picpedidos.TabStop = false;
            picpedidos.Click += picpedidos_Click_1;
            // 
            // txtbasededatos
            // 
            txtbasededatos.AutoSize = true;
            txtbasededatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbasededatos.Location = new Point(53, 493);
            txtbasededatos.Margin = new Padding(4, 0, 4, 0);
            txtbasededatos.Name = "txtbasededatos";
            txtbasededatos.Size = new Size(171, 32);
            txtbasededatos.TabIndex = 17;
            txtbasededatos.Text = "Base de datos";
            txtbasededatos.Click += txtbasededatos_Click_1;
            // 
            // txtlogistica
            // 
            txtlogistica.AutoSize = true;
            txtlogistica.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtlogistica.Location = new Point(580, 247);
            txtlogistica.Margin = new Padding(4, 0, 4, 0);
            txtlogistica.Name = "txtlogistica";
            txtlogistica.Size = new Size(115, 32);
            txtlogistica.TabIndex = 16;
            txtlogistica.Text = "Logistica";
            txtlogistica.Click += txtlogistica_Click;
            // 
            // txtadministracion
            // 
            txtadministracion.AutoSize = true;
            txtadministracion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtadministracion.Location = new Point(319, 247);
            txtadministracion.Margin = new Padding(4, 0, 4, 0);
            txtadministracion.Name = "txtadministracion";
            txtadministracion.Size = new Size(189, 32);
            txtadministracion.TabIndex = 15;
            txtadministracion.Text = "Administracion";
            txtadministracion.Click += txtadministracion_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(566, 94);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(144, 136);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 333);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 136);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // pictureadministracion
            // 
            pictureadministracion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureadministracion.BackColor = Color.White;
            pictureadministracion.Image = (Image)resources.GetObject("pictureadministracion.Image");
            pictureadministracion.Location = new Point(334, 94);
            pictureadministracion.Name = "pictureadministracion";
            pictureadministracion.Size = new Size(133, 136);
            pictureadministracion.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureadministracion.TabIndex = 12;
            pictureadministracion.TabStop = false;
            pictureadministracion.Click += pictureadministracion_Click_1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.HighlightText;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 8;
            iconPictureBox1.Location = new Point(434, 337);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(8, 8);
            iconPictureBox1.TabIndex = 21;
            iconPictureBox1.TabStop = false;
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1197, 805);
            Controls.Add(splitContainer1);
            Name = "Lobby";
            Text = "Lobby";
            Load += Lobby_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picpedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureadministracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblnombre;
        private PictureBox picpedidos;
        private Label txtbasededatos;
        private Label txtlogistica;
        private Label txtadministracion;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureadministracion;
        private Button button1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}