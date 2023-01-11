using Microsoft.AspNetCore.Mvc;
using sistemavendas.Models;
using sistemavendas.Data;
using Microsoft.EntityFrameworkCore;

namespace sistemavendas.Repositories
{
    public class CarrinhoRepositorio : ICarrinhoRepositorio
    {
        private readonly AppDbContext _context;
        public CarrinhoRepositorio(AppDbContext context)
        {
            _context = context;
        }
        public CarrinhoModel Adicionar(int id)
        {
            var verifCar = _context.Carrinhos.FirstOrDefault(x => x.ItensModelId == id);

            if (verifCar != null)
            {
                verifCar.Quantidade += 1;
                _context.Update(verifCar);

                return verifCar;
            }

            var item = _context.Itens.Find(id);
            CarrinhoModel carrinho = new CarrinhoModel();

            if (item != null)
            {
                carrinho.ItensModelId = item.Id;
                carrinho.Quantidade = 1;
                _context.Carrinhos.Add(carrinho);
            }

            return carrinho;
        }

        public decimal CalcularValorCarrinho()
        {
            decimal total = 0;

            var carrinhos = _context.Carrinhos.ToList();
            foreach (var carrinho in carrinhos)
            {
                var quant = carrinho.Quantidade;
                var preco = carrinho.ItensModel.Preco;

                var totalCarrinho = quant * preco;
                total += totalCarrinho;
            }

            return total;
        }

        public void Deletar(int id)
        {
            var item = _context.Carrinhos.Find(id);

            if (item != null)
            {
                _context.Carrinhos.Remove(item);
            }
        }

        public List<CarrinhoModel> ListarItensCarrinho()
        {
            var itensCarrinho = _context.Carrinhos.Include(x => x.ItensModel).ToList();

            return itensCarrinho;
        }

        public void SalvarCarrinho()
        {
             _context.SaveChanges();
        }
    }
}