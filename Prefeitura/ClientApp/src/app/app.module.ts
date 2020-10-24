import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './core/components/nav-menu/nav-menu.component';
import { FooterComponent } from './core/components/footer/footer.component';
import { NavBarComponent } from './core/components/nav-bar/nav-bar.component';
import { BlogModule } from './blog/blog.module';
import { OuvidoriaComponent } from './ouvidoria/ouvidoria.component';
import { CommonModule } from '@angular/common';
import { BlogPostListComponent } from './blog/blog-post-list/blog-post-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    NavBarComponent,
    FooterComponent,
    HomeComponent,
    OuvidoriaComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    CommonModule,
    BlogModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'ouvidoria', component: OuvidoriaComponent },
      { path: 'blog', outlet: '', loadChildren: () => import('./blog/blog.module').then(m => m.BlogModule) },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
