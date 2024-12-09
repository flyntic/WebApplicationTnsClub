import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ClubDataService } from './../../../shared/data.services/club.data.service';
import { Club } from './../club';


@Component({

    styleUrl: './club-edit.component.css',
    templateUrl: './club-edit.component.html',

})
export class ClubEditComponent implements OnInit {

    id: string;
    item: Club;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: ClubDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getClub(this.id)
                .subscribe((data: Club) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateClub(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}


