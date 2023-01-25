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
            var vendasDia = _context.Vendas.Where(x => x.DataVenda.Date == DateTime.Now.Date)
                                            .ToList();
            List<ItensVenda> itensVendidos = new List<ItensVenda>();
            var top1 = new ItensVenda();

            foreach (var item in vendasDia)
            {
                itensVendidos.AddRange(_context.ItensVendas.Include(x => x.ItensModel).Where(x => x.VendaModelId == item.Id));
            }
            if (itensVendidos.Any())
            {
                var consulta = itensVendidos.GroupBy(x => x.ItensModel).OrderByDescending(y => y.Sum(w => w.Quantidade)).Select(x => x.ToList()).First();
                top1 = consulta[0];
            }
            else
            {
                return "https://w7.pngwing.com/pngs/380/139/png-transparent-x-red-mark-incorrect.png";
            }


            return top1.ItensModel.URLImagemItem;
        }

        public string Top1Mes()
        {
            var vendasMes = _context.Vendas.Where(x => x.DataVenda.Month == DateTime.Now.Month)
                                            .ToList();
            List<ItensVenda> itensVendidos = new List<ItensVenda>();
            var top1 = new ItensVenda();

            foreach (var item in vendasMes)
            {
                itensVendidos.AddRange(_context.ItensVendas.Include(x => x.ItensModel).Where(x => x.VendaModelId == item.Id));
            }
            if (itensVendidos.Any())
            {
                var consulta = itensVendidos.GroupBy(x => x.ItensModel).OrderByDescending(y => y.Sum(w => w.Quantidade)).Select(x => x.ToList()).First();
                top1 = consulta[0];

                return top1.ItensModel.URLImagemItem;
            }
            else
            {
                return "https://w7.pngwing.com/pngs/380/139/png-transparent-x-red-mark-incorrect.png";
            }

        }

        public string Top1Total()
        {
            var itensVendidos = _context.ItensVendas.Where(x => x.EmAberto == false);
            var top1 = new ItensVenda();

            if (itensVendidos.Any())
            {
                var consulta = itensVendidos.Include(x => x.ItensModel).GroupBy(x => x.ItensModel).OrderByDescending(x => x.Sum(x => x.Quantidade)).Select(x => x.ToList()).First();
                top1 = consulta[0];
            }
            else
            {
                return "https://w7.pngwing.com/pngs/380/139/png-transparent-x-red-mark-incorrect.png";
            }

            return top1.ItensModel.URLImagemItem;
        }
    }
}