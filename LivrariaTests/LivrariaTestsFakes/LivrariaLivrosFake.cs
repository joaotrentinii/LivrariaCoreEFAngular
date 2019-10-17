using Livraria.Models;
using Livraria.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LivrariaTests.LivrariaTestsFakes
{
    public static class LivrariaLivrosFake
    {
        public static IQueryable<Livro> LivrosFake
        {
            get
            {
                return new List<Livro>
                {
                    new Livro
                    {
                        LivroId = 1,
                        Titulo = "Título Livro Fake",
                        NomeDoAutor = "Nome do Autor Fake",
                        DataDaPublicacao = new DateTime(2018, 01, 01),
                        QuantidadePaginas = 201
                    },
                    new Livro
                    {
                        LivroId = 2,
                        Titulo = "Título Livro Fake 02",
                        NomeDoAutor = "Nome do Autor Fake 02",
                        DataDaPublicacao = new DateTime(2018, 02, 02),
                        QuantidadePaginas = 202
                    },
                    new Livro
                    {
                        LivroId = 3,
                        Titulo = "Título Livro Fake 03",
                        NomeDoAutor = "Nome do Autor Fake 03",
                        DataDaPublicacao = new DateTime(2018, 03, 03),
                        QuantidadePaginas = 203
                    }
                }.AsQueryable();
            }
        }

        public static Livro LivroFake
        {
            get
            {
                return new Livro
                {
                    LivroId = 999,
                    Titulo = "Título Livro Fake 999",
                    NomeDoAutor = "Nome do Autor Fake 999",
                    DataDaPublicacao = new DateTime(2018, 12, 31),
                    QuantidadePaginas = 999
                };
            }
        }

        public static IQueryable<Livro> LivroQueryableFake
        {
            get
            {
                return new List<Livro>
                {
                    new Livro
                    {
                        LivroId = 100,
                        Titulo = "Título Livro Fake 100",
                        NomeDoAutor = "Nome do Autor Fake 100",
                        DataDaPublicacao = new DateTime(2018, 04, 04),
                        QuantidadePaginas = 100
                    }
                }.AsQueryable();
            }
        }

        public static IQueryable<LivroViewModel> LivrosViewFake
        {
            get
            {
                return new List<LivroViewModel>
                {
                    new LivroViewModel
                    {
                        LivroId = 1,
                        Titulo = "Título Livro Fake",
                        NomeDoAutor = "Nome do Autor Fake",
                        DataDaPublicacao = new DateTime(2018, 01, 01),
                        QuantidadePaginas = 201
                    },
                    new LivroViewModel
                    {
                        LivroId = 2,
                        Titulo = "Título Livro Fake 02",
                        NomeDoAutor = "Nome do Autor Fake 02",
                        DataDaPublicacao = new DateTime(2018, 02, 02),
                        QuantidadePaginas = 202
                    },
                    new LivroViewModel
                    {
                        LivroId = 3,
                        Titulo = "Título Livro Fake 03",
                        NomeDoAutor = "Nome do Autor Fake 03",
                        DataDaPublicacao = new DateTime(2018, 03, 03),
                        QuantidadePaginas = 203
                    }
                }.AsQueryable();
            }
        }
    }
}
