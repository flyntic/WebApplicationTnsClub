import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BookingCreateComponent } from './booking-create/booking-create.component';
import { BookingListComponent } from './booking-list/booking-list.component';
import { BookingDetailComponent } from './booking-detail/booking-detail.component';
import { BookingEditComponent } from './booking-edit/booking-edit.component';
import { BookingFormComponent } from './booking-form/booking-form.component';

import { BookingDataService } from './../../../shared/data.services/booking.data.services/booking.data.service';
import { FileService } from './../../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule,],
    declarations: [BookingCreateComponent,
        BookingListComponent,
        BookingDetailComponent,
        BookingEditComponent,
        BookingFormComponent
    ],
    exports: [BookingListComponent, BookingEditComponent, BookingCreateComponent],
    providers: [BookingDataService, FileService]
})
export class BookingModule { }
