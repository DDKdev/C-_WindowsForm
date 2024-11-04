using Microsoft.VisualBasic;
using ProjetoBDBiblioteca.Classes;
using System.ComponentModel.DataAnnotations;

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

        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.Validate();
                C.ValidaComplemento();
                C.ValidaCpf(C.Cpf);
                MessageBox.Show("Cliente inserido com sucesso", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Cliquei no Limpar");
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
            if(chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }
    }
}
