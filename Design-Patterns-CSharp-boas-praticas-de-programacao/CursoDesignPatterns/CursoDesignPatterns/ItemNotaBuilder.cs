using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ItemNotaBuilder
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemNota Constroi()
        {
            return new ItemNota(Nome, Valor);
        }

        public ItemNotaBuilder Com(string nome)
        {
            this.Nome = nome;
            return this;
        }
        
        public ItemNotaBuilder Com(double valor)
        {
            this.Valor = valor;
            return this;
        }
    }
}
