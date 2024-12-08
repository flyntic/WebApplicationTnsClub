import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ParentDetailComponent } from './parent-detail/parent-detail.component';
import { ParentEditComponent }   from './parent-edit/parent-edit.component';
import { ParentFormComponent }   from './parent-form/parent-form.component';
import { ParentListComponent }   from './parent-list/parent-list.component';
import { ParentCreateComponent } from './parent-create/parent-create.component';


import { DataService } from './../../data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        ParentCreateComponent,
        ParentListComponent,
        ParentDetailComponent,
        ParentEditComponent,
        ParentFormComponent
    ],
    exports: [ParentListComponent, ParentEditComponent, ParentCreateComponent],
    providers: [DataService, FileService]
})
export class ParentModule { }
