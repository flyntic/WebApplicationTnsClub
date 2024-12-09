import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NewsDetailComponent } from './news-detail/news-detail.component';
import { NewsEditComponent }   from './news-edit/news-edit.component';
import { NewsFormComponent }   from './news-form/news-form.component';
import { NewsListComponent }   from './news-list/news-list.component';
import { NewsCreateComponent } from './news-create/news-create.component';


import { NewsDataService } from './../../shared/data.services/news.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        NewsCreateComponent,
        NewsListComponent,
        NewsDetailComponent,
        NewsEditComponent,
        NewsFormComponent
    ],
    exports: [
        NewsListComponent,
        NewsEditComponent,
        NewsCreateComponent],
    providers: [NewsDataService, FileService]
})
export class NewsModule { }
