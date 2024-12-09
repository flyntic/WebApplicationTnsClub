import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { CoachDataService } from './../../../shared/data.services/coach.data.service';
import { Coach } from './../coach';


@Component({

    styleUrl: './coach-edit.component.css',
    templateUrl: './coach-edit.component.html',

})
export class CoachEditComponent implements OnInit {

    id: string;
    item: Coach;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: CoachDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getCoach(this.id)
                .subscribe((data: Coach) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateCoach(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

