using System;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public partial class Autor
    {
        public int AutorId { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
