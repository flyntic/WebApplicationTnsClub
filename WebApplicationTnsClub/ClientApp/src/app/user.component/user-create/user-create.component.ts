import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from './../../data.service';
import { User } from './../user';
//import { FormsModule } from '@angular/forms';

@Component({
   // imports: [FormsModule],
    templateUrl: './user-create.component.html',
    styleUrl: './user-create.component.css',

})
export class UserCreateComponent  {

    user: User = new User();    // добавляемый объект
    constructor(private dataService: DataService, private router: Router) { }
    save() {
        this.dataService.createUser(this.user).subscribe(data => this.router.navigateByUrl("/"));
    }

}