import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from './../../../data.service';
import { User } from './../user';
import { OnInit } from '@angular/core';


@Component({
  
    templateUrl: './user-create.component.html',
    styleUrl: './user-create.component.css',

})
export class UserCreateComponent implements OnInit {

    user: User;// = new User();    // добавляемый объект

    constructor(private dataService: DataService, private router: Router) { }

    ngOnInit() {
        console.log("user-create-onInit");
        this.user = new User();  

    }

    save() {
        console.log("CREATE USER"+this.user.id);

      //  this.dataService.createUser(this.user).subscribe(data => this.router.navigateByUrl("/"));
    }

}