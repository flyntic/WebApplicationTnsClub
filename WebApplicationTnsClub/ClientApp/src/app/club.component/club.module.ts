import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ClubCreateComponent } from './club-create/club-create.component';
import { ClubListComponent }   from './club-list/club-list.component';
import { ClubDetailComponent } from './club-detail/club-detail.component';
import { ClubEditComponent }   from './club-edit/club-edit.component';
import { ClubFormComponent }   from './club-form/club-form.component';

import { DataService } from './../data.service';
import { FileService } from './../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule,],
    declarations: [ClubCreateComponent,
                   ClubListComponent ,
                   ClubDetailComponent,
                   ClubEditComponent ,
                   ClubFormComponent 
    ],
    exports: [ClubListComponent, ClubEditComponent, ClubCreateComponent],
    providers: [DataService,FileService]
})
export class UserModule { }


