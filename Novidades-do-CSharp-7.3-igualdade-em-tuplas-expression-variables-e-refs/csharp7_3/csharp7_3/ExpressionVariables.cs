using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp7_3
{
    class AplicacaoWeb
    {
        public static string Porta = "8080";

        public static bool EstaRodandoEmPortaAlta = int.TryParse(Porta, out int portaComoInt) && portaComoInt > 1024;
    }

    public class ExpressionVariables
    {
        public bool ValidaIdade(string idadeComoTexto) => int.TryParse(idadeComoTexto, out int idade) && idade > 18;

        public static void TestaExpressionVariables()
        {
            var idadeComoTexto = "15";

            if(int.TryParse(idadeComoTexto, out int idade) && idade > 18)
            {
                Console.WriteLine("Voce pode entrar");
            }
        }

        public static void RegistroDeAlunos()
        {
            var registroAlunos = new string[]
            {
                "1110651", "1020651", "1110600",
                "1310800", "211060T", "011060W"
            };

            var alunosValidos = 
                from ra in registroAlunos
                where int.TryParse(ra, out int raComoInt) && raComoInt > 1000
                select ra + " é válido";
        }
    }
}
