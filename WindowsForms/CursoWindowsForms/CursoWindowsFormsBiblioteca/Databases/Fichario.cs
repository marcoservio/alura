using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class Fichario
    {
        public string Diretorio { get; private set; }
        public string Mensagem { get; private set; }
        public bool Status { get; private set; }

        public Fichario(string diretorio)
        {
            Status = true;

            try
            {
                if(!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                Diretorio = diretorio;
                Mensagem = "Conexão com o fichario criada com sucesso";
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Conexão com o fichario com erro: " + ex.Message;
            }
        }

        public void Incluir(string id, string jsonUnit)
        {
            Status = true;

            try
            {
                string caminho = Diretorio + "\\" + id + ".json";

                if(File.Exists(caminho))
                {
                    Status = false;
                    Mensagem = "Inclusão não permitida porque o identificador já existe: " + id;
                }
                else
                {
                    File.WriteAllText(caminho, jsonUnit);

                    Status = true;
                    Mensagem = "Inclusão efetuada com sucesso. Identificador: " + id;
                }
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Conexão com o fichario com erro: " + ex.Message;
            }
        }

        public string Buscar(string id)
        {
            Status = true;

            try
            {
                string caminho = Diretorio + "\\" + id + ".json";

                if(!File.Exists(caminho))
                {
                    Status = false;
                    Mensagem = "Identificador não existente: " + id;
                }
                else
                {
                    string conteudo = File.ReadAllText(caminho);

                    Status = true;
                    Mensagem = "Arquivo buscado com sucesso. Identificador: " + id;

                    return conteudo;
                }
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Erro ao buscar o conteudo do identificador: " + ex.Message;
            }

            return "";
        }

        public void Excluir(string id)
        {
            Status = true;

            try
            {
                string caminho = Diretorio + "\\" + id + ".json";

                if(!File.Exists(caminho))
                {
                    Status = false;
                    Mensagem = "Identificador não existente: " + id;
                }
                else
                {
                    File.Delete(caminho);

                    Status = true;
                    Mensagem = "Exclusão efetuada com sucesso. Identificador: " + id;
                }
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Erro ao buscar o conteudo do identificador: " + ex.Message;
            }
        }

        public void Alterar(string id, string jsonUnit)
        {
            Status = true;

            try
            {
                string caminho = Diretorio + "\\" + id + ".json";

                if(!File.Exists(caminho))
                {
                    Status = false;
                    Mensagem = "Alteração não permitida porque o identificador não existe: " + id;
                }
                else
                {
                    File.Delete(caminho);
                    File.WriteAllText(caminho, jsonUnit);

                    Status = true;
                    Mensagem = "Alteração efetuada com sucesso. Identificador: " + id;
                }
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Conexão com o fichario com erro: " + ex.Message;
            }
        }

        public List<string> BuscarTodos()
        {
            Status = true;

            List<string> lista = new List<string>();

            try
            {
                var arquivos = Directory.GetFiles(Diretorio, "*.json");

                for(int i = 0; i < arquivos.Length; i++)
                {
                    string conteudo = File.ReadAllText(arquivos[i]);
                    lista.Add(conteudo);
                }

                return lista;
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Erro ao buscar o conteudo do identificador: " + ex.Message;
            }

            return lista;
        }
    }
}
