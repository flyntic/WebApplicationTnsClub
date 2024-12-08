import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AdminDetailComponent } from './admin-detail/admin-detail.component';
import { AdminEditComponent }   from './admin-edit/admin-edit.component';
import { AdminFormComponent }   from './admin-form/admin-form.component';
import { AdminListComponent }   from './admin-list/admin-list.component';
import { AdminCreateComponent } from './admin-create/admin-create.component';


import { DataService } from './../../data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        AdminCreateComponent,
        AdminListComponent,
        AdminDetailComponent,
        AdminEditComponent,
        AdminFormComponent
    ],
    exports: [AdminListComponent, AdminEditComponent, AdminCreateComponent],
    providers: [DataService, FileService]
})
export class AdminModule { }
