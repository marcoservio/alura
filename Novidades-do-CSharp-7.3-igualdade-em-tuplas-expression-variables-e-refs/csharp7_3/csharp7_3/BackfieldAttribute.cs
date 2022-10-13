using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace csharp7_3
{
    [Serializable]
    public class FormularioCadastro
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        [field: NonSerialized]
        public string Senha { get; set; }
    }

    public class BackfieldAttribute
    {
        public static void Testa()
        {
            var novoCadastro = new FormularioCadastro
            {
                Nome = "Marco",
                Email = "marcoservio22@hotmail.com",
                Senha = "123456"
            };

            using(var arquivo = File.Create("cadastro.bin"))
            {
                var formatador = new BinaryFormatter();
                formatador.Serialize(arquivo, novoCadastro);
            }
        }
    }
}
