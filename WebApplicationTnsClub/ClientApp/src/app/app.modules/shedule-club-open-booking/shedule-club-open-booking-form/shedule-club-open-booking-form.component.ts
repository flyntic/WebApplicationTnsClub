import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { SheduleClubOpenBooking } from './../shedule-club-open-booking';
import { SheduleClubOpenBookingDataService } from './../../../shared/data.services/shedule-club-open-booking.data.service';


@Component({
    selector: "shedule-club-open-booking-form",
    styleUrl: './shedule-club-open-booking-form.component.css',
    templateUrl: './shedule-club-open-booking-form.component.html'
})

export class SheduleClubOpenBookingFormComponent {
    @Input() item: SheduleClubOpenBooking;
    constructor(public dataService: SheduleClubOpenBookingDataService, private http: HttpClient) { console.log(http); }
   
}