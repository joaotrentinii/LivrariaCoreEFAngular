import { LivroModel } from '../livro/livro-model';
import { LivrosService } from './../../services/livros.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-livros-list',
  templateUrl: './livros-list.component.html',
  styles: []
})

export class LivrosListComponent implements OnInit {

  constructor(private service: LivrosService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(livro: LivroModel) {
    this.service.livro = Object.assign({}, livro);
  }

  onDelete(livroId: number) {
    if (confirm('Tem certeza que deseja deletar este Livro?')) {
      this.service.deleteLivro(livroId)
        .subscribe(res => {
          debugger;
          this.service.refreshList();
        },
          err => {
            debugger;
            console.log(err);
          })
    }
  }
}
