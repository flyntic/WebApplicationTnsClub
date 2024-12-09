import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { SessionDataService } from './../../../shared/data.services/session.data.service';
import { FileService } from './../../../file.service';
import { Session } from './../session';


@Component({
    styleUrl: './session-list.component.css',
    templateUrl: './session-list.component.html'
})

export class SessionListComponent implements OnInit {

    items: Session[];

    constructor(private dataService: SessionDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }

    load() {
        this.dataService.getSessions().subscribe((data: Session[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteSession(id).subscribe(data => this.load());
    }
}
