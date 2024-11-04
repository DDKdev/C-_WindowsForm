using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.VisualBasic;

namespace ProjetoBDBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do cliente é obrigatório.")]
            [StringLength(6,MinimumLength =6, ErrorMessage = "Código do cliente deve conter 6 dígitos.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente deve ser preenchido somente com números.")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome do cliente deve conter no máximo 50 caracteres.")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai deve conter no máximo 50 caracteres.")]
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da Mãe é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome da mãe deve conter no máximo 50 caracteres.")]
            public string NomeMae { get; set; }
            public bool TemPai { get; set; }

            [Required(ErrorMessage = "CPF é obrigatório.")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "Cpf deve conter 11 números.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF deve ser preenchido somente com números.")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "Gênero é obrigatório.")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "CEP é obrigatório.")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve conter 8 números.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP deve ser preenchido somente com números.")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "Logradouro é obrigatório.")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "Complemento é obrigatório.")]
            [StringLength(100, ErrorMessage = "Complemento deve ter no máximo 100 caracteres")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório.")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório.")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório.")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "telefone é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Telefone deve ser preenchido somente com números.")]
            public string Telefone { get; set; }

            public string Profissao { get; set; }

            [Required(ErrorMessage = "telefone é obrigatório.")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda Familiar deve ser um valor positivo")]
            public Double RendaFamiliar { get; set; }

            public void Validate()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if(this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do Pai e da mãe não podem ser iguais");
                }
                if(this.TemPai == false)
                {
                    if(this.NomePai == "")
                    {
                        throw new Exception("O campo nome do Pai não pode estar vazio caso a opção 'Pai desconhecido' não esteja selecionada");
                    }
                }
            }

            public bool ValidaCpf(string cpf)
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;
                tempCpf = cpf.Substring(0, 9);
                soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
            }
        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }
    }

}
