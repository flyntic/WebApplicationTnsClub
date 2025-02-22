﻿import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { UserDataService } from './../../../../shared/data.services/user.data.services/user.data.service';
import { FileService } from './../../../../file.service';
import { User } from './../user';


@Component({
   
    styleUrl: './user-list.component.css',
    templateUrl: './user-list.component.html'
})
export class UserListComponent implements OnInit {

    users: User[];


    constructor(private dataService: UserDataService, private fileService: FileService,
        private router: Router) { console.log("user-list"); }

    ngOnInit() {

        this.load();
       
    }
    load() {
        this.dataService.getUsers().subscribe((data: User[]) => {
            
            this.users = data;
        });
    
       
    }
 
    delete(id: any) {

        this.dataService.deleteUser(id).subscribe(data => this.load());
    }
}