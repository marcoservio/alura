using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class CategoriaDaoComEfCore : ICategoriaDao
    {
        AppDbContext _context;

        public CategoriaDaoComEfCore(AppDbContext context)
        {
            _context = context;
        }

        public Categoria BuscarPorId(int id)
        {
            return _context.Categorias
                .Include(c => c.Leiloes)
                .First(c => c.Id == id);
        }

        public IEnumerable<Categoria> BuscarTodos()
        {
            return _context.Categorias
                .Include(c => c.Leiloes);
        }
    }
}
