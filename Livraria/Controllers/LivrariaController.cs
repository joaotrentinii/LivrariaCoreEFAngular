using Livraria.Models;
using Livraria.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Controllers
{
    [Route("api/[controller]")]
    public class LivrariaController : Controller
    {
        private readonly ILivroService _livroService;

        public LivrariaController(ILivroService livroService)
        {
            this._livroService = livroService;
        }

        [HttpGet("[action]")]
        public IEnumerable<Livro> ObterLivros()
        {
            return Enumerable.Range(1, 2).Select(livro => new Livro
            {
                LivroId = 1,
                Autor = new Autor()
                {
                    AutorId = 1,
                    DataNascimento = new System.DateTime(1994,08,08),
                    Nome = "João Paulo Trentini da Silva"
                },
                Titulo = "O Livro dos Escolhidos",
                QuantidadePaginas = 999
            });
        }
    }
}
