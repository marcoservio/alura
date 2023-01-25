using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load(@"..\..\..\Data\AluraTunes.xml");

            var queryXML =
                 from g in root.Element("Generos").Elements("Genero")
                 select g;

            foreach (var item in queryXML)
            {
                Console.WriteLine("{0}\t{1}", item.Element("GeneroId").Value, item.Element("Nome").Value);
            }

            var query = from g in root.Element("Generos").Elements("Genero")
                        join m in root.Element("Musicas").Elements("Musica")
                            on g.Element("GeneroId").Value equals m.Element("GeneroId").Value
                        select new
                        {
                            MusicaId = m.Element("MusicaId").Value,
                            Musica = m.Element("Nome").Value,
                            Genero = g.Element("Nome").Value
                        };

            Console.WriteLine();
            foreach (var musicaEgenero in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    musicaEgenero.MusicaId,
                    musicaEgenero.Musica.PadRight(20),
                    musicaEgenero.Genero);
            }

            Console.ReadKey();
        }
    }
}
