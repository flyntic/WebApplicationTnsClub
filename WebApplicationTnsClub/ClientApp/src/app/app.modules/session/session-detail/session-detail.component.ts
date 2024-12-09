import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SessionDataService } from './../../../shared/data.services/session.data.service';
import { Session } from './../session';

@Component({
    templateUrl: './session-detail.component.html',
    styleUrl: './session-detail.component.css',
})

export class SessionDetailComponent implements OnInit {

    id: string;
    item: Session;
    loaded: boolean = false;

    constructor(private dataService: SessionDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getSession(this.id)
                .subscribe((data: Session) => { this.item = data; this.loaded = true; });
    }
}

