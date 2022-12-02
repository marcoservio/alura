using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public TemplateImpostoCondicional(Imposto outroImposto) : base(outroImposto)
        {

        }

        public TemplateImpostoCondicional() : base()
        {

        }

        public override double Calcula(Orcamento orcamento)
        {
            if(DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);

            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
