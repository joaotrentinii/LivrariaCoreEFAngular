using Livraria.Services.Interfaces;
using Livraria.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        private readonly ILivroService _livroService;

        public LivrariaController(ILivroService livroService)
        {
            this._livroService = livroService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LivroViewModel>> ObterLivros()
        {
            return _livroService.GetAll() as List<LivroViewModel>;
        }

        [HttpGet("{id}")]
        public ActionResult<LivroViewModel> ObterLivroPeloId(int id)
        {
            return _livroService.Get(id);
        }

        [HttpPost]
        public ActionResult<LivroViewModel> AdicionarLivro(LivroViewModel viewModel)
        {
            _livroService.Add(viewModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<LivroViewModel> DeletarLivro(int id)
        {
            _livroService.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<LivroViewModel> AlterarLivro(int id, LivroViewModel viewModel)
        {
            _livroService.Update(viewModel);
            return Ok();
        }
    }
}
