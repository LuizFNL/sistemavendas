using Microsoft.AspNetCore.Mvc;
using sistemavendas.Repositories;

namespace sistemavendas.Controllers
{
    public class VendaController : Controller
    {
        private readonly ILogger<VendaController> _logger;
        private readonly IVendaRepositorio _vendaRepositorio;

        public VendaController(ILogger<VendaController> logger, IVendaRepositorio vendaRepositorio)
        {
            _logger = logger;
            _vendaRepositorio = vendaRepositorio;
        }

        public IActionResult Index()
        {
            TempData["Top1Total"] = _vendaRepositorio.Top1Total();
            TempData["Top1Dia"] = _vendaRepositorio.Top1Dia();
            TempData["Top1Mes"] = _vendaRepositorio.Top1Mes();

            return View(_vendaRepositorio.ListarVendas());
        }

        public IActionResult Comprar()
        {
            _vendaRepositorio.EfetuarCompra();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult BuscarVenda(int id)
        {
            return View(_vendaRepositorio.ItensVendidos(id));
        }        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}