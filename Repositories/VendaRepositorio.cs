using Microsoft.EntityFrameworkCore;
using sistemavendas.Data;
using sistemavendas.Models;

namespace sistemavendas.Repositories
{
    public class VendaRepositorio : IVendaRepositorio
    {
        private readonly AppDbContext _context;
        private readonly ICarrinhoRepositorio _carrinho;

        public VendaRepositorio(AppDbContext context, ICarrinhoRepositorio carrinho)
        {
            _context = context;
            _carrinho = carrinho;
        }

        public void EfetuarCompra()
        {
            VendaModel novaVenda = new VendaModel();
            var itensVenda = _context.ItensVendas.Where(x => x.EmAberto == true).ToList();

            novaVenda.ItensVenda = itensVenda;
            novaVenda.DataVenda = DateTime.Now;
            novaVenda.ValorTotal = _carrinho.CalcularValorCarrinho();

            _context.Add(novaVenda);

            foreach (var item in itensVenda)
            {
                item.EmAberto = false;
            }

            _context.SaveChanges();
        }

        public List<ItensVenda> ItensVendidos(int id)
        {
            var itens = _context.ItensVendas.Include(x => x.ItensModel).Where(x => x.VendaModelId == id).ToList();

            return itens;
        }

        public List<VendaModel> ListarVendas()
        {
            return _context.Vendas.Include(x => x.ItensVenda).ToList();
        }
    }
}