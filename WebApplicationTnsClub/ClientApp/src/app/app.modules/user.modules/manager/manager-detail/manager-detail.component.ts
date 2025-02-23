import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ManagerDataService } from './../../../../shared/data.services/user.data.services/manager.data.service';
import { Manager } from './../manager';

@Component({
    templateUrl: './manager-detail.component.html',
    styleUrl: './manager-detail.component.css',
})

export class ManagerDetailComponent implements OnInit {

    id: string;
    item: Manager;
    loaded: boolean = false;

    constructor(private dataService: ManagerDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getManager(this.id)
                .subscribe((data: Manager) => { this.item = data; this.loaded = true; });
    }
}
