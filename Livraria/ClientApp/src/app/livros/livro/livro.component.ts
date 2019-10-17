import { LivrosService } from '../../services/livros.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-livro',
  templateUrl: './livro.component.html',
  styles: []
})

export class LivroComponent implements OnInit {

  constructor(private service: LivrosService) { }

  ngOnInit() {
    this.resetForm();
  }


  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();

    this.service.livro = {
      livroId: 0,
      nomeDoAutor: '',
      titulo: '',
      quantidadePaginas: null,
      dataDaPublicacao: null
    }
  }

  onSubmit(form: NgForm) {
    if (this.service.livro.livroId == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postLivro().subscribe(
      res => {
        debugger;
        this.resetForm(form);
        this.service.refreshList();
      },
      err => {
        debugger;
        console.log(err);
      }
    )
  }

  updateRecord(form: NgForm) {
    this.service.putLivro().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    )
  }

}
