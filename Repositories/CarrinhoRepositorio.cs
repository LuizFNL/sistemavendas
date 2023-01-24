using sistemavendas.Models;
using sistemavendas.Data;

namespace sistemavendas.Repositories
{
    public class CarrinhoRepositorio : ICarrinhoRepositorio
    {
        private readonly AppDbContext _context;
        public CarrinhoRepositorio(AppDbContext context)
        {
            _context = context;
        }
        public void Adicionar(int id)
        {
            var itensEmAberto = _context.ItensVendas.Where(x => x.EmAberto == true).ToList();
            var verifExisteItem = itensEmAberto.FirstOrDefault(x => x.ItensModelId == id);

            if (itensEmAberto != null)
            {
                if (verifExisteItem != null)
                {
                verifExisteItem.Quantidade += 1;
                _context.Update(verifExisteItem);
                    return;
                }
            }
                ItensVenda addItem = new ItensVenda();
                addItem.EmAberto = true;
                addItem.Quantidade = 1;
                addItem.ItensModelId = id;
                addItem.VendaModelId = null;
            _context.Add(addItem);
        }

        public decimal CalcularValorCarrinho()
        {
            decimal total = 0;

            var carrinhos = _context.ItensVendas.Where(x => x.EmAberto == true).ToList();
            foreach (var carrinho in carrinhos)
            {
                int quant = carrinho.Quantidade;
                var buscaPreco = _context.Itens.FirstOrDefault(x => carrinho.ItensModelId == x.Id);
                decimal preco = 0;

                if(buscaPreco != null)
                {
                    preco = buscaPreco.Preco;
                }

                decimal totalCarrinho = quant * preco;
                total += totalCarrinho;
            }

            return total;
        }

        public void Deletar(int id)
        {
            var item = _context.ItensVendas.Find(id);

            if (item != null)
            {
                _context.ItensVendas.Remove(item);
            }
        }

        public List<ItensVenda> ListarItensCarrinho()
        {
            var itensCarrinho = _context.ItensVendas.Where(x => x.EmAberto == true).ToList();

            return itensCarrinho;
        }

        public void SalvarCarrinho()
        {
            _context.SaveChanges();
        }        
    }
}
