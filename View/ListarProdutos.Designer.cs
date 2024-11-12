namespace AcademiaPowerHub.View
{
    partial class ListarProdutos
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
            userListBox = new ListBox();
            lblVOLTARMENUADM = new Label();
            SuspendLayout();
            // 
            // userListBox
            // 
            userListBox.FormattingEnabled = true;
            userListBox.ItemHeight = 15;
            userListBox.Location = new Point(206, 121);
            userListBox.Name = "userListBox";
            userListBox.Size = new Size(803, 499);
            userListBox.TabIndex = 0;
            // 
            // lblVOLTARMENUADM
            // 
            lblVOLTARMENUADM.AutoSize = true;
            lblVOLTARMENUADM.Font = new Font("Courier New", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVOLTARMENUADM.ForeColor = Color.White;
            lblVOLTARMENUADM.Location = new Point(1130, 24);
            lblVOLTARMENUADM.Name = "lblVOLTARMENUADM";
            lblVOLTARMENUADM.Size = new Size(31, 32);
            lblVOLTARMENUADM.TabIndex = 1;
            lblVOLTARMENUADM.Text = "X";
            lblVOLTARMENUADM.Click += lblVOLTARMENUADM_Click;
            // 
            // ListarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1184, 749);
            Controls.Add(lblVOLTARMENUADM);
            Controls.Add(userListBox);
            Name = "ListarProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarProdutos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox userListBox;
        private Label lblVOLTARMENUADM;
    }
}