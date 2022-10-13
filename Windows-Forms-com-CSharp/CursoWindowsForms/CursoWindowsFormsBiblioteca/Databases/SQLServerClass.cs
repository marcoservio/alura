using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class SQLServerClass
    {
        public string stringConn { get; private set; }
        public SqlConnection connDB { get; private set; }

        public SQLServerClass()
        {
            Conectar();
        }

        public void Conectar()
        {
            try
            {
                //stringConn = "Data Source=MARCOSERVIO\\SQLEXPRESS;Initial Catalog=ByteBank;User ID=sa;Password=1234";
                stringConn = ConfigurationManager.ConnectionStrings["Fichario"].ConnectionString;
                connDB = new SqlConnection(stringConn);
                connDB.Open();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SQLQuery(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                var myCommand = new SqlCommand(sql, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();

                dt.Load(myReader);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public string SQLCommand(string sql)
        {
            try
            {
                var myCommand = new SqlCommand(sql, connDB);
                myCommand.CommandTimeout = 0; // 0 = Não existe tempo de espera
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            connDB.Close();
        }
    }
}
