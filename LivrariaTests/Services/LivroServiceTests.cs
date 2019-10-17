using AutoMapper;
using Livraria.Data.Repository.Interfaces;
using Livraria.Models;
using Livraria.Services;
using Livraria.Services.Interfaces;
using Livraria.ViewModels;
using LivrariaTests.LivrariaTestsFakes;
using NSubstitute;
using NUnit.Framework;
using System.Linq;

namespace LivrariaTests.Services
{
    public class LivroServiceTests
    {
        private IQueryable<Livro> _listaLivros;
        private IQueryable<LivroViewModel> _listaLivrosView;
        private ILivroService _livroService;
        private ILivroRepository _livroRepository;

        [SetUp]
        public void Setup()
        {
            _listaLivros = LivrariaLivrosFake.LivrosFake;
            _listaLivrosView = LivrariaLivrosFake.LivrosViewFake;

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<LivroViewModel, Livro>();
                c.CreateMap<Livro, LivroViewModel>();
            });
            var mapper = config.CreateMapper();            

            _livroRepository = Substitute.For<ILivroRepository>();                

            _livroService = new LivroService(_livroRepository, mapper);
        }

        [Test]
        public void Deve_retornar_todos_os_livros()
        {
            _livroRepository.BuscarTodos().Returns(_listaLivros);
            var livrosEsperados = _listaLivrosView;
            var livrosRetornados = _livroService.GetAll();

            Assert.AreEqual(livrosEsperados.Count(), livrosRetornados.Count());            
            Assert.AreEqual(livrosEsperados.First().LivroId, livrosRetornados.First().LivroId);
            Assert.AreEqual(livrosEsperados.First().Titulo, livrosRetornados.First().Titulo);
            Assert.AreEqual(livrosEsperados.First().NomeDoAutor, livrosRetornados.First().NomeDoAutor);
        }

        [Test]
        public void Deve_retornar_o_livro_pelo_id()
        {
            _livroRepository.BuscarPorId(Arg.Any<int>()).Returns(_listaLivros.First());

            var livroEsperado = _listaLivrosView.First();
            var livroRetornado = _livroService.Get(livroEsperado.LivroId);

            Assert.AreEqual(livroEsperado.LivroId, livroRetornado.LivroId);
            Assert.AreEqual(livroEsperado.Titulo, livroRetornado.Titulo);
            Assert.AreEqual(livroEsperado.NomeDoAutor, livroRetornado.NomeDoAutor);
        }        
    }
}
