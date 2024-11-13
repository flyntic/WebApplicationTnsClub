import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from './../../data.service';
import {  User } from './../user';
//import { FormsModule } from '@angular/forms';

@Component({
    templateUrl: './user-detail.component.html',
    styleUrl:  './user-detail.component.css',
    //imports: [FormsModule],
    providers: [DataService]
})

export class UserDetailComponent implements OnInit {

    id: number;
    login: string;
    user: User;
    loaded: boolean = false;

    constructor(private dataService: DataService, activeRoute: ActivatedRoute) {
        this.id= Number.parseInt(activeRoute.snapshot.params["id"]);
       // this.login = String(activeRoute.snapshot.params["login"]);
        

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getUser(this.id)
                .subscribe((data: User) => { this.user = data; this.loaded = true; });
    }
}