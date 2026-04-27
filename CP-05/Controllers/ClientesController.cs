using Microsoft.AspNetCore.Mvc;

namespace CP_05.Controllers
{
    public class ClientesController : Controller
    {
        [HttpGet]

        public IActionResult Cadastro()

        {

            return View();

        }

        [HttpPost]

        public IActionResult Cadastro(ClienteViewModel cliente, string confirmacaoSenha)

        {

            if (cliente.Senha != confirmacaoSenha)

            {

                ModelState.AddModelError("Senha", "As senhas não coincidem.");

                return View(cliente);

            }

            // Hash da senha antes de salvar (exemplo simples, use Identity para produção)

            cliente.Senha = BCrypt.Net.BCrypt.HashPassword(cliente.Senha);

            _clienteRepositorio.Cadastrar(cliente);

            return RedirectToAction("Login");

        }

    }
}
