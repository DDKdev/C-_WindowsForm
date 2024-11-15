﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoBD
{
    public partial class Botao : Form
    {
        public Botao(string imagem, string mensagem)
        {
            InitializeComponent();
            //Btn_PictureBox.Image = Image.FromFile(imagem);
            Btn_PictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(imagem);
            lbl_Botao.Text = mensagem;

        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;

        }
    }
}
