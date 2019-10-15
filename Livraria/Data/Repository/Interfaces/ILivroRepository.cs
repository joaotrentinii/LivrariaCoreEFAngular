using Livraria.Models;
using System.Collections.Generic;

namespace Livraria.Data.Repository.Interfaces
{
    public interface ILivroRepository
    {
        void Add(Livro livro);
        void Deletar(int id);
        void Alterar(Livro livro);
        Livro BuscarPorId(int id);
        IEnumerable<Livro> BuscarTodos();
    }
}
