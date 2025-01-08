using GraficosASPNETMVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace GraficosASPNETMVC.Controllers
{
    public class VendasController : Controller
    {
        private readonly AppDbContext _context;

        public VendasController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }








    }
}
