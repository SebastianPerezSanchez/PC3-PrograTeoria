using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC3_PrograTeoria.Models;
using PC3_PrograTeoria.Data;


namespace PC3_PrograTeoria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BuscoContext _context;


        public HomeController(ILogger<HomeController> logger, BuscoContext context)
        {

            _logger = logger;
            _context = context;            
        }

        public IActionResult Index()
        {
            DateTime fechaComparar = DateTime.Now;
            fechaComparar = fechaComparar.AddDays(-7);

            var productos = _context.Productos.Where(x => x.Date > fechaComparar).ToList();
            return View(productos);
        }

        public IActionResult Registrar() {
            return View();
        }

        [HttpPost]
         public IActionResult Registrar(Producto producto) {
            if(ModelState.IsValid) {
                _context.Add(producto);
                _context.SaveChanges();

                return Redirect("Index");
            }
            return View();
        }

        public IActionResult Details(int Id = 0)
        {
            Producto detalle = _context.Productos.Find(Id);
            return View(detalle);
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
}
