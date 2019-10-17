import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { LivrosComponent } from './livros/livros.component';
import { LivroComponent } from './livros/livro/livro.component';
import { LivrosListComponent } from './livros/livros-list/livros-list.component';
import { LivrosService } from './services/livros.service';

@NgModule({
  declarations: [
    AppComponent,
    LivrosComponent,
    LivroComponent,
    LivrosListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule    
  ],
  providers: [LivrosService],
  bootstrap: [AppComponent]
})
export class AppModule { }
