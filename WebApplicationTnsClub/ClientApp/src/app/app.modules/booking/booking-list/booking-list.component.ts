import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { BookingDataService } from './../../../shared/data.services/booking.data.service';
import { FileService } from './../../../file.service';
import { Booking } from './../booking';


@Component({

    styleUrl: './booking-list.component.css',
    templateUrl: './booking-list.component.html'
})
export class BookingListComponent implements OnInit {

    items: Booking[];


    constructor(private dataService: BookingDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getBookings().subscribe((data: Booking[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteBooking(id).subscribe(data => this.load());
    }
}

