import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AuthorDetailComponent } from './author-detail/author-detail.component';
import { AuthorEditComponent }   from './author-edit/author-edit.component';
import { AuthorFormComponent }   from './author-form/author-form.component';
import { AuthorListComponent }   from './author-list/author-list.component';
import { AuthorCreateComponent } from './author-create/author-create.component';


import { AuthorDataService } from './../../shared/data.services/author.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        AuthorCreateComponent,
        AuthorListComponent,
        AuthorDetailComponent,
        AuthorEditComponent,
        AuthorFormComponent
    ],
    exports: [AuthorListComponent, AuthorEditComponent, AuthorCreateComponent],
    providers: [AuthorDataService, FileService]
})
export class AuthorModule { }
