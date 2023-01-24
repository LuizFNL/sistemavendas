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

        public string Top1Dia()
        {
            var vendasMes = _context.Vendas.Where(x => x.DataVenda.Date == DateTime.Now.Date)
                                            .Select(x => x.Id).ToList();
            List<ItensVenda> itensVendidos = new List<ItensVenda>();
            var top1 = new ItensVenda();

            foreach (var item in vendasMes)
            {
                itensVendidos.Add(_context.ItensVendas.FirstOrDefault(x => x.VendaModelId == item));
            }
            if (itensVendidos != null)
            {
                var consulta = itensVendidos.GroupBy(x => x.ItensModel).OrderByDescending(x => x.Sum(x => x.Quantidade)).Select(x => x.First()).ToList();

                top1 = consulta.First();
            }

            return top1.ItensModel.URLImagemItem;
        }

        public string Top1Mes()
        {
            var vendasMes = _context.Vendas.Where(x => x.DataVenda.Month == DateTime.Now.Month)
                                            .Select(x => x.Id).ToList();
            List<ItensVenda> itensVendidos = new List<ItensVenda>();
            var top1 = new ItensVenda();

            foreach (var item in vendasMes)
            {
                itensVendidos.Add(_context.ItensVendas.FirstOrDefault(x => x.VendaModelId == item));
            }
            if (itensVendidos != null)
            {
                var consulta = itensVendidos.GroupBy(x => x.ItensModel).OrderByDescending(x => x.Sum(x => x.Quantidade)).Select(x => x.First()).ToList();

                top1 = consulta.First();
            }

            return top1.ItensModel.URLImagemItem;
        }

        public string Top1Total()
        {
            var itensVendidos = _context.ItensVendas.Where(x => x.EmAberto == false);
            var consulta = itensVendidos.Include(x => x.ItensModel).GroupBy(x => x.ItensModel).OrderByDescending(x => x.Sum(x => x.Quantidade)).Select(x => x.First()).ToList();
            var top1 = new ItensVenda();
            top1 = consulta.First();

            return top1.ItensModel.URLImagemItem;
        }
    }
}