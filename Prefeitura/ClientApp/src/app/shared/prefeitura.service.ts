import { Component, Inject } from '@angular/core';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NoticiaModel } from './models/noticia.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PrefeituraService {

  constructor(
    private httpClient: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) {
  }

  pesquisaNoticias(numeroPagina: number, tamanhoPagina: number, data: string): Observable<NoticiaModel[]> {
    return this.httpClient.get<NoticiaModel[]>(`${this.baseUrl}noticias?numeroPagina=${numeroPagina}&tamanhoPagina=${tamanhoPagina}`);
  }

  pesquisaNoticia(id: string): Observable<NoticiaModel> {
    console.log(this.baseUrl);
    return this.httpClient.get<NoticiaModel>(`${this.baseUrl}noticias/${id}`);
  }
}
