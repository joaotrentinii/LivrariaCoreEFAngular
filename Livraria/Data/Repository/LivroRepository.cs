using Livraria.Data.Context;
using Livraria.Data.Repository.Interfaces;
using Livraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Data.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private readonly LivrariaContext _livrariaContext;

        public LivroRepository(LivrariaContext livrariaContext)
        {
            this._livrariaContext = livrariaContext;
        }

        public void Add(Livro livro)
        {
            _livrariaContext.Add(livro);
            SalvarAlteracao();
        }        

        public void Alterar(Livro livro)
        {
            
        }

        public Livro BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        private void SalvarAlteracao()
        {
            _livrariaContext.SaveChanges();
        }
    }
}
