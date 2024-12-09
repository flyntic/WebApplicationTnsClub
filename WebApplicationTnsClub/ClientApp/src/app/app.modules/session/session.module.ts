import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SessionDetailComponent } from './session-detail/session-detail.component';
import { SessionEditComponent }   from './session-edit/session-edit.component';
import { SessionFormComponent }   from './session-form/session-form.component';
import { SessionListComponent }   from './session-list/session-list.component';
import { SessionCreateComponent } from './session-create/session-create.component';


import { SessionDataService } from './../../shared/data.services/session.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        SessionCreateComponent,
        SessionListComponent,
        SessionDetailComponent,
        SessionEditComponent,
        SessionFormComponent
    ],
    exports: [
        SessionListComponent,
        SessionEditComponent,
        SessionCreateComponent],
    providers: [SessionDataService, FileService]
})
export class SessionModule { }
