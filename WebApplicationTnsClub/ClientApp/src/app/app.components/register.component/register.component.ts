import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AuthService } from './../../../authenticated/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './register.component.html',
    styleUrl: './register.component.css',

})
export class RegisterComponent {
    constructor(private auth: AuthService,private router:Router) {

    }

    username: any="";
    password: any="";
    confirmPassword: any = "";

    login() {
          const res =
         
            this.auth.register({
            username: this.username,
            password: this.password,
            confirmPassword: this.confirmPassword
        }
        );
       this.router.navigate(['/']);
        return res;
    }

}
