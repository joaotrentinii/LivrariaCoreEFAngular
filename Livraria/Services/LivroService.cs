using AutoMapper;
using Livraria.Data.Repository.Interfaces;
using Livraria.Models;
using Livraria.Services.Interfaces;
using Livraria.ViewModels;
using System;
using System.Collections.Generic;

namespace Livraria.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IMapper _mapper;

        public LivroService(ILivroRepository livroRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this._livroRepository = livroRepository;
        }

        public void Add(LivroViewModel viewModel)
        {
            var livro = _mapper.Map<Livro>(viewModel);
            ValidarEntity(livro);
            _livroRepository.Add(livro);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public LivroViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(LivroViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
