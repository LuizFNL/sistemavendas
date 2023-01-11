using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistemavendas.Models;
using sistemavendas.Repositories;

namespace sistemavendas.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IItensRepositorio _repositorioItens;
    private readonly ICarrinhoRepositorio _repositorioCarrinho;

    public HomeController(ILogger<HomeController> logger, 
                            IItensRepositorio repositorioItens, 
                            ICarrinhoRepositorio repositorioCarrinho)
    {
        _logger = logger;
        _repositorioItens = repositorioItens;
        _repositorioCarrinho = repositorioCarrinho;
    }

    public IActionResult Index(string searchString="")
    {
        // var itensDB = await _repositorioItens.ListarTodos(); //Listar tudo

        var itens = _repositorioItens.Filtrar(searchString);

        return View(itens);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
