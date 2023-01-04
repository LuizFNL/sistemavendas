using sistemavendas.Models;
using sistemavendas.Data;
using Microsoft.EntityFrameworkCore;

namespace sistemavendas.Repositories
{
    public class ItensRepositorio : IItensRepositorio
    {
        private readonly AppDbContext _context;
        public ItensRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ItensModel>> ListarTodos()
        {
            var itens = await _context.Itens.ToListAsync();

            return itens;
        }

        public IQueryable<ItensModel> Filtrar(string searchString="")
        {
            var itens = from i in _context.Itens
                        select i;

            
            if(!string.IsNullOrEmpty(searchString))
            {
                itens = _context.Itens.Where(i => i.Nome.Contains(searchString));
            }

            return itens;
        }
    }
}