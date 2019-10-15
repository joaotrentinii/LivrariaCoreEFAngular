import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-livros',
  templateUrl: './livros.html'
})

export class LivrosComponent {
  public livros: ILivro[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<ILivro[]>(baseUrl + 'api/Livraria/ObterLivros').subscribe(result => {
      this.livros = result;
    }, error => console.error(error));
  }
}

interface ILivro {
  livroId: number;
  titulo: string;
  quantidadePaginas: number;
  autor: IAutor;
}

interface IAutor {
  autorId: number;
  nome: string;
  dataNascimento: Date;
}
