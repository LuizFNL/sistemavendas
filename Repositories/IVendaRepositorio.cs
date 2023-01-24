using sistemavendas.Models;

namespace sistemavendas.Repositories
{
    public interface IVendaRepositorio
    {
        List<VendaModel> ListarVendas();
        void EfetuarCompra();
        List<ItensVenda> ItensVendidos(int id);
    }
}