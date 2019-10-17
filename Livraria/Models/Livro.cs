using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Models
{
    public class Livro
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int LivroId { get; set; }

        public string Titulo { get; set; }

        public int QuantidadePaginas { get; set; }

        public string NomeDoAutor { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataDaPublicacao { get; set; }
    }
}
