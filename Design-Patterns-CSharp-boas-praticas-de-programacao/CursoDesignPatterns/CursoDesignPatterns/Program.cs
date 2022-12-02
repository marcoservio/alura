using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AcaoAposGerarNota> lstAcao = new List<AcaoAposGerarNota>();
            lstAcao.Add(new EnviadorDeEmail());
            lstAcao.Add(new NotaFiscalDao());
            lstAcao.Add(new EnviadorDeSms());
            lstAcao.Add(new Multiplicador(30));

            NotaFiscalBuilder criador = new NotaFiscalBuilder(lstAcao);
            criador
                .ParaEmpresa("Caelum Ensino e Inovação")
                .Com("23.445.789/0001-12")
                .Com(new ItemNota("item 1", 100.0))
                .Com(new ItemNota("item 2", 200.0))
                .ComObs("uma obs qualquer");

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();
        }
    }
}
