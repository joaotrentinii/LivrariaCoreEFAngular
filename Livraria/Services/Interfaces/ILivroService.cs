using Livraria.ViewModels;
using System.Collections.Generic;

namespace Livraria.Services.Interfaces
{
    public interface ILivroService
    {
        void Add(LivroViewModel viewModel);
        void Update(LivroViewModel viewModel);
        void Delete(int id);
        LivroViewModel Get(int id);
        IEnumerable<LivroViewModel> GetAll();
    }
}
