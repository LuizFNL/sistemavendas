using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistemavendas.Models;
using sistemavendas.Repositories;

namespace sistemavendas.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IItensRepositorio _repositorio;

    public HomeController(ILogger<HomeController> logger, IItensRepositorio repositorio)
    {
        _logger = logger;
        _repositorio = repositorio;
    }

    public async Task<IActionResult> Index()
    {
        var itensDB = await _repositorio.ListarTodos();

        return View(itensDB);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
