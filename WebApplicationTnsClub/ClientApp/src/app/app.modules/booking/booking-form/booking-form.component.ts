import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Booking } from './../booking';
import { BookingDataService } from './../../../shared/data.services/booking.data.service';


@Component({
    selector: "booking-form",
    styleUrl: './booking-form.component.css',
    templateUrl: './booking-form.component.html'
})

export class BookingFormComponent {
    @Input() item: Booking;
    constructor(public dataService: BookingDataService, private http: HttpClient) { console.log(http); }

}