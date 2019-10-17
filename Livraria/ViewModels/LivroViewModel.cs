using System;
using System.ComponentModel.DataAnnotations;

namespace Livraria.ViewModels
{
    public class LivroViewModel
    {
        public int LivroId { get; set; }

        public string Titulo { get; set; }

        public int QuantidadePaginas { get; set; }

        public string NomeDoAutor { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataDaPublicacao { get; set; }
    }
}
