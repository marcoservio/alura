using DesignerPatter2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatter2.Cap4
{
    interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
