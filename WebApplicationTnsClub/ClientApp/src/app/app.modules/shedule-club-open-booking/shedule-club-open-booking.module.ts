import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SheduleClubOpenBookingDetailComponent } from './shedule-club-open-booking-detail/shedule-club-open-booking-detail.component';
import { SheduleClubOpenBookingEditComponent } from './shedule-club-open-booking-edit/shedule-club-open-booking-edit.component';
import { SheduleClubOpenBookingFormComponent } from './shedule-club-open-booking-form/shedule-club-open-booking-form.component';
import { SheduleClubOpenBookingListComponent } from './shedule-club-open-booking-list/shedule-club-open-booking-list.component';
import { SheduleClubOpenBookingCreateComponent } from './shedule-club-open-booking-create/shedule-club-open-booking-create.component';


import { SheduleClubOpenBookingDataService } from './../../shared/data.services/shedule-club-open-booking.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        SheduleClubOpenBookingCreateComponent,
        SheduleClubOpenBookingListComponent,
        SheduleClubOpenBookingDetailComponent,
        SheduleClubOpenBookingEditComponent,
        SheduleClubOpenBookingFormComponent
    ],
    exports: [
        SheduleClubOpenBookingListComponent,
        SheduleClubOpenBookingEditComponent,
        SheduleClubOpenBookingCreateComponent],
    providers: [SheduleClubOpenBookingDataService, FileService]
})
export class SheduleClubOpenBookingModule { }
