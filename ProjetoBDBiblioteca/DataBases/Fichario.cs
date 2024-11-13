using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBDBiblioteca.DataBases
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;
        
        public Fichario (string Diretorio)
        {
            status = true;
            try { 
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Conexão com o fichário criada com sucesso";
            }
            catch (Exception Ex)
            {
                status = false;
                mensagem = "Não foi possível criar conexão como fichário";
            }

        }
        public void Incluir (string id, string jsonUnit)
        {
            try
            {
                status = true;
                if(File.Exists(diretorio + "\\" + id + ".json"))
                {
                    status = false;
                    mensagem = "Inclusão não permitida pois o id já existe no Banco de Dados";
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Inclusão do " + id + " efetuada com sucesso no Banco de Dados";
                }
            }catch(Exception Ex)
            {
                status = false;
                mensagem = "Não foi possível estabelecer conexãocom o fichário." + Ex.Message;
            }
        }

        public string Buscar(string id)
        {
            try
            {
                status = true;
                if (!(File.Exists(diretorio + "\\" + id + ".json")))
                {
                    status = false;
                    mensagem = "O Id não existe no banco de dados" + id;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + id + ".json");
                    status = true;
                    mensagem = "Id encontrado com Sucesso" + id;
                    return conteudo;
                }
            }
            catch (Exception Ex)
            {
                status = false;
                mensagem = "Não foi possível encontrar o ID no banco de Dados." + Ex.Message;
            }
            return "";
        }

        public void Apagar(string id)
        {
            try
            {
                status = true;
                if (!(File.Exists(diretorio + "\\" + id + ".json")))
                {
                    status = false;
                    mensagem = "Exclusão não permitida pois o id NÃO existe no Banco de Dados";
                }
                else
                {
                    File.Delete(diretorio + "\\" + id + ".json");
                    status = true;
                    mensagem = "Exclusão do " + id + " efetuada com sucesso no Banco de Dados";
                }
            }
            catch (Exception Ex)
            {
                status = false;
                mensagem = "Não foi possível estabelecer conexãocom o fichário." + Ex.Message;
            }
        }

        public void Alterar(string id, string jsonUnit)
        {
            try
            {
                status = true;
                if (!(File.Exists(diretorio + "\\" + id + ".json")))
                {
                    status = false;
                    mensagem = "Alteração não permitida pois o id já existe no Banco de Dados";
                }
                else
                {
                    File.Delete(diretorio + "\\" + id + ".json");
                    File.WriteAllText(diretorio + "\\" + id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Alteração do " + id + " efetuada com sucesso no Banco de Dados";
                }
            }
            catch (Exception Ex)
            {
                status = false;
                mensagem = "Não foi possível estabelecer conexão com o fichário." + Ex.Message;
            }
        }
    }
}
