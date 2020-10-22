import { Component, OnInit } from '@angular/core';
import { NoticiaModel } from 'src/app/shared/models/noticia.model';
import { PrefeituraService } from 'src/app/shared/prefeitura.service';

@Component({
  selector: 'app-blog-post',
  templateUrl: './blog-post.component.html',
  styleUrls: ['./blog-post.component.css']
})
export class BlogPostComponent  implements OnInit {

  noticias: NoticiaModel[] = [];

  constructor(
    private prefeituraService: PrefeituraService
  ) { }

  ngOnInit() {
    this.pesquisaNoticias(1, 10);
  }

  pesquisaNoticias(numeroPagina: number, tamanhoPagina: number) {
    this.prefeituraService.pesquisaNoticias(numeroPagina, tamanhoPagina, '')
      .subscribe(
        result => {
          this.noticias = result;
        }
    );
  }
}
