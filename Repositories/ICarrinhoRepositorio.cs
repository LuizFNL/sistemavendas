using sistemavendas.Models;

namespace sistemavendas.Repositories
{
    public interface ICarrinhoRepositorio
    {
        CarrinhoModel Adicionar(int id);
        void Deletar(int id);
        void SalvarCarrinho();
        List<CarrinhoModel> ListarItensCarrinho();
        decimal CalcularValorCarrinho();
    }
}