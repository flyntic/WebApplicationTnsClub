import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from './../../../data.service';
import {  User } from './../user';

@Component({
    templateUrl: './user-detail.component.html',
    styleUrl:  './user-detail.component.css',
    providers: [DataService]
})

export class UserDetailComponent implements OnInit {

    id: string;
    user: User;
    loaded: boolean = false;

    constructor(private dataService: DataService, activeRoute: ActivatedRoute) {
        this.id= String(activeRoute.snapshot.params["id"]);
        

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getUser(this.id)
                .subscribe((data: User) => { this.user = data; this.loaded = true; });
    }
}