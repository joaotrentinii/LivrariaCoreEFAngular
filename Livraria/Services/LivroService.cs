using AutoMapper;
using Livraria.Data.Repository.Interfaces;
using Livraria.Models;
using Livraria.Services.Interfaces;
using Livraria.ViewModels;
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

        public IEnumerable<LivroViewModel> GetAll()
        {
            var livros = _mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_livroRepository.BuscarTodos());
            return livros;
        }

        public LivroViewModel Get(int id)
        {
            ValidarIdEntity(id);
            var livro = _livroRepository.BuscarPorId(id);
            ValidarEntity(livro);

            return _mapper.Map<LivroViewModel>(livro);
        }        

        public void Add(LivroViewModel viewModel)
        {
            var livro = _mapper.Map<Livro>(viewModel);
            ValidarEntity(livro);
            _livroRepository.Adicionar(livro);
        }

        public void Delete(int id)
        {
            var livro = _livroRepository.BuscarPorId(id);
            ValidarEntity(livro);
            _livroRepository.Deletar(livro);            
        }        

        public void Update(LivroViewModel viewModel)
        {
            var livro = _mapper.Map<Livro>(viewModel);
            ValidarEntity(livro);
            _livroRepository.Alterar(livro);           
        }
    }
}
