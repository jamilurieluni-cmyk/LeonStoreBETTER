namespace LeonStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnlogin = new Button();
            txtpassword = new TextBox();
            txtusuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(450, 412);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(134, 89);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Iniciar sesion";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += button1_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(406, 310);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(267, 31);
            txtpassword.TabIndex = 2;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(406, 213);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(267, 31);
            txtusuario.TabIndex = 3;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 213);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(272, 313);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(428, 91);
            label4.Name = "label4";
            label4.Size = new Size(205, 30);
            label4.TabIndex = 7;
            label4.Text = "INICIO DE SESION ";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 632);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtusuario);
            Controls.Add(txtpassword);
            Controls.Add(btnlogin);
            Name = "Form1";
            Text = "                                                                                                                                                   ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private TextBox txtpassword;
        private TextBox txtusuario;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}
