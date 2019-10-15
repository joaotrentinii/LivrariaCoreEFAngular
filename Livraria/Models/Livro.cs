namespace Livraria.Models
{
    public class Livro
    {
        public int LivroId { get; set; }

        public string Titulo { get; set; }

        public int QuantidadePaginas { get; set; }

        public virtual Autor Autor { get; set; }

    }
}
