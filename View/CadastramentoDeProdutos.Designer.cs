namespace AcademiaPowerHub
{
    partial class CadastramentoDeProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastramentoDeProdutos));
            panel1 = new Panel();
            panel3 = new Panel();
            textBoxCategoria = new TextBox();
            textBoxTributacao = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxDescrição = new TextBox();
            textBoxPreço = new TextBox();
            textBoxNomeProduto = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(107, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 564);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxCategoria);
            panel3.Controls.Add(textBoxTributacao);
            panel3.Controls.Add(textBoxQuantidade);
            panel3.Controls.Add(textBoxDescrição);
            panel3.Controls.Add(textBoxPreço);
            panel3.Controls.Add(textBoxNomeProduto);
            panel3.Location = new Point(106, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(786, 278);
            panel3.TabIndex = 0;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCategoria.Location = new Point(456, 201);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(200, 29);
            textBoxCategoria.TabIndex = 6;
            textBoxCategoria.Text = "CATEGORIA";
            textBoxCategoria.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTributacao
            // 
            textBoxTributacao.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTributacao.Location = new Point(138, 201);
            textBoxTributacao.Name = "textBoxTributacao";
            textBoxTributacao.Size = new Size(200, 29);
            textBoxTributacao.TabIndex = 5;
            textBoxTributacao.Text = "TRIBUTAÇÃO";
            textBoxTributacao.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxQuantidade.Location = new Point(456, 120);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(200, 29);
            textBoxQuantidade.TabIndex = 4;
            textBoxQuantidade.Text = "QUANTIDADE";
            textBoxQuantidade.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDescrição
            // 
            textBoxDescrição.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescrição.Location = new Point(138, 120);
            textBoxDescrição.Name = "textBoxDescrição";
            textBoxDescrição.Size = new Size(200, 29);
            textBoxDescrição.TabIndex = 3;
            textBoxDescrição.Text = "DESCRIÇÃO";
            textBoxDescrição.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPreço
            // 
            textBoxPreço.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPreço.Location = new Point(456, 47);
            textBoxPreço.Name = "textBoxPreço";
            textBoxPreço.Size = new Size(200, 29);
            textBoxPreço.TabIndex = 2;
            textBoxPreço.Text = "PREÇO";
            textBoxPreço.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeProduto.Location = new Point(138, 47);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(200, 29);
            textBoxNomeProduto.TabIndex = 1;
            textBoxNomeProduto.Text = "NOME DO PRODUTO";
            textBoxNomeProduto.TextAlign = HorizontalAlignment.Center;
            textBoxNomeProduto.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(107, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(991, 96);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(379, 38);
            label1.Name = "label1";
            label1.Size = new Size(238, 23);
            label1.TabIndex = 2;
            label1.Text = "CADASTRAR NOVO PRODUTO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(858, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CadastramentoDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1184, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CadastramentoDeProdutos";
            Text = "Cadastramento";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBoxNomeProduto;
        private TextBox textBoxDescrição;
        private TextBox textBoxPreço;
        private TextBox textBoxCategoria;
        private TextBox textBoxTributacao;
        private TextBox textBoxQuantidade;
    }
}