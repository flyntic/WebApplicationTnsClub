import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ManagerDetailComponent } from './manager-detail/manager-detail.component';
import { ManagerEditComponent }   from './manager-edit/manager-edit.component';
import { ManagerFormComponent }   from './manager-form/manager-form.component';
import { ManagerListComponent }   from './manager-list/manager-list.component';
import { ManagerCreateComponent } from './manager-create/manager-create.component';


import { ManagerDataService } from './../../shared/data.services/manager.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        ManagerCreateComponent,
        ManagerListComponent,
        ManagerDetailComponent,
        ManagerEditComponent,
        ManagerFormComponent
    ],
    exports: [ManagerListComponent, ManagerEditComponent, ManagerCreateComponent],
    providers: [ManagerDataService, FileService]
})
export class ManagerModule { }
