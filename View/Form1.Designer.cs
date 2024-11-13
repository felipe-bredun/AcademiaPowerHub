namespace AcademiaPowerHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnLoginAbaLoginInicial = new Button();
            lblBotaoSairLogin = new Label();
            checkBoxMostrarSenhaLogin = new CheckBox();
            lblCliqueAquiParaSeRegistrar = new Label();
            label3 = new Label();
            txtBoxSenhaLogin = new TextBox();
            label2 = new Label();
            txtBoxLoginInicio = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            lblLogin = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblIrParaLoja = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblIrParaLoja);
            panel1.Controls.Add(btnLoginAbaLoginInicial);
            panel1.Controls.Add(lblBotaoSairLogin);
            panel1.Controls.Add(checkBoxMostrarSenhaLogin);
            panel1.Controls.Add(lblCliqueAquiParaSeRegistrar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxSenhaLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxLoginInicio);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(148, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 524);
            panel1.TabIndex = 0;
            // 
            // btnLoginAbaLoginInicial
            // 
            btnLoginAbaLoginInicial.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginAbaLoginInicial.Location = new Point(524, 354);
            btnLoginAbaLoginInicial.Name = "btnLoginAbaLoginInicial";
            btnLoginAbaLoginInicial.Size = new Size(214, 41);
            btnLoginAbaLoginInicial.TabIndex = 17;
            btnLoginAbaLoginInicial.Text = "ENTRAR";
            btnLoginAbaLoginInicial.UseVisualStyleBackColor = true;
            btnLoginAbaLoginInicial.Click += btnLoginAbaLoginInicial_Click;
            // 
            // lblBotaoSairLogin
            // 
            lblBotaoSairLogin.AutoSize = true;
            lblBotaoSairLogin.Font = new Font("Constantia", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBotaoSairLogin.ForeColor = Color.OrangeRed;
            lblBotaoSairLogin.Location = new Point(863, 13);
            lblBotaoSairLogin.Name = "lblBotaoSairLogin";
            lblBotaoSairLogin.Size = new Size(41, 42);
            lblBotaoSairLogin.TabIndex = 16;
            lblBotaoSairLogin.Text = "X";
            lblBotaoSairLogin.Click += lblBotaoSairLogin_Click;
            // 
            // checkBoxMostrarSenhaLogin
            // 
            checkBoxMostrarSenhaLogin.AutoSize = true;
            checkBoxMostrarSenhaLogin.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMostrarSenhaLogin.Location = new Point(678, 321);
            checkBoxMostrarSenhaLogin.Name = "checkBoxMostrarSenhaLogin";
            checkBoxMostrarSenhaLogin.Size = new Size(117, 19);
            checkBoxMostrarSenhaLogin.TabIndex = 9;
            checkBoxMostrarSenhaLogin.Text = "Mostrar Senha";
            checkBoxMostrarSenhaLogin.UseVisualStyleBackColor = true;
            checkBoxMostrarSenhaLogin.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblCliqueAquiParaSeRegistrar
            // 
            lblCliqueAquiParaSeRegistrar.AutoSize = true;
            lblCliqueAquiParaSeRegistrar.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliqueAquiParaSeRegistrar.ForeColor = Color.Red;
            lblCliqueAquiParaSeRegistrar.Location = new Point(647, 414);
            lblCliqueAquiParaSeRegistrar.Name = "lblCliqueAquiParaSeRegistrar";
            lblCliqueAquiParaSeRegistrar.Size = new Size(107, 17);
            lblCliqueAquiParaSeRegistrar.TabIndex = 8;
            lblCliqueAquiParaSeRegistrar.Text = "Clique Aqui";
            lblCliqueAquiParaSeRegistrar.Click += lblCliqueAquiParaSeRegistrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(490, 414);
            label3.Name = "label3";
            label3.Size = new Size(161, 17);
            label3.TabIndex = 7;
            label3.Text = "Não tem cadastro?";
            label3.Click += label3_Click;
            // 
            // txtBoxSenhaLogin
            // 
            txtBoxSenhaLogin.Location = new Point(492, 282);
            txtBoxSenhaLogin.Name = "txtBoxSenhaLogin";
            txtBoxSenhaLogin.Size = new Size(303, 23);
            txtBoxSenhaLogin.TabIndex = 6;
            txtBoxSenhaLogin.UseSystemPasswordChar = true;
            txtBoxSenhaLogin.TextChanged += txtBoxSenhaLogin_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(433, 284);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // txtBoxLoginInicio
            // 
            txtBoxLoginInicio.Location = new Point(492, 225);
            txtBoxLoginInicio.Name = "txtBoxLoginInicio";
            txtBoxLoginInicio.Size = new Size(303, 23);
            txtBoxLoginInicio.TabIndex = 4;
            txtBoxLoginInicio.TextChanged += txtBoxEmailLogin_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-60, 568);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(433, 227);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(591, 140);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(65, 21);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 518);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 518);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblIrParaLoja
            // 
            lblIrParaLoja.AutoSize = true;
            lblIrParaLoja.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIrParaLoja.ForeColor = Color.Black;
            lblIrParaLoja.Location = new Point(514, 442);
            lblIrParaLoja.Name = "lblIrParaLoja";
            lblIrParaLoja.Size = new Size(210, 15);
            lblIrParaLoja.TabIndex = 18;
            lblIrParaLoja.Text = "Clique aqui para ir para loja";
            lblIrParaLoja.Click += lblIrParaLoja_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1184, 801);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblLogin;
        private Label lblCliqueAquiParaSeRegistrar;
        private Label label3;
        private TextBox txtBoxSenhaLogin;
        private Label label2;
        private TextBox txtBoxLoginInicio;
        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBoxMostrarSenhaLogin;
        private Label lblBotaoSairLogin;
        private Button btnLoginAbaLoginInicial;
        private Label lblIrParaLoja;
    }
}
