import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BlogPostComponent } from './blog-post/blog-post.component';

@NgModule({
  declarations: [
    BlogPostComponent,
  ],
  imports: [
    FormsModule,
  ],
  exports: [
    BlogPostComponent
  ],
  providers: [],
})
export class BlogModule { }
