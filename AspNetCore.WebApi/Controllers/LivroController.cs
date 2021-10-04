using AspNetCore.WebApi.Controllers.Shared;
using AspNetCore.WebApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCore.WebApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class LivroController : ApiController
    {
        [HttpGet("livro-nao-tipado")]
        public IActionResult ObterTodosNaoTipado()
        {
            var livros = Livro.ObterLivros();
            return Ok(livros);
        }
        [HttpGet("livro-tipado")]
        public IActionResult ObterTodosTipado()
        {
            var livros = Livro.ObterLivros();
            return Ok(livros);
        }
        /// <sumary>
        /// Obtém todos os livros
        /// </sumary>
        /// <returns> Retorna os livros encontrados </returns>
        /// <response code="200">Retorna os livros tipados</response>        
        [HttpGet("livro-nao-tipado")]
        public IActionResult ObterTodos()
        {
            var livros = Livro.ObterLivros();
            return ResponseOk(livros);
        }

    }
}