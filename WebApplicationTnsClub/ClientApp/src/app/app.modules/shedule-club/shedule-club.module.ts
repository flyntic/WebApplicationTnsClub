import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SheduleClubDetailComponent } from './shedule-club-detail/shedule-club-detail.component';
import { SheduleClubEditComponent }   from './shedule-club-edit/shedule-club-edit.component';
import { SheduleClubFormComponent }   from './shedule-club-form/shedule-club-form.component';
import { SheduleClubListComponent }   from './shedule-club-list/shedule-club-list.component';
import { SheduleClubCreateComponent } from './shedule-club-create/shedule-club-create.component';


import { SheduleClubDataService } from './../../shared/data.services/shedule-club.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        SheduleClubCreateComponent,
        SheduleClubListComponent,
        SheduleClubDetailComponent,
        SheduleClubEditComponent,
        SheduleClubFormComponent
    ],
    exports: [
        SheduleClubListComponent,
        SheduleClubEditComponent,
        SheduleClubCreateComponent],
    providers: [SheduleClubDataService, FileService]
})
export class SheduleClubModule { }
