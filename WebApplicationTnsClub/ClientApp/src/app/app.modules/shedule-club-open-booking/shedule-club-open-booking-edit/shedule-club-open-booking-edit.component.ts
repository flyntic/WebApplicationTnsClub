import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { SheduleClubOpenBookingDataService } from './../../../shared/data.services/shedule-club-open-booking.data.service';
import { SheduleClubOpenBooking } from './../shedule-club-open-booking';


@Component({

    styleUrl: './shedule-club-open-booking-edit.component.css',
    templateUrl: './shedule-club-open-booking-edit.component.html',

})
export class SheduleClubOpenBookingEditComponent implements OnInit {

    id: string;
    item: SheduleClubOpenBooking;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: SheduleClubOpenBookingDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getSheduleClubOpenBooking(this.id)
                .subscribe((data: SheduleClubOpenBooking) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateSheduleClubOpenBooking(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}
