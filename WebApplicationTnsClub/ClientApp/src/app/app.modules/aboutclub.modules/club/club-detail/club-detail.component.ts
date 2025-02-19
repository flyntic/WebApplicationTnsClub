import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ClubDataService } from './../../../../shared/data.services/aboutclub.data.services/club.data.service';
import { Club } from './../club';

@Component({
    templateUrl: './club-detail.component.html',
    styleUrl: './club-detail.component.css',
})

export class ClubDetailComponent implements OnInit {

    id: string;
    item: Club;
    loaded: boolean = false;

    constructor(private dataService: ClubDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getClub(this.id)
                .subscribe((data: Club) => { this.item = data; this.loaded = true; });
    }
}
