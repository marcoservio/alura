using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double valorTotal;
        private double impostos;
        private List<ItemNota> todosItens = new List<ItemNota>();
        private List<AcaoAposGerarNota> TodasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();

        public NotaFiscalBuilder(List<AcaoAposGerarNota> lista)
        {
            this.Data = DateTime.Now;
            TodasAcoesASeremExecutadas = lista;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

            foreach(var item in TodasAcoesASeremExecutadas)
            {
                item.Executa(nf);
            }

            return nf;
        }

        public void AdicionarAcao(AcaoAposGerarNota novaAcao)
        {
            this.TodasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComObs(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual(DateTime data)
        {
            this.Data = data;
            return this;
        }

        public NotaFiscalBuilder Com(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder Com(ItemNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
    }
}
