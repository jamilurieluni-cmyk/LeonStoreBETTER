namespace LeonStore
{
    partial class Database
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
            panel2 = new Panel();
            button1 = new Button();
            dvgListaClientes = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgListaClientes).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(1023, 632);
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 44);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 706);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 597);
            button1.Name = "button1";
            button1.Size = new Size(139, 51);
            button1.TabIndex = 0;
            button1.Text = "Menú";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dvgListaClientes
            // 
            dvgListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgListaClientes.Dock = DockStyle.Fill;
            dvgListaClientes.Location = new Point(236, 44);
            dvgListaClientes.Name = "dvgListaClientes";
            dvgListaClientes.RowHeadersWidth = 62;
            dvgListaClientes.Size = new Size(907, 706);
            dvgListaClientes.TabIndex = 4;
            dvgListaClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dvgListaClientes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnMenu);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Database";
            Text = "Database";
            Load += Database_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgListaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dvgListaClientes;
        private Button button1;
    }
}