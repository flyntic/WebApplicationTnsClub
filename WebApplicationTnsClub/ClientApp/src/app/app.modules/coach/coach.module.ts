import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CoachDetailComponent } from './coach-detail/coach-detail.component';
import { CoachEditComponent }   from './coach-edit/coach-edit.component';
import { CoachFormComponent }   from './coach-form/coach-form.component';
import { CoachListComponent }   from './coach-list/coach-list.component';
import { CoachCreateComponent } from './coach-create/coach-create.component';


import { CoachDataService } from './../../shared/data.services/coach.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        CoachCreateComponent,
        CoachListComponent,
        CoachDetailComponent,
        CoachEditComponent,
        CoachFormComponent
    ],
    exports: [CoachListComponent, CoachEditComponent, CoachCreateComponent],
    providers: [CoachDataService, FileService]
})
export class CoachModule { }
