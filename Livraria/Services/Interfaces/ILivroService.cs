using Livraria.ViewModels;
using System.Collections.Generic;

namespace Livraria.Services.Interfaces
{
    public interface ILivroService
    {
        void Add(LivroViewModel viewModel);
        void Update(LivroViewModel viewModel);
        string Delete(LivroViewModel viewModel);
        LivroViewModel Get(int id);
        IEnumerable<LivroViewModel> GetAll();
    }
}
