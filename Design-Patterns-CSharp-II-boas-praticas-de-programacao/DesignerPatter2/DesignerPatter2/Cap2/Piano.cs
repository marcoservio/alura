using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Cap2
{
    class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach(var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
