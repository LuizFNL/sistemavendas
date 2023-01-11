using Microsoft.AspNetCore.Mvc;
using sistemavendas.Repositories;

namespace sistemavendas.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly ILogger<CarrinhoController> _logger;

        private readonly IItensRepositorio _repositorioItens;
        private readonly ICarrinhoRepositorio _repositorioCarrinho;

        public CarrinhoController(ILogger<CarrinhoController> logger,
                                IItensRepositorio repositorioItens,
                                ICarrinhoRepositorio repositorioCarrinho)
        {
            _logger = logger;
            _repositorioItens = repositorioItens;
            _repositorioCarrinho = repositorioCarrinho;
        }

        public IActionResult Index()
        {
            var itensCarrinho = _repositorioCarrinho.ListarItensCarrinho();

            TempData["ValorTotal"] = _repositorioCarrinho.CalcularValorCarrinho();

            return View(itensCarrinho);
        }

        public IActionResult AdicionarAoCarrinho(int id)
        {
            var carrinho = _repositorioCarrinho.Adicionar(id);
            _repositorioCarrinho.SalvarCarrinho();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeletarDoCarrinho(int id)
        {
            _repositorioCarrinho.Deletar(id);
            _repositorioCarrinho.SalvarCarrinho();

            return RedirectToAction(nameof(Index));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}