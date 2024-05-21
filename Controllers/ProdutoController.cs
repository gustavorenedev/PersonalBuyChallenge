using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PersonalBuy.Data;
using PersonalBuy.DTOs;
using PersonalBuy.Models;
using System.Linq;

namespace PersonalBuy.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly DataContext _dataContext;

        public ProdutoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult EfetuarCadastro(CadastroProdutoDTO request)
        {
            Produto newProduto = new Produto()
            {
                NomeProduto = request.NomeProduto,
                DescricaoProduto = request.DescricaoProduto,
                CategoriaProduto = request.CategoriaProduto,
                PrecoProduto = request.PrecoProduto,
            };

            _dataContext.Produtos.Add(newProduto);
            _dataContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var produtos = _dataContext.Produtos.ToList();
            return View(produtos);
        }

        public IActionResult Detalhes(int id)
        {
            var produto = _dataContext.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        public IActionResult Editar(int id)
        {
            var produto = _dataContext.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        [HttpPost]
        public IActionResult Editar(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }

            _dataContext.Entry(produto).State = EntityState.Modified;
            _dataContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Excluir(int id)
        {
            var produto = _dataContext.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        [HttpPost, ActionName("Excluir")]
        public IActionResult ConfirmarExclusao(int id)
        {
            var produto = _dataContext.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto == null)
            {
                return NotFound();
            }

            _dataContext.Produtos.Remove(produto);
            _dataContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
