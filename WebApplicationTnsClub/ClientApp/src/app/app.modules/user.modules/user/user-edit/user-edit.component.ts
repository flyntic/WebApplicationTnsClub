import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { UserDataService } from './../../../../shared/data.services/user.data.services/user.data.service';
import {  User } from './../user';


@Component({

    styleUrl: './user-edit.component.css',
    templateUrl: './user-edit.component.html',

})
export class UserEditComponent implements OnInit {

    id: string;
    user: User;    // изменяемый объект
    loaded: boolean = false;

    constructor(private dataService: UserDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getUser(this.id)
                .subscribe((data: User) => {
                    this.user = data;
                    if (this.user != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateUser(this.user).subscribe(data => this.router.navigateByUrl("/"));
    }
}