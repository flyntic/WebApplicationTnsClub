import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { SheduleClubDataService } from './../../../shared/data.services/shedule-club.data.service';
import { SheduleClub } from './../shedule-club';


@Component({

    styleUrl: './shedule-club-edit.component.css',
    templateUrl: './shedule-club-edit.component.html',

})
export class SheduleClubEditComponent implements OnInit {

    id: string;
    item: SheduleClub;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: SheduleClubDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getSheduleClub(this.id)
                .subscribe((data: SheduleClub) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateSheduleClub(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

