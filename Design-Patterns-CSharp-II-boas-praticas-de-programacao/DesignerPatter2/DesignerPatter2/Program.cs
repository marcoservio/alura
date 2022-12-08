using DesignerPatter2.Cap1;
using DesignerPatter2.Cap2;
using DesignerPatter2.Cap4;
using DesignerPatter2.Cap5;
using DesignerPatter2.Cap6;
using DesignerPatter2.Cap7;
using DesignerPatter2.Cap8;
using DesignerPatter2.Cap9;
using DesignerPatter2.Capt3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignerPatter2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf = "1234";

            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            var fatura = facade.CriaFatura(cliente, 5000);
            facade.GeraCobranca(Tipo.Boleto, fatura);

            Console.ReadLine();
        }
    }
}
