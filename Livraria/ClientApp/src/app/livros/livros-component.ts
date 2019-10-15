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
  dataDaPublicacao: Date;
  quantidadePaginas: number;
  nomeDoAutor: string;
}
