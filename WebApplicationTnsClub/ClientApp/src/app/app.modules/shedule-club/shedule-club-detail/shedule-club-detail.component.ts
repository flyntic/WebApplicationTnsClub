import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SheduleClubDataService } from './../../../shared/data.services/shedule-club.data.service';
import { SheduleClub } from './../shedule-club';

@Component({
    templateUrl: './shedule-club-detail.component.html',
    styleUrl: './shedule-club-detail.component.css',
})

export class SheduleClubDetailComponent implements OnInit {

    id: string;
    item: SheduleClub;
    loaded: boolean = false;

    constructor(private dataService: SheduleClubDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getSheduleClub(this.id)
                .subscribe((data: SheduleClub) => { this.item = data; this.loaded = true; });
    }
}
