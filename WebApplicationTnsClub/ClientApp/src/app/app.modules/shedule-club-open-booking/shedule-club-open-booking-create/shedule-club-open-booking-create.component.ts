import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SheduleClubOpenBookingDataService } from './../../../shared/data.services/shedule-club-open-booking.data.service';
import { SheduleClubOpenBooking } from './../shedule-club-open-booking';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './shedule-club-open-booking-create.component.html',
    styleUrl: './shedule-club-open-booking-create.component.css',

})
export class SheduleClubOpenBookingCreateComponent implements OnInit {

    item: SheduleClubOpenBooking = new SheduleClubOpenBooking();    // добавляемый объект

    constructor(private dataService: SheduleClubOpenBookingDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createSheduleClubOpenBooking(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}
