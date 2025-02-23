import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule,RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UserDetailComponent } from './user-detail/user-detail.component';
import { UserEditComponent } from './user-edit/user-edit.component';
import { UserFormComponent } from './user-form/user-form.component';
import { UserListComponent } from './user-list/user-list.component';
import { UserCreateComponent } from './user-create/user-create.component';


import { UserDataService } from './../../../shared/data.services/user.data.services/user.data.service';
import { FileService } from './../../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, UserFormComponent, RouterLink,],
    declarations: [
        UserCreateComponent,
        UserListComponent,
        UserDetailComponent,
        UserEditComponent,
     //   UserFormComponent
    ],
    exports: [UserListComponent, UserEditComponent, UserCreateComponent],
    providers: [UserDataService, FileService]
})
export class UserModule { }
