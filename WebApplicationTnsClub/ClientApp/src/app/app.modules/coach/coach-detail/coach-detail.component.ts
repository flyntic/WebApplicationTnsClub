import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CoachDataService } from './../../../shared/data.services/coach.data.service';
import { Coach } from './../coach';

@Component({
    templateUrl: './coach-detail.component.html',
    styleUrl: './coach-detail.component.css',
})

export class CoachDetailComponent implements OnInit {

    id: string;
    item: Coach;
    loaded: boolean = false;

    constructor(private dataService: CoachDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getCoach(this.id)
                .subscribe((data: Coach) => { this.item = data; this.loaded = true; });
    }
}
