﻿import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { DataService } from './../../data.service';
import { User } from './../user';
//import { FormsModule } from '@angular/forms';

@Component({
    //imports: [FormsModule],
    styleUrl: './user-edit.component.css',
    templateUrl: './user-edit.component.html'
})
export class UserEditComponent implements OnInit {

    id: number;
    login: string;
    user: User;    // изменяемый объект
    loaded: boolean = false;

    constructor(private dataService: DataService, private router: Router, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
        this.login = String(activeRoute.snapshot.params["login"]);
    }

    ngOnInit() {
        if (this.login)
            this.dataService.getUser(this.login)
                .subscribe((data: User) => {
                    this.user = data;
                    if (this.user != null) this.loaded = true;
                });
    }

    save() {
        this.dataService.updateUser(this.user).subscribe(data => this.router.navigateByUrl("/"));
    }
}