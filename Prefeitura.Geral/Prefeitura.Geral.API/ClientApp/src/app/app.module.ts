import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './core/components/nav-menu/nav-menu.component';
import { FooterComponent } from './core/components/footer/footer.component';
import { NavBarComponent } from './core/components/nav-bar/nav-bar.component';
import { BlogModule } from './pages/blog/blog.module';
import { CommonModule } from '@angular/common';
import { OuvidoriaComponent } from './pages/ouvidoria/ouvidoria.component';
import { HomeComponent } from './pages/home/home.component';
import { AutenticacaoComponent } from './pages/autenticacao/autenticacao.component';
import { IptuConsultaComponent } from './pages/iptu/iptu-consulta/iptu-consulta.component';
import { MgepComponent } from './pages/mgep/mgep.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    NavBarComponent,
    FooterComponent,
    HomeComponent,
    OuvidoriaComponent,
    MgepComponent,
    AutenticacaoComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule,
    BlogModule,
    FontAwesomeModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'autenticacao', component: AutenticacaoComponent },
      { path: 'ouvidoria', component: OuvidoriaComponent },
      { path: 'gestaoprojetos', component: MgepComponent },
      { path: 'blog', loadChildren: () => import('./pages/blog/blog.module').then(m => m.BlogModule) },
      { path: 'iptu', loadChildren: () => import('./pages/iptu/iptu.module').then(m => m.IptuModule) },
      { path: 'cidadao', loadChildren: () => import('./pages/iptu/iptu.module').then(m => m.IptuModule) },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }