import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { BookingDataService } from './../../../../shared/data.services/booking.data.services/booking.data.service';
import { Booking } from './../booking';


@Component({

    styleUrl: './booking-edit.component.css',
    templateUrl: './booking-edit.component.html',

})
export class BookingEditComponent implements OnInit {

    id: string;
    item: Booking;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: BookingDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getBooking(this.id)
                .subscribe((data: Booking) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateBooking(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

