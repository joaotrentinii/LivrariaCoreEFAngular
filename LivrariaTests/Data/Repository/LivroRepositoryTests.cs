using Livraria.Data.Context;
using Livraria.Data.Repository;
using Livraria.Data.Repository.Interfaces;
using Livraria.Models;
using LivrariaTests.LivrariaTestsFakes;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace Data.Repository
{
    public class LivroRepositoryTests
    {        
        private ILivroRepository _livroRepository;
        private IQueryable<Livro> _listaLivros;
        private Mock<DbSet<Livro>> _mockSet;
        private Mock<LivrariaContext> _mockContext;        

        [SetUp]
        public void Setup()
        {
            _listaLivros = LivrariaLivrosFake.LivrosFake;

            _mockSet = new Mock<DbSet<Livro>>();
            _mockSet.As<IQueryable<Livro>>().Setup(m => m.Provider).Returns(_listaLivros.Provider);
            _mockSet.As<IQueryable<Livro>>().Setup(m => m.Expression).Returns(_listaLivros.Expression);
            _mockSet.As<IQueryable<Livro>>().Setup(m => m.ElementType).Returns(_listaLivros.ElementType);
            _mockSet.As<IQueryable<Livro>>().Setup(m => m.GetEnumerator()).Returns(_listaLivros.GetEnumerator());

            _mockContext = new Mock<LivrariaContext>();
            _mockContext.Setup(c => c.Livro).Returns(_mockSet.Object);
            
            _livroRepository = new LivroRepository(_mockContext.Object);
        }

        [Test]
        public void Deve_buscar_todos_os_livros()
        {        
            var livros = _livroRepository.BuscarTodos().ToList();
            Assert.AreEqual(3, livros.Count());
            Assert.AreEqual(_listaLivros.First().Titulo, livros.First().Titulo);                        
        }

        [Test]
        public void Deve_adicionar_um_novo_livro()
        {
            var livroFake = LivrariaLivrosFake.LivroFake;
            _livroRepository.Adicionar(livroFake);

            _mockContext.Verify(m => m.Add(It.Is<Livro>(y => y.LivroId == livroFake.LivroId)));
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);            
        }

        [Test]
        public void Deve_buscar_o_livro_pelo_id()
        {
            var livro = LivrariaLivrosFake.LivroQueryableFake;
            
            _mockSet = new Mock<DbSet<Livro>>();
            _mockSet.As<IQueryable<Livro>>().Setup(m => m.Provider).Returns(livro.Provider);
            _mockSet.As<IQueryable<Livro>>().Setup(m => m.Expression).Returns(livro.Expression);
            _mockSet.As<IQueryable<Livro>>().Setup(m => m.ElementType).Returns(livro.ElementType);
            _mockSet.As<IQueryable<Livro>>().Setup(m => m.GetEnumerator()).Returns(livro.GetEnumerator());

            _mockContext = new Mock<LivrariaContext>();           
            _mockContext.Setup(c => c.Livro).Returns(_mockSet.Object);

            _livroRepository = new LivroRepository(_mockContext.Object);

            var livroEsperado = livro.First();
            var livroAtual = _livroRepository.BuscarPorId(livroEsperado.LivroId);

            Assert.AreEqual(livroEsperado, livroAtual);
        }
    }
}