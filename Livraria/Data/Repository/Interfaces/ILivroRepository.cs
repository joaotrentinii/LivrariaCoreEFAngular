using Livraria.Models;
using System.Collections.Generic;

namespace Livraria.Data.Repository.Interfaces
{
    public interface ILivroRepository
    {
        void Adicionar(Livro livro);
        void Deletar(Livro livro);
        void Alterar(Livro livro);
        Livro BuscarPorId(int id);
        IEnumerable<Livro> BuscarTodos();
    }
}
