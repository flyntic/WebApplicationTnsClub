import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserDataService } from './../../../shared/data.services/user.data.service';
import {  User } from './../user';

@Component({
    templateUrl: './user-detail.component.html',
    styleUrl:  './user-detail.component.css',
})

export class UserDetailComponent implements OnInit {

    id: string;
    user: User;
    loaded: boolean = false;

    constructor(private dataService: UserDataService, activeRoute: ActivatedRoute) {
        this.id= String(activeRoute.snapshot.params["id"]);
        

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getUser(this.id)
                .subscribe((data: User) => { this.user = data; this.loaded = true; });
    }
}