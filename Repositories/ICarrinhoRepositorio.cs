using sistemavendas.Models;

namespace sistemavendas.Repositories
{
    public interface ICarrinhoRepositorio
    {
        void Adicionar(int id);
        void Deletar(int id);
        void SalvarCarrinho();
        List<ItensVenda> ListarItensCarrinho();
        decimal CalcularValorCarrinho();
    }
}