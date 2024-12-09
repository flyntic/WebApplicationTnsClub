import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SheduleClubOpenBookingDataService } from './../../../shared/data.services/shedule-club-open-booking.data.service';
import { SheduleClubOpenBooking } from './../shedule-club-open-booking';

@Component({
    templateUrl: './shedule-club-open-booking-detail.component.html',
    styleUrl: './shedule-club-open-booking-detail.component.css',
})

export class SheduleClubOpenBookingDetailComponent implements OnInit {

    id: string;
    item: SheduleClubOpenBooking;
    loaded: boolean = false;

    constructor(private dataService: SheduleClubOpenBookingDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getSheduleClubOpenBooking(this.id)
                .subscribe((data: SheduleClubOpenBooking) => { this.item = data; this.loaded = true; });
    }
}
