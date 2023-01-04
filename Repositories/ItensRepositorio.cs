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

        public IQueryable<ItensModel> Filtrar(string searchString)
        {
            var filtro = _context.Itens.Where(s => s.Nome.Contains(searchString));

            return filtro;
        }

        public async Task<List<ItensModel>> ListarTodos()
        {
            var itens = await _context.Itens.ToListAsync();

            return itens;
        }
    }
}