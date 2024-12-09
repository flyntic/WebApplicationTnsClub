import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BookingDataService } from './../../../shared/data.services/booking.data.service';
import { Booking } from './../booking';

@Component({
    templateUrl: './booking-detail.component.html',
    styleUrl: './booking-detail.component.css',
})

export class BookingDetailComponent implements OnInit {

    id: string;
    item: Booking;
    loaded: boolean = false;

    constructor(private dataService: BookingDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getBooking(this.id)
                .subscribe((data: Booking) => { this.item = data; this.loaded = true; });
    }
}

