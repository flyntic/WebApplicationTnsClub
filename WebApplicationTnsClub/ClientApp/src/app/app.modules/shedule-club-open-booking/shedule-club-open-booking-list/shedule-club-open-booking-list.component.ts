import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { SheduleClubOpenBookingDataService } from './../../../shared/data.services/shedule-club-open-booking.data.service';
import { FileService } from './../../../file.service';
import { SheduleClubOpenBooking } from './../shedule-club-open-booking';


@Component({
    styleUrl: './shedule-club-open-booking-list.component.css',
    templateUrl: './shedule-club-open-booking-list.component.html'
})

export class SheduleClubOpenBookingListComponent implements OnInit {

    items: SheduleClubOpenBooking[];

    constructor(private dataService: SheduleClubOpenBookingDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }

    load() {
        this.dataService.getSheduleClubOpenBookings().subscribe((data: SheduleClubOpenBooking[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteSheduleClubOpenBooking(id).subscribe(data => this.load());
    }
}

