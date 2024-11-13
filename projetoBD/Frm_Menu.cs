using Microsoft.VisualBasic;
using ProjetoBDBiblioteca.Classes;
using ProjetoBDBiblioteca;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using ProjetoBDBiblioteca.DataBases;

namespace projetoBD
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            Tls_principal.Items[0].ToolTipText = "Novo";
            Tls_principal.Items[1].ToolTipText = "Abrir";
            Tls_principal.Items[2].ToolTipText = "Salvar";
            Tls_principal.Items[3].ToolTipText = "Apagar";
            Tls_principal.Items[4].ToolTipText = "Limpar";
            LimparFormulario();

        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.Validate();
                C.ValidaComplemento();
                string clienteJson = Cliente.SerializedClassUnit(C);

                Fichario f = new Fichario("C:\\Users\\Daniel\\OneDrive\\Área de Trabalho\\DB_Teste\\Fichario");
                if (f.status)
                {
                    f.Incluir(C.Id, clienteJson);
                }
                if (f.status)
                {
                    MessageBox.Show(f.mensagem, "projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERRO: " + f.mensagem, "projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Cliente inserido" + clienteJson + " com sucesso", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_ClienteId.Text == "")
            {
                MessageBox.Show("Campo do ID vazio", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fichario f = new Fichario("C:\\Users\\Daniel\\OneDrive\\Área de Trabalho\\DB_Teste\\Fichario");
                if (f.status)
                {
                    string clienteJson = f.Buscar(Txt_ClienteId.Text);
                    Cliente.Unit c = new Cliente.Unit();
                    c = Cliente.DesSerializedClassUnit(clienteJson);
                    // Mostra o json que foi encontrado. caso contrário msotra um janela vazia
                    MessageBox.Show("Seu cliente em JSON: " + clienteJson);
                    if (clienteJson != "")
                    {
                        EscreverFormulario(c);
                    }
                }
                else
                {
                    MessageBox.Show("Erro: " + f.mensagem, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.Validate();
                C.ValidaComplemento();
                string clienteJson = Cliente.SerializedClassUnit(C);

                Fichario f = new Fichario("C:\\Users\\Daniel\\OneDrive\\Área de Trabalho\\DB_Teste\\Fichario");
                if (f.status)
                {
                    f.Alterar(C.Id, clienteJson);
                }
                if (f.status)
                {
                    MessageBox.Show(f.mensagem, "projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERRO: " + f.mensagem, "projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Cliente Alterado: " + clienteJson + " com sucesso", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void apagarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_ClienteId.Text == "")
            {
                MessageBox.Show("Campo do ID vazio", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fichario f = new Fichario("C:\\Users\\Daniel\\OneDrive\\Área de Trabalho\\DB_Teste\\Fichario");
                if (f.status)
                {
                    Botao btn = new Botao("Frm_questao", "Você tem certeza da Exclusão?");
                    btn.ShowDialog();
                    if(btn.DialogResult == DialogResult.Yes)
                    {
                        f.Apagar(Txt_ClienteId.Text);
                        
                        if (f.status)
                        {
                            MessageBox.Show("Ok: " + f.mensagem, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                        }
                        else
                        {
                            MessageBox.Show("Err: " + f.mensagem, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }                
            }
        }

        private void limparToolStripButton_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();
            C.Id = Txt_ClienteId.Text;
            C.Nome = txt_Nome.Text;
            C.NomeMae = txt_NomeMae.Text;
            C.NomePai = Txt_NomePai.Text;
            if (chk_TemPai.Checked)
            {
                C.TemPai = true;
            }
            else
            {
                C.TemPai = false;
            }

            if (Rb_masc.Checked)
            {
                C.Genero = 0;
            }
            if (Rb_fem.Checked)
            {
                C.Genero = 1;
            }
            if (Rb_ind.Checked)
            {
                C.Genero = 2;
            }

            C.Cpf = txt_cpf.Text;

            C.Cep = txt_cep.Text;
            C.Logradouro = txt_logradouro.Text;
            C.Complemento = txt_complemento.Text;
            C.Cidade = txt_cidade.Text;
            C.Bairro = txt_bairro.Text;

            if (Cmb_Estados.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
            }

            C.Telefone = txt_telefone.Text;
            C.Profissao = txt_profissao.Text;

            if (Information.IsNumeric(txt_rendaFamiliar.Text))
            {
                Double vRenda = Convert.ToDouble(txt_rendaFamiliar.Text);
                if (vRenda < 0)
                {
                    C.RendaFamiliar = 0;
                }
                else
                {
                    C.RendaFamiliar = vRenda;
                }
            }

            return C;
        }

        private void chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void txt_cep_Leave(object sender, EventArgs e)
        {
            string vCep = txt_cep.Text;
            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = ProjetoBDBiblioteca.Classes.CEP.GeraJSONCEP(vCep);
                        CEP.Unit CEP = new CEP.Unit();
                        CEP = ProjetoBDBiblioteca.Classes.CEP.DesSerializedClassUnit(vJson);
                        txt_logradouro.Text = CEP.logradouro;
                        txt_bairro.Text = CEP.bairro;
                        txt_cidade.Text = CEP.localidade;

                        Cmb_Estados.SelectedIndex = -1;
                        for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + CEP.uf + ")");
                            if (vPos > 0)
                            {
                                Cmb_Estados.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }

        private void LimparFormulario()
        {
            Txt_ClienteId.Text = "";
            txt_Nome.Text = "";
            Txt_NomePai.Text = "";
            txt_NomeMae.Text = "";
            txt_cpf.Text = "";
            txt_profissao.Text = "";
            txt_telefone.Text = "";
            txt_rendaFamiliar.Text = "";
            txt_cep.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            txt_logradouro.Text = "";
            txt_complemento.Text = "";
            Cmb_Estados.SelectedIndex = -1;
            chk_TemPai.Checked = false;
            Rb_masc.Checked = true;
        }

        void EscreverFormulario(Cliente.Unit C)
        {

            Txt_ClienteId.Text = C.Id;
            txt_Nome.Text = C.Nome;
            txt_NomeMae.Text = C.NomeMae;

            if (C.TemPai == true)
            {
                chk_TemPai.Checked = true;
                Txt_NomePai.Text = "";
            }
            else
            {
                chk_TemPai.Checked = false;
                Txt_NomePai.Text = C.NomePai;
            }

            if (C.Genero == 0)
            {
                Rb_masc.Checked = true;
            }
            if (C.Genero == 1)
            {
                Rb_fem.Checked = true;
            }
            if (C.Genero == 3)
            {
                Rb_ind.Checked = true;
            }

            txt_cpf.Text = C.Cpf;
            txt_cep.Text = C.Cep;
            txt_logradouro.Text = C.Logradouro;
            txt_complemento.Text = C.Complemento;
            txt_cidade.Text = C.Cidade;
            txt_bairro.Text = C.Bairro;
            txt_telefone.Text = C.Telefone;
            txt_profissao.Text = C.Profissao;

            if (C.Estado == "")
            {
                Cmb_Estados.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                {
                    if (C.Estado == Cmb_Estados.Items[i].ToString())
                    {
                        Cmb_Estados.SelectedIndex = i;
                    }
                }
            }

            txt_rendaFamiliar.Text = C.RendaFamiliar.ToString();
        }
    }
}
