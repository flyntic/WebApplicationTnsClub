import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { SessionDataService } from './../../../shared/data.services/session.data.service';
import { Session } from './../session';


@Component({

    styleUrl: './session-edit.component.css',
    templateUrl: './session-edit.component.html',

})
export class SessionEditComponent implements OnInit {

    id: string;
    item: Session;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: SessionDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getSession(this.id)
                .subscribe((data: Session) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateSession(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}