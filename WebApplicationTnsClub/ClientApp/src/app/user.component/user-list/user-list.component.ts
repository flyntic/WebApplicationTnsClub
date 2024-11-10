import { Component, OnInit } from '@angular/core';
import { DataService } from './../../data.service';
import { FileService } from './../../file.service';
import { User } from './../user';
//import { FormsModule } from '@angular/forms';

@Component({
   // imports: [FormsModule],
    styleUrl: './user-list.component.css',
    templateUrl: './user-list.component.html'
})
export class UserListComponent implements OnInit {

    users: User[];
    avatar: any;
    sanitizer: any;


    constructor(private dataService: DataService, private fileService: FileService) { console.log("user-list"); }

    ngOnInit() {
        console.log("user-list-onInit");
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