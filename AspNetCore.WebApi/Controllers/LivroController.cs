using AspNetCore.WebApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCore.WebApi.Controllers
{
    [ApiController]
    public class LivroController : ControllerBase
    {
        public IActionResult ObterTodosNaoTipado()
        {
            var livros = Livro.ObterLivros();
            return Ok(livros);
        }

    }
}