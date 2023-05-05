using Alura.ByteBank.Infraestrutura.Teste.Servico.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.Infraestrutura.Teste.Servico
{
    public class PixRepositorio : IPixRepositorio
    {
        public List<PixDTO> LstPix { get; set; }

        public PixRepositorio()
        {
            LstPix = new List<PixDTO>()
            {
                new PixDTO() {Chave = new Guid("30cc061c-a2c5-4c50-9200-9501dea5cd25"), Saldo = 10},
                new PixDTO() {Chave = Guid.NewGuid(), Saldo = 10},
                new PixDTO() {Chave = Guid.NewGuid(), Saldo = 10},
                new PixDTO() {Chave = Guid.NewGuid(), Saldo = 10},
                new PixDTO() {Chave = Guid.NewGuid(), Saldo = 10},
            };
        }

        public PixDTO ConsultaPix(Guid pix)
        {
            return LstPix.FirstOrDefault(p => p.Chave == pix);
        }
    }
}
