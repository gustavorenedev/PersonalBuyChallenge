using Microsoft.AspNetCore.Mvc;
using PersonalBuy.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using PersonalBuy.Models;

namespace PersonalBuy.Controllers
{
    public class CategoriaProdutoController : Controller
    {
        private readonly DataContext _dataContext;

        public CategoriaProdutoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var primeiraCategoria = _dataContext.CategoriaProdutos.FirstOrDefault();

            if (primeiraCategoria != null)
            {
                return View(primeiraCategoria);
            }

            return View();
        }
    }
}
