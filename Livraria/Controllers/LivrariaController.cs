using Livraria.Models;
using Livraria.Services.Interfaces;
using Livraria.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        public IEnumerable<LivroViewModel> ObterLivros()
        {
            return _livroService.GetAll();
        }

        [HttpGet("[action]")]
        public LivroViewModel ObterLivroPeloId(int id)
        {
            return _livroService.Get(id);
        }

        public string DeletarLivro(LivroViewModel viewModel)
        {
            return _livroService.Delete(viewModel);
        }

        public void AlterarLivro(LivroViewModel viewModel)
        {
            _livroService.Update(viewModel);
        }
    }
}
