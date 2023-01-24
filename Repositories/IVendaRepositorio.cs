using sistemavendas.Models;

namespace sistemavendas.Repositories
{
    public interface IVendaRepositorio
    {
        List<VendaModel> ListarVendas();
        void EfetuarCompra();
        List<ItensVenda> ItensVendidos(int id);
        string Top1Total();
        string Top1Mes();
        string Top1Dia();
    }
}