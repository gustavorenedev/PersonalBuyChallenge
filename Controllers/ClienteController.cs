using Microsoft.AspNetCore.Mvc;
using PersonalBuy.Data;
using PersonalBuy.DTOs;
using PersonalBuy.Models;

namespace PersonalBuy.Controllers
{
    public class ClienteController : Controller
    {
        private readonly DataContext _dataContext;

        public ClienteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult EfetuarLogin(LoginDTO request)
        {
            var getUser = _dataContext.Clientes.FirstOrDefault(x => x.Email == request.Email);

            if (getUser == null)
            {
                ViewBag.ErrorMessage = "Email não encontrado.";
                return View("Login");
            }

            return RedirectToAction("Index", "Home");
        }


        public IActionResult CadastroPage()
        {
            return View();
        }

        public async Task<IActionResult> EfetuarCadastro(CadastroClienteDTO request)
        {
            var getCliente = _dataContext.Clientes.FirstOrDefault(x => x.Email == request.Email);
            if (getCliente != null)
            {
                return BadRequest();
            }

            Cliente newCliente = new Cliente
            {
                Nome = request.Nome,
                Cpf = request.Cpf,
                Email = request.Email,
                Telefone = request.Telefone,
                Endereco = request.Endereco,
                Cep = request.Cep,
            };

            _dataContext.Clientes.Add(newCliente);
            await _dataContext.SaveChangesAsync();

            return RedirectToAction("Login", "Cliente");
        }
    }
}
