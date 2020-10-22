import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BlogPostComponent } from './blog-post/blog-post.component';
import { BlogSideComponent } from './blog-side/blog-side.component';

@NgModule({
  declarations: [
    BlogPostComponent,
    BlogSideComponent
  ],
  imports: [
    FormsModule,
    CommonModule,
  ],
  exports: [
    BlogPostComponent,
    BlogSideComponent
  ],
  providers: [],
})
export class BlogModule { }
