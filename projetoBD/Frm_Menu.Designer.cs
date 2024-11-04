namespace projetoBD
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            Tls_principal = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            apagarToolStripButton = new ToolStripButton();
            limparToolStripButton = new ToolStripButton();
            Txt_ClienteId = new TextBox();
            Lbl_ID = new Label();
            Lbl_NomePai = new Label();
            Lbl_NomeMae = new Label();
            Lbl_Nome = new Label();
            lbl_TemPai = new Label();
            lbl_cpf = new Label();
            lbl_Gênero = new Label();
            lbl_CEP = new Label();
            lbl_bairro = new Label();
            lbl_Cidade = new Label();
            lbl_Renda = new Label();
            lbl_telefone = new Label();
            lbl_Complemento = new Label();
            lbl_Logradouro = new Label();
            lbl_profissao = new Label();
            lbl_Estado = new Label();
            txt_Nome = new TextBox();
            txt_NomeMae = new TextBox();
            Txt_NomePai = new TextBox();
            chk_TemPai = new CheckBox();
            txt_cpf = new TextBox();
            Rb_masc = new RadioButton();
            txt_telefone = new TextBox();
            txt_profissao = new TextBox();
            txt_rendaFamiliar = new TextBox();
            Rb_ind = new RadioButton();
            Rb_fem = new RadioButton();
            txt_cep = new TextBox();
            txt_logradouro = new TextBox();
            txt_complemento = new TextBox();
            txt_bairro = new TextBox();
            txt_cidade = new TextBox();
            Grp_TemPai = new GroupBox();
            Grp_genero = new GroupBox();
            Cmb_Estados = new ComboBox();
            Tls_principal.SuspendLayout();
            Grp_TemPai.SuspendLayout();
            Grp_genero.SuspendLayout();
            SuspendLayout();
            // 
            // Tls_principal
            // 
            Tls_principal.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, apagarToolStripButton, limparToolStripButton });
            Tls_principal.Location = new Point(0, 0);
            Tls_principal.Name = "Tls_principal";
            Tls_principal.Size = new Size(704, 25);
            Tls_principal.TabIndex = 0;
            Tls_principal.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = (Image)resources.GetObject("novaToolStripButton.Image");
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 22);
            novaToolStripButton.Text = "&Nova";
            novaToolStripButton.Click += novaToolStripButton_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.Click += abrirToolStripButton_Click;
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            salvarToolStripButton.Click += salvarToolStripButton_Click;
            // 
            // apagarToolStripButton
            // 
            apagarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            apagarToolStripButton.Image = (Image)resources.GetObject("apagarToolStripButton.Image");
            apagarToolStripButton.ImageTransparentColor = Color.Magenta;
            apagarToolStripButton.Name = "apagarToolStripButton";
            apagarToolStripButton.Size = new Size(23, 22);
            apagarToolStripButton.Text = "toolStripButton1";
            apagarToolStripButton.ToolTipText = "o";
            apagarToolStripButton.Click += apagarToolStripButton_Click;
            // 
            // limparToolStripButton
            // 
            limparToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            limparToolStripButton.Image = (Image)resources.GetObject("limparToolStripButton.Image");
            limparToolStripButton.ImageTransparentColor = Color.Magenta;
            limparToolStripButton.Name = "limparToolStripButton";
            limparToolStripButton.Size = new Size(23, 22);
            limparToolStripButton.Text = "o";
            limparToolStripButton.Click += limparToolStripButton_Click;
            // 
            // Txt_ClienteId
            // 
            Txt_ClienteId.Location = new Point(26, 63);
            Txt_ClienteId.Name = "Txt_ClienteId";
            Txt_ClienteId.Size = new Size(100, 26);
            Txt_ClienteId.TabIndex = 1;
            // 
            // Lbl_ID
            // 
            Lbl_ID.AutoSize = true;
            Lbl_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_ID.Location = new Point(26, 39);
            Lbl_ID.Name = "Lbl_ID";
            Lbl_ID.Size = new Size(105, 21);
            Lbl_ID.TabIndex = 2;
            Lbl_ID.Text = "Id do cliente";
            // 
            // Lbl_NomePai
            // 
            Lbl_NomePai.AutoSize = true;
            Lbl_NomePai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_NomePai.Location = new Point(289, 110);
            Lbl_NomePai.Name = "Lbl_NomePai";
            Lbl_NomePai.Size = new Size(109, 21);
            Lbl_NomePai.TabIndex = 3;
            Lbl_NomePai.Text = "Nome do Pai";
            // 
            // Lbl_NomeMae
            // 
            Lbl_NomeMae.AutoSize = true;
            Lbl_NomeMae.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_NomeMae.Location = new Point(26, 110);
            Lbl_NomeMae.Name = "Lbl_NomeMae";
            Lbl_NomeMae.Size = new Size(117, 21);
            Lbl_NomeMae.TabIndex = 4;
            Lbl_NomeMae.Text = "Nome da Mãe";
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Nome.Location = new Point(155, 39);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(57, 21);
            Lbl_Nome.TabIndex = 5;
            Lbl_Nome.Text = "Nome";
            // 
            // lbl_TemPai
            // 
            lbl_TemPai.AutoSize = true;
            lbl_TemPai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TemPai.Location = new Point(17, 22);
            lbl_TemPai.Name = "lbl_TemPai";
            lbl_TemPai.Size = new Size(77, 21);
            lbl_TemPai.TabIndex = 6;
            lbl_TemPai.Text = "Tem Pai?";
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cpf.Location = new Point(26, 176);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(38, 21);
            lbl_cpf.TabIndex = 7;
            lbl_cpf.Text = "CPF";
            // 
            // lbl_Gênero
            // 
            lbl_Gênero.AutoSize = true;
            lbl_Gênero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Gênero.Location = new Point(16, 38);
            lbl_Gênero.Name = "lbl_Gênero";
            lbl_Gênero.Size = new Size(65, 21);
            lbl_Gênero.TabIndex = 8;
            lbl_Gênero.Text = "Gênero";
            // 
            // lbl_CEP
            // 
            lbl_CEP.AutoSize = true;
            lbl_CEP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CEP.Location = new Point(173, 245);
            lbl_CEP.Name = "lbl_CEP";
            lbl_CEP.Size = new Size(39, 21);
            lbl_CEP.TabIndex = 9;
            lbl_CEP.Text = "CEP";
            // 
            // lbl_bairro
            // 
            lbl_bairro.AutoSize = true;
            lbl_bairro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bairro.Location = new Point(328, 300);
            lbl_bairro.Name = "lbl_bairro";
            lbl_bairro.Size = new Size(56, 21);
            lbl_bairro.TabIndex = 10;
            lbl_bairro.Text = "Bairro";
            // 
            // lbl_Cidade
            // 
            lbl_Cidade.AutoSize = true;
            lbl_Cidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Cidade.Location = new Point(175, 363);
            lbl_Cidade.Name = "lbl_Cidade";
            lbl_Cidade.Size = new Size(63, 21);
            lbl_Cidade.TabIndex = 11;
            lbl_Cidade.Text = "Cidade";
            // 
            // lbl_Renda
            // 
            lbl_Renda.AutoSize = true;
            lbl_Renda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Renda.Location = new Point(543, 176);
            lbl_Renda.Name = "lbl_Renda";
            lbl_Renda.Size = new Size(124, 21);
            lbl_Renda.TabIndex = 12;
            lbl_Renda.Text = "Renda Familiar";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefone.Location = new Point(170, 176);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(76, 21);
            lbl_telefone.TabIndex = 13;
            lbl_telefone.Text = "Telefone";
            // 
            // lbl_Complemento
            // 
            lbl_Complemento.AutoSize = true;
            lbl_Complemento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Complemento.Location = new Point(173, 298);
            lbl_Complemento.Name = "lbl_Complemento";
            lbl_Complemento.Size = new Size(119, 21);
            lbl_Complemento.TabIndex = 14;
            lbl_Complemento.Text = "Complemento";
            // 
            // lbl_Logradouro
            // 
            lbl_Logradouro.AutoSize = true;
            lbl_Logradouro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Logradouro.Location = new Point(307, 245);
            lbl_Logradouro.Name = "lbl_Logradouro";
            lbl_Logradouro.Size = new Size(99, 21);
            lbl_Logradouro.TabIndex = 15;
            lbl_Logradouro.Text = "Logradouro";
            // 
            // lbl_profissao
            // 
            lbl_profissao.AutoSize = true;
            lbl_profissao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_profissao.Location = new Point(337, 176);
            lbl_profissao.Name = "lbl_profissao";
            lbl_profissao.Size = new Size(80, 21);
            lbl_profissao.TabIndex = 16;
            lbl_profissao.Text = "Profissão";
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Estado.Location = new Point(337, 363);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(61, 21);
            lbl_Estado.TabIndex = 17;
            lbl_Estado.Text = "Estado";
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(155, 63);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(251, 26);
            txt_Nome.TabIndex = 18;
            // 
            // txt_NomeMae
            // 
            txt_NomeMae.Location = new Point(26, 134);
            txt_NomeMae.Name = "txt_NomeMae";
            txt_NomeMae.Size = new Size(251, 26);
            txt_NomeMae.TabIndex = 19;
            // 
            // Txt_NomePai
            // 
            Txt_NomePai.Location = new Point(289, 137);
            Txt_NomePai.Name = "Txt_NomePai";
            Txt_NomePai.Size = new Size(251, 26);
            Txt_NomePai.TabIndex = 20;
            // 
            // chk_TemPai
            // 
            chk_TemPai.AutoSize = true;
            chk_TemPai.Location = new Point(29, 46);
            chk_TemPai.Name = "chk_TemPai";
            chk_TemPai.Size = new Size(53, 23);
            chk_TemPai.TabIndex = 22;
            chk_TemPai.Text = "Não";
            chk_TemPai.UseVisualStyleBackColor = true;
            chk_TemPai.CheckedChanged += chk_TemPai_CheckedChanged;
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(26, 200);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(117, 26);
            txt_cpf.TabIndex = 23;
            // 
            // Rb_masc
            // 
            Rb_masc.AutoSize = true;
            Rb_masc.Location = new Point(16, 62);
            Rb_masc.Name = "Rb_masc";
            Rb_masc.Size = new Size(89, 23);
            Rb_masc.TabIndex = 24;
            Rb_masc.TabStop = true;
            Rb_masc.Text = "Masculino";
            Rb_masc.UseVisualStyleBackColor = true;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(170, 200);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(117, 26);
            txt_telefone.TabIndex = 25;
            // 
            // txt_profissao
            // 
            txt_profissao.Location = new Point(337, 200);
            txt_profissao.Name = "txt_profissao";
            txt_profissao.Size = new Size(188, 26);
            txt_profissao.TabIndex = 26;
            // 
            // txt_rendaFamiliar
            // 
            txt_rendaFamiliar.Location = new Point(550, 200);
            txt_rendaFamiliar.Name = "txt_rendaFamiliar";
            txt_rendaFamiliar.Size = new Size(117, 26);
            txt_rendaFamiliar.TabIndex = 27;
            // 
            // Rb_ind
            // 
            Rb_ind.AutoSize = true;
            Rb_ind.Location = new Point(16, 120);
            Rb_ind.Name = "Rb_ind";
            Rb_ind.Size = new Size(88, 23);
            Rb_ind.TabIndex = 28;
            Rb_ind.TabStop = true;
            Rb_ind.Text = "Indefinido";
            Rb_ind.UseVisualStyleBackColor = true;
            // 
            // Rb_fem
            // 
            Rb_fem.AutoSize = true;
            Rb_fem.Location = new Point(16, 91);
            Rb_fem.Name = "Rb_fem";
            Rb_fem.Size = new Size(83, 23);
            Rb_fem.TabIndex = 29;
            Rb_fem.TabStop = true;
            Rb_fem.Text = "Feminino";
            Rb_fem.UseVisualStyleBackColor = true;
            // 
            // txt_cep
            // 
            txt_cep.Location = new Point(175, 266);
            txt_cep.Name = "txt_cep";
            txt_cep.Size = new Size(92, 26);
            txt_cep.TabIndex = 30;
            // 
            // txt_logradouro
            // 
            txt_logradouro.Location = new Point(307, 266);
            txt_logradouro.Name = "txt_logradouro";
            txt_logradouro.Size = new Size(368, 26);
            txt_logradouro.TabIndex = 31;
            // 
            // txt_complemento
            // 
            txt_complemento.Location = new Point(175, 322);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(147, 26);
            txt_complemento.TabIndex = 32;
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(328, 322);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(147, 26);
            txt_bairro.TabIndex = 33;
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(175, 387);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(147, 26);
            txt_cidade.TabIndex = 34;
            // 
            // Grp_TemPai
            // 
            Grp_TemPai.Controls.Add(lbl_TemPai);
            Grp_TemPai.Controls.Add(chk_TemPai);
            Grp_TemPai.Location = new Point(446, 39);
            Grp_TemPai.Name = "Grp_TemPai";
            Grp_TemPai.Size = new Size(188, 86);
            Grp_TemPai.TabIndex = 36;
            Grp_TemPai.TabStop = false;
            Grp_TemPai.Text = "Pai Desconhecido";
            // 
            // Grp_genero
            // 
            Grp_genero.Controls.Add(lbl_Gênero);
            Grp_genero.Controls.Add(Rb_masc);
            Grp_genero.Controls.Add(Rb_ind);
            Grp_genero.Controls.Add(Rb_fem);
            Grp_genero.Location = new Point(26, 248);
            Grp_genero.Name = "Grp_genero";
            Grp_genero.Size = new Size(141, 165);
            Grp_genero.TabIndex = 37;
            Grp_genero.TabStop = false;
            // 
            // Cmb_Estados
            // 
            Cmb_Estados.FormattingEnabled = true;
            Cmb_Estados.Items.AddRange(new object[] { "AC - Acre", "AL - Alagoas", "AP - Amapá", "AM - Amazonas", "BA - Bahia", "CE - Ceará", "DF - Distrito Federal", "ES - Espírito Santo", "GO - Goiás", "MA - Maranhão", "MT - Mato Grosso", "MS - Mato Grosso do Sul", "MG - Minas Gerais", "PA - Pará", "PB - Paraíba", "PR - Paraná", "PE - Pernambuco", "PI - Piauí", "RJ - Rio de Janeiro", "RN - Rio Grande do Norte", "RS - Rio Grande do Sul", "RO - Rondônia", "RR - Roraima", "SC - Santa Catarina", "SP - São Paulo", "SE - Sergipe", "TO - Tocantins" });
            Cmb_Estados.Location = new Point(337, 386);
            Cmb_Estados.Name = "Cmb_Estados";
            Cmb_Estados.Size = new Size(177, 27);
            Cmb_Estados.TabIndex = 38;
            // 
            // Frm_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 443);
            Controls.Add(Cmb_Estados);
            Controls.Add(Grp_genero);
            Controls.Add(Grp_TemPai);
            Controls.Add(txt_cidade);
            Controls.Add(txt_bairro);
            Controls.Add(txt_complemento);
            Controls.Add(txt_logradouro);
            Controls.Add(txt_cep);
            Controls.Add(txt_rendaFamiliar);
            Controls.Add(txt_profissao);
            Controls.Add(txt_telefone);
            Controls.Add(txt_cpf);
            Controls.Add(Txt_NomePai);
            Controls.Add(txt_NomeMae);
            Controls.Add(txt_Nome);
            Controls.Add(lbl_Estado);
            Controls.Add(lbl_profissao);
            Controls.Add(lbl_Logradouro);
            Controls.Add(lbl_Complemento);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_Renda);
            Controls.Add(lbl_Cidade);
            Controls.Add(lbl_bairro);
            Controls.Add(lbl_CEP);
            Controls.Add(lbl_cpf);
            Controls.Add(Lbl_Nome);
            Controls.Add(Lbl_NomeMae);
            Controls.Add(Lbl_NomePai);
            Controls.Add(Lbl_ID);
            Controls.Add(Txt_ClienteId);
            Controls.Add(Tls_principal);
            Name = "Frm_Menu";
            Text = "Menu";
            Tls_principal.ResumeLayout(false);
            Tls_principal.PerformLayout();
            Grp_TemPai.ResumeLayout(false);
            Grp_TemPai.PerformLayout();
            Grp_genero.ResumeLayout(false);
            Grp_genero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip Tls_principal;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton apagarToolStripButton;
        private ToolStripButton limparToolStripButton;
        private TextBox Txt_ClienteId;
        private Label Lbl_ID;
        private Label Lbl_NomePai;
        private Label Lbl_NomeMae;
        private Label Lbl_Nome;
        private Label lbl_TemPai;
        private Label lbl_cpf;
        private Label lbl_Gênero;
        private Label lbl_CEP;
        private Label lbl_bairro;
        private Label lbl_Cidade;
        private Label lbl_Renda;
        private Label lbl_telefone;
        private Label lbl_Complemento;
        private Label lbl_Logradouro;
        private Label lbl_profissao;
        private Label lbl_Estado;
        private TextBox txt_Nome;
        private TextBox txt_NomeMae;
        private TextBox Txt_NomePai;
        private CheckBox chk_TemPai;
        private TextBox txt_cpf;
        private RadioButton Rb_masc;
        private TextBox txt_telefone;
        private TextBox txt_profissao;
        private TextBox txt_rendaFamiliar;
        private RadioButton Rb_ind;
        private RadioButton Rb_fem;
        private TextBox txt_cep;
        private TextBox txt_logradouro;
        private TextBox txt_complemento;
        private TextBox txt_bairro;
        private TextBox txt_cidade;
        private GroupBox Grp_TemPai;
        private GroupBox Grp_genero;
        private ComboBox Cmb_Estados;
    }
}
