import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserDataService } from './../../../../shared/data.services/user.data.services/user.data.service';
import { User } from './../user';
import { OnInit } from '@angular/core';
import { UserFormComponent } from '../user-form/user-form.component';
import { FormsModule } from '@angular/forms';

@Component({
  
    templateUrl: './user-create.component.html',
    styleUrl: './user-create.component.css',
    imports: [UserFormComponent, FormsModule],
    standalone: true

})
export class UserCreateComponent implements OnInit {

    user: User = new User();    // добавляемый объект

    constructor(private dataService: UserDataService, private ufc:UserFormComponent,private router: Router) { }

    ngOnInit() {
       
    }

    save() {
    
        this.dataService.createUser(this.user).subscribe(data => this.router.navigateByUrl("/"));
    }

}