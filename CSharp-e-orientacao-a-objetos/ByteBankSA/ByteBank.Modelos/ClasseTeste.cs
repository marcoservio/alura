using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class ClasseTeste
    {
        /// <summary>
        /// 
        /// </summary>
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();

            teste.MetodoPublico();
            teste.MetodoInterno();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ModificadoresTeste
    {
        /// <summary>
        /// 
        /// </summary>
        public void MetodoPublico()
        {
            // Visivel fora da classe "ModificadoresTeste"
        }

        /// <summary>
        /// 
        /// </summary>
        private void MetodoPrivado()
        {
            // Visivel apenas na classe "ModificadoresTeste"
        }

        /// <summary>
        /// 
        /// </summary>
        protected void MetodoProtegido()
        {
            // Visivel apenas na classe "ModificadoresTeste" e derivados
        }

        /// <summary>
        /// 
        /// </summary>
        internal void MetodoInterno()
        {
            //Visivel apenas para o projeto ByteBank.Modelos!
        }
    }
}
