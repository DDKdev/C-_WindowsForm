namespace projetoBD
{
    partial class Botao
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
            lbl_Botao = new Label();
            Btn_PictureBox = new PictureBox();
            btn_yes = new Button();
            btn_no = new Button();
            ((System.ComponentModel.ISupportInitialize)Btn_PictureBox).BeginInit();
            SuspendLayout();
            // 
            // lbl_Botao
            // 
            lbl_Botao.AutoSize = true;
            lbl_Botao.Location = new Point(87, 120);
            lbl_Botao.Name = "lbl_Botao";
            lbl_Botao.Size = new Size(45, 19);
            lbl_Botao.TabIndex = 0;
            lbl_Botao.Text = "label1";
            // 
            // Btn_PictureBox
            // 
            Btn_PictureBox.Location = new Point(70, 12);
            Btn_PictureBox.Name = "Btn_PictureBox";
            Btn_PictureBox.Size = new Size(100, 84);
            Btn_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Btn_PictureBox.TabIndex = 1;
            Btn_PictureBox.TabStop = false;
            // 
            // btn_yes
            // 
            btn_yes.Location = new Point(24, 155);
            btn_yes.Name = "btn_yes";
            btn_yes.Size = new Size(78, 37);
            btn_yes.TabIndex = 2;
            btn_yes.Text = "Sim";
            btn_yes.UseVisualStyleBackColor = true;
            btn_yes.Click += btn_yes_Click;
            // 
            // btn_no
            // 
            btn_no.Location = new Point(139, 155);
            btn_no.Name = "btn_no";
            btn_no.Size = new Size(78, 37);
            btn_no.TabIndex = 3;
            btn_no.Text = "Não";
            btn_no.UseVisualStyleBackColor = true;
            btn_no.Click += btn_no_Click;
            // 
            // Botao
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 230);
            Controls.Add(btn_no);
            Controls.Add(btn_yes);
            Controls.Add(Btn_PictureBox);
            Controls.Add(lbl_Botao);
            Name = "Botao";
            Text = "Botao";
            ((System.ComponentModel.ISupportInitialize)Btn_PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Botao;
        private PictureBox Btn_PictureBox;
        private Button btn_yes;
        private Button btn_no;
    }
}