using Microsoft.VisualBasic;
using ProjetoBDBiblioteca.Classes;
using ProjetoBDBiblioteca;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

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
            MessageBox.Show("Cliquei no Abrir");
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no Salvar");
        }

        private void apagarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no Apagar");
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
    }
}
