using Livraria.Data.Context;
using Livraria.Data.Repository.Interfaces;
using Livraria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Data.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private readonly LivrariaContext _livrariaContext;

        public LivroRepository(LivrariaContext livrariaContext)
        {
            this._livrariaContext = livrariaContext;
        }

        public void Adicionar(Livro livro)
        {
            _livrariaContext.Add(livro);
            SalvarAlteracao();
        }        

        public void Alterar(Livro livro)
        {
            var livroEntity = _livrariaContext.Livro.Where(l => l.LivroId == livro.LivroId).FirstOrDefault();

            if (livroEntity == null)
                throw new ArgumentException("Não foi possível atualizar o livro, pois não foi encontrado um livro com o id informado.");

            AplicarAlteracoesLivro(livro, livroEntity);            
        }        

        public Livro BuscarPorId(int id)
        {
            return _livrariaContext.Livro.AsNoTracking().Where(l => l.LivroId == id).FirstOrDefault();
        }

        public IEnumerable<Livro> BuscarTodos()
        {
            return _livrariaContext.Livro;
        }

        public void Deletar(Livro livro)
        {
            _livrariaContext.Livro.Remove(livro);
            SalvarAlteracao();
        }

        private void SalvarAlteracao()
        {
            _livrariaContext.SaveChanges();
        }

        private void AplicarAlteracoesLivro(Livro livro, Livro livroEntity)
        {
            livroEntity.DataDaPublicacao = livro.DataDaPublicacao;
            livroEntity.QuantidadePaginas = livro.QuantidadePaginas;
            livroEntity.Titulo = livro.Titulo;
            livroEntity.NomeDoAutor = livro.NomeDoAutor;

            SalvarAlteracao();
        }
    }
}
