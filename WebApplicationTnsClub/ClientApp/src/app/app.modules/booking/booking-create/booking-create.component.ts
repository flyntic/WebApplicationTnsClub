import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { BookingDataService } from './../../../shared/data.services/booking.data.service';
import { Booking } from './../booking';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './booking-create.component.html',
    styleUrl: './booking-create.component.css',

})
export class BookingCreateComponent implements OnInit {

    item: Booking = new Booking();    // добавляемый объект

    constructor(private dataService: BookingDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createBooking(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}

