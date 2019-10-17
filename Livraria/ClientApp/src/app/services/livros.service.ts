import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { LivroModel } from "./../livros/livro/livro-model";

@Injectable()
export class LivrosService {
  livro: LivroModel;
  livros: LivroModel[];
  readonly baseUrl = 'https://localhost:44342/api';

  constructor(private http: HttpClient) { }

  postLivro() {
    return this.http.post(this.baseUrl + '/Livraria', this.livro);
  }

  putLivro() {
    return this.http.put(this.baseUrl + '/Livraria/' + this.livro.livroId, this.livro);
  }

  deleteLivro(livroId: number) {
    return this.http.delete(this.baseUrl + '/Livraria/' + livroId);
  }

  refreshList() {
    this.http.get(this.baseUrl + '/Livraria')
      .toPromise()
      .then(res => this.livros = res as LivroModel[]);
  }
}
