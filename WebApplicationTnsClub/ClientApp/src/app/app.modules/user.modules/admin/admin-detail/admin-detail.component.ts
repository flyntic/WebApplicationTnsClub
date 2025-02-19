import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AdminDataService } from './../../../../shared/data.services/user.data.services/admin.data.service';
import { Admin } from './../admin';

@Component({
    templateUrl: './admin-detail.component.html',
    styleUrl: './admin-detail.component.css',
})

export class AdminDetailComponent implements OnInit {

    id: string;
    item: Admin;
    loaded: boolean = false;

    constructor(private dataService: AdminDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAdmin(this.id)
                .subscribe((data: Admin) => { this.item = data; this.loaded = true; });
    }
}
