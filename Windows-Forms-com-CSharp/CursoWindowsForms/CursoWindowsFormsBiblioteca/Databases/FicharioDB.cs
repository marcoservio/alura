using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioDB
    {
        public string Mensagem { get; private set; }
        public bool Status { get; private set; }
        public string Tabela { get; private set; }
        public LocalDBClass db { get; private set; }

        public FicharioDB(string tabela)
        {
            Status = true;

            try
            {
                db = new LocalDBClass();
                Tabela = tabela;
                Mensagem = "Conexão com a tabela criada com sucesso";
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Conexão com a tabela com erro: " + ex.Message;
            }
        }

        public void Incluir(string id, string jsonUnit)
        {
            Status = true;

            try
            {
                //var sql = "INSERT INTO " + Tabela + " (Id, JSON) VALUES ('" + id + "', '" + jsonUnit + "')";
                var sql = $"INSERT INTO {Tabela} (Id, JSON) VALUES ('{id}', '{jsonUnit}')";
                db.SQLCommand(sql);

                Status = true;
                Mensagem = "Inclusão efetuada com sucesso. Identificador: " + id;
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Erro: " + ex.Message;
            }
        }

        public string Buscar(string id)
        {
            Status = true;

            try
            {
                var sql = $"SELECT Id, JSON FROM {Tabela} WHERE Id = '{id}'";
                var dt = db.SQLQuery(sql);

                if(dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString(); 

                    Status = true;
                    Mensagem = "Cliente localizado com sucesso. Identificador: " + id;

                    return conteudo;
                }
                else
                {
                    Status = false;
                    Mensagem = "Identificador não existente: " + id;
                }
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Erro: " + ex.Message;
            }

            return "";
        }

        public List<string> BuscarTodos()
        {
            Status = true;
            List<string> lista = new List<string>();

            try
            {
                var sql = $"SELECT * FROM {Tabela}";
                var dt = db.SQLQuery(sql);

                if(dt.Rows.Count > 0)
                {
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        lista.Add(conteudo);
                    }

                    return lista;
                }
                else
                {
                    Status = false;
                    Mensagem = "Não existem clientes na base de dados";
                }
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Erro: " + ex.Message;
            }

            return lista;
        }

        public void Excluir(string id)
        {
            Status = true;

            try
            {
                var sql = $"SELECT Id, JSON FROM {Tabela} WHERE Id = '{id}'";
                var dt = db.SQLQuery(sql);

                if(dt.Rows.Count > 0)
                {
                    sql = $"DELETE FROM {Tabela} WHERE Id = '{id}'";
                    db.SQLCommand(sql);

                    Status = true;
                    Mensagem = "Cliente excluido com sucesso. Identificador: " + id;
                }
                else
                {
                    Status = false;
                    Mensagem = "Identificador não existente: " + id;
                }
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Erro: " + ex.Message;
            }
        }

        public void Alterar(string id, string jsonUnit)
        {
            Status = true;

            try
            {
                var sql = $"SELECT Id, JSON FROM {Tabela} WHERE Id = '{id}'";
                var dt = db.SQLQuery(sql);

                if(dt.Rows.Count > 0)
                {
                    sql = $"UPDATE {Tabela} SET JSON = '{jsonUnit}' WHERE Id = '{id}'";
                    db.SQLCommand(sql);

                    Status = true;
                    Mensagem = "Alteração efetuada com sucesso. Identificador: " + id;
                }
                else
                {
                    Status = false;
                    Mensagem = "Alteração não permitida porque o identificador não existe: " + id;
                }
            }
            catch(Exception ex)
            {
                Status = false;
                Mensagem = "Erro: " + ex.Message;
            }
        }
    }
}
