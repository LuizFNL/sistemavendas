using sistemavendas.Models;

namespace sistemavendas.Repositories

{
    public interface IItensRepositorio
    {
        Task<List<ItensModel>> ListarTodos();
        IQueryable<ItensModel> Filtrar(string searchString);
    }
}