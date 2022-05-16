using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using CursoWindowsFormsBiblioteca.Databases;
using System.Windows.Forms;
using System.Data;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            #region Propriedades publicas

            [Required(ErrorMessage = "Código do cliente é obrigatorio")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Codigo do cliente somente aceita valores numericos")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Codigo do cliente deve ter 6 digitos")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do cliente é obrigatorio")]
            [StringLength(100, ErrorMessage = "Nome do cliente deve ter no maximo 100 caracteres")]
            public string Nome { get; set; }

            [StringLength(100, ErrorMessage = "Nome do pai do cliente deve ter no maximo 100 caracteres")]
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da mãe do cliente é obrigatorio")]
            [StringLength(100, ErrorMessage = "Nome da mãe do cliente deve ter no maximo 100 caracteres")]
            public string NomeMae { get; set; }

            public int NaoTemPai { get; set; }

            [Required(ErrorMessage = "CPF do cliente é obrigatorio")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF do cliente somente aceita valores numericos")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF do cliente deve ter 11 digitos")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "Genero do cliente é obrigatorio")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "CEP do cliente é obrigatorio")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP do cliente somente aceita valores numericos")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP do cliente deve ter 8 digitos")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "Logradouro do cliente é obrigatorio")]
            [StringLength(100, ErrorMessage = "Logradouro do cliente deve ter no maximo 100 caracteres")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "Complemento do cliente é obrigatorio")]
            [StringLength(50, ErrorMessage = "Complemento do cliente deve ter no maximo 100 caracteres")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro do cliente é obrigatorio")]
            [StringLength(50, ErrorMessage = "Bairro do cliente deve ter no maximo 100 caracteres")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade do cliente é obrigatorio")]
            [StringLength(50, ErrorMessage = "Cidade do cliente deve ter no maximo 100 caracteres")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado do cliente é obrigatorio")]
            [StringLength(50, ErrorMessage = "Estado do cliente deve ter no maximo 50 caracteres")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Numero de telefone do cliente é obrigatorio")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Numero de telefone do cliente somente aceita valores numericos")]
            public string Telefone { get; set; }

            public string Profissao { get; set; }

            [Required(ErrorMessage = "Renda familiar do cliente é obrigatorio")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda familiar dever ser um valor positivo")]
            public double RendaFamiliar { get; set; }

            #endregion

            #region Metodos auxiliares

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if(isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach(var validationResult in results)
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
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais.");
                }

                if(this.NaoTemPai == 0)
                {
                    if(this.NomePai == "")
                    {
                        throw new Exception("Nome do Pai não pode estar vazio quando a propriedade Pai Desconhecido não estiver selecionada.");
                    }
                }

                bool validaCPF = Uteis.Valida(this.Cpf);
                if(validaCPF == false)
                {
                    throw new Exception("CPF inválido.");
                }
            }

            #endregion[

            #region CRUD do Fichario

            public void IncluirFichario(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario f = new Fichario(conexao);

                if(f.Status)
                {
                    f.Incluir(this.Id, clienteJson);
                    
                    if(!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public Unit BuscarFichario(string id, string conexao)
            {
                Fichario f = new Fichario(conexao);

                if(f.Status)
                {
                    string clienteJson = f.Buscar(id);

                    if(clienteJson != "")
                    {
                        return Cliente.DesSerializedClassUnit(clienteJson);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }

                return null;
            }

            public void AlterarFichario(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario f = new Fichario(conexao);

                if(f.Status)
                {
                    f.Alterar(this.Id, clienteJson);

                    if(!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public void ExcluirFichario(string conexao)
            {
                Fichario f = new Fichario(conexao);

                if(f.Status)
                {
                    f.Excluir(this.Id);

                    if(!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public List<List<string>> BuscarFicharioTodos(string conexao)
            {
                Fichario f = new Fichario(conexao);

                if(f.Status)
                {
                    List<string> lista = new List<string>();
                    lista = f.BuscarTodos();
                    if(f.Status)
                    {
                        List<List<string>> listaBusca = new List<List<string>>();
                        for(int i = 0; i <= lista.Count - 1; i++)
                        {
                            Cliente.Unit C = Cliente.DesSerializedClassUnit(lista[i]);
                            listaBusca.Add(new List<string> { C.Id, C.Nome });
                        }

                        return listaBusca;
                    }
                    else
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            #endregion

            #region CRUD do FicharioDB LocalDB

            public void IncluirFicharioDB(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioDB f = new FicharioDB(conexao);

                if(f.Status)
                {
                    f.Incluir(this.Id, clienteJson);

                    if(!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public Unit BuscarFicharioDB(string id, string conexao)
            {
                FicharioDB f = new FicharioDB(conexao);

                if(f.Status)
                {
                    string clienteJson = f.Buscar(id);

                    if(clienteJson != "")
                    {
                        return Cliente.DesSerializedClassUnit(clienteJson);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }

                return null;
            }

            public void AlterarFicharioDB(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioDB f = new FicharioDB(conexao);

                if(f.Status)
                {
                    f.Alterar(this.Id, clienteJson);

                    if(!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public void ExcluirFicharioDB(string conexao)
            {
                FicharioDB f = new FicharioDB(conexao);

                if(f.Status)
                {
                    f.Excluir(this.Id);

                    if(!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public List<List<string>> BuscarFicharioDBTodos(string conexao)
            {
                FicharioDB f = new FicharioDB(conexao);

                if(f.Status)
                {
                    List<string> lista = new List<string>();
                    lista = f.BuscarTodos();
                    if(f.Status)
                    {
                        List<List<string>> listaBusca = new List<List<string>>();
                        for(int i = 0; i <= lista.Count - 1; i++)
                        {
                            Cliente.Unit C = Cliente.DesSerializedClassUnit(lista[i]);
                            listaBusca.Add(new List<string> { C.Id, C.Nome });
                        }

                        return listaBusca;
                    }
                    else
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            #endregion

            #region CRUD do Fichario SQLServer

            public void IncluirFicharioSQL(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioSQLServer f = new FicharioSQLServer(conexao);

                if(f.Status)
                {
                    f.Incluir(this.Id, clienteJson);

                    if(!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public Unit BuscarFicharioSQL(string id, string conexao)
            {
                FicharioSQLServer f = new FicharioSQLServer(conexao);

                if(f.Status)
                {
                    string clienteJson = f.Buscar(id);

                    if(clienteJson != "")
                    {
                        return Cliente.DesSerializedClassUnit(clienteJson);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }

                return null;
            }

            public void AlterarFicharioSQL(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioSQLServer f = new FicharioSQLServer(conexao);

                if(f.Status)
                {
                    f.Alterar(this.Id, clienteJson);

                    if(!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public void ExcluirFicharioSQL(string conexao)
            {
                FicharioSQLServer f = new FicharioSQLServer(conexao);

                if(f.Status)
                {
                    f.Excluir(this.Id);

                    if(!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public List<List<string>> BuscarFicharioSQLTodos(string conexao)
            {
                FicharioSQLServer f = new FicharioSQLServer(conexao);

                if(f.Status)
                {
                    List<string> lista = new List<string>();
                    lista = f.BuscarTodos();
                    if(f.Status)
                    {
                        List<List<string>> listaBusca = new List<List<string>>();
                        for(int i = 0; i <= lista.Count - 1; i++)
                        {
                            Cliente.Unit C = Cliente.DesSerializedClassUnit(lista[i]);
                            listaBusca.Add(new List<string> { C.Id, C.Nome });
                        }

                        return listaBusca;
                    }
                    else
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            #endregion

            #region CRUD Fichario SQLServer Relacional

            #region Funções auxiliares

            public string ToInsert()
            {
                string sql;
                sql = @"INSERT INTO TB_Cliente
                        (Id,
                        Nome,
                        NomePai,
                        NomeMae,
                        NaoTemPai,
                        Cpf,
                        Genero,
                        Cep,
                        Logradouro,
                        Complemento,
                        Bairro,
                        Cidade,
                        Estado,
                        Telefone,
                        Profissao,
                        RendaFamiliar)
                        VALUES";

                sql += $" ('{this.Id}'," +
                       $"'{this.Nome}'," +
                       $"'{this.NomePai}'," +
                       $"'{this.NomeMae}'," +
                       $"{Convert.ToString(this.NaoTemPai)}," +
                       $"'{this.Cpf}'," +
                       $"{Convert.ToString(this.Genero)}," +
                       $"'{this.Cep}'," +
                       $"'{this.Logradouro}'," +
                       $"'{this.Complemento}'," +
                       $"'{this.Bairro}'," +
                       $"'{this.Cidade}'," +
                       $"'{this.Estado}'," +
                       $"'{this.Telefone}'," +
                       $"'{this.Profissao}'," +
                       $"{Convert.ToString(this.RendaFamiliar)});";

                return sql;
            }

            public string ToUpdate(string id)
            {
                string sql;
                sql = $@"UPDATE TB_Cliente
                        SET Id = '{this.Id}',
                        Nome = '{this.Nome}',
                        NomePai = '{this.NomePai}',
                        NomeMae = '{this.NomeMae}',
                        NaoTemPai = {Convert.ToString(this.NaoTemPai)},
                        Cpf = '{this.Cpf}',
                        Genero = {Convert.ToString(this.Genero)},
                        Cep = '{this.Cep}',
                        Logradouro = '{this.Logradouro}',
                        Complemento = '{this.Complemento}',
                        Bairro = '{this.Bairro}',
                        Cidade = '{this.Cidade}',
                        Estado = '{this.Estado}',
                        Telefone = '{this.Telefone}',
                        Profissao = '{this.Profissao}',
                        RendaFamiliar = {Convert.ToString(this.RendaFamiliar)} 
                        WHERE Id= '{id}';";

                return sql;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();

                u.Id = dr["Id"].ToString();
                u.Nome = dr["Nome"].ToString();
                u.NomePai = dr["NomePai"].ToString();
                u.NomeMae = dr["NomeMae"].ToString();
                u.NaoTemPai = Convert.ToInt32(dr["NaoTemPai"]);
                u.Cpf = dr["Cpf"].ToString();
                u.Genero = Convert.ToInt32(dr["Genero"]);
                u.Cep = dr["Cep"].ToString();
                u.Logradouro = dr["Logradouro"].ToString();
                u.Complemento = dr["Complemento"].ToString();
                u.Bairro = dr["Bairro"].ToString();
                u.Cidade = dr["Cidade"].ToString();
                u.Estado = dr["Estado"].ToString();
                u.Telefone = dr["Telefone"].ToString();
                u.Profissao = dr["Profissao"].ToString();
                u.RendaFamiliar = Convert.ToDouble(dr["RendaFamiliar"]);

                return u;
            }

            #endregion

            public void IncluirFicharioSQLRel()
            {
                var db = new SQLServerClass();

                try
                {
                    string sql;
                    sql = this.ToInsert();
                    db.SQLCommand(sql);
                }
                catch(Exception ex)
                {
                    throw new Exception("Inclusão não permitida. Indentificador: " + this.Id + ", erro: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }

            public Unit BuscarFicharioSQLRel(string id)
            {
                var db = new SQLServerClass();

                try
                {
                    string sql = $"SELECT * FROM TB_Cliente WHERE Id = '{id}'";
                    var dt = db.SQLQuery(sql);

                    if(dt.Rows.Count == 0)
                    {
                        throw new Exception("Indenficador não existente: " + id);
                    }
                    else
                    {
                        Unit u = DataRowToUnit(dt.Rows[0]);
                        return u;
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Erro ao buscar o conteudo do identificador: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }

            public void AlterarFicharioSQLRel()
            {
                var db = new SQLServerClass();

                try
                {
                    string sql = $"SELECT * FROM TB_Cliente WHERE Id = '{this.Id}'";
                    var dt = db.SQLQuery(sql);

                    if(dt.Rows.Count == 0)
                    {
                        throw new Exception("Indenficador não existente: " + this.Id);
                    }
                    else
                    {
                        sql = this.ToUpdate(this.Id);
                        db.SQLCommand(sql);
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Erro ao alterar o conteudo do identificador: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }

            public void ExcluirFicharioSQLRel()
            {
                var db = new SQLServerClass();

                try
                {
                    string sql = $"SELECT * FROM TB_Cliente WHERE Id = '{this.Id}'";
                    var dt = db.SQLQuery(sql);

                    if(dt.Rows.Count == 0)
                    {
                        throw new Exception("Indenficador não existente: " + this.Id);
                    }
                    else
                    {
                        sql = $"DELETE FROM TB_Cliente WHERE Id = '{this.Id}'";
                        db.SQLCommand(sql);
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Erro ao alterar o conteudo do identificador: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }

            public List<List<string>> BuscarFicharioSQLTodosRel()
            {
                var db = new SQLServerClass();
                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var sql = $"SELECT * FROM TB_Cliente";
                    var dt = db.SQLQuery(sql);

                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        ListaBusca.Add(new List<string> { dt.Rows[i]["Id"].ToString(), dt.Rows[i]["Nome"].ToString() });
                    }

                    return ListaBusca;
                }
                catch(Exception ex)
                {
                    throw new Exception("Conexão com a base ocasionou em erro: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }

            #endregion
        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
