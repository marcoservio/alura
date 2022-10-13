using Caelum.Stella.CSharp.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep = "32241395";
            string result = GetEndereco(cep);
            Console.WriteLine(result);

            ViaCEP viaCEP = new ViaCEP();

            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Console.WriteLine(enderecoJson);

            string enderecoXML = viaCEP.GetEnderecoXml(cep);
            Console.WriteLine(enderecoXML);

            var task = viaCEP.GetEnderecoJsonAsync(cep);
            Console.WriteLine(task.Result);

            var endereco = viaCEP.GetEndereco(cep);
            Console.WriteLine($"Logradouro: {endereco.Logradouro}, Bairro: {endereco.Bairro}");

            Console.ReadKey();
        }

        public static string GetEndereco(string cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string result = new HttpClient().GetStringAsync(url).Result;

            return result;
        }
    }
}
