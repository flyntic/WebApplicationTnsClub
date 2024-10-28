import { Component, OnInit } from '@angular/core';
import { DataService } from './../data.service';
import { FileService } from './../file.service';
import { User } from './user';

@Component({
    templateUrl: './user-list.component.html'
})
export class UserListComponent implements OnInit {

    users: User[];
    avatar: any;
    sanitizer: any;


    constructor(private dataService: DataService,private fileService: FileService) { }

    ngOnInit() {
        this.load();
       
    }
    load() {
        this.dataService.getUsers().subscribe((data: User[]) => {
            this.users = data;
        });
    
       
    }
 
    delete(id: number) {
        this.dataService.deleteUser(id).subscribe(data => this.load());
    }
}