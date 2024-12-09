import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { GroupDetailComponent } from './group-detail/group-detail.component';
import { GroupEditComponent }   from './group-edit/group-edit.component';
import { GroupFormComponent }   from './group-form/group-form.component';
import { GroupListComponent }   from './group-list/group-list.component';
import { GroupCreateComponent } from './group-create/group-create.component';


import { GroupDataService } from './../../shared/data.services/group.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        GroupCreateComponent,
        GroupListComponent,
        GroupDetailComponent,
        GroupEditComponent,
        GroupFormComponent
    ],
    exports: [
        GroupListComponent,
        GroupEditComponent,
        GroupCreateComponent],
    providers: [GroupDataService, FileService]
})
export class GroupModule { }
