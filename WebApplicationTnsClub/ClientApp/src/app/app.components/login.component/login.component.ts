import { Component, Input, NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AuthService } from './../../../authenticated/auth.service';
import { Router } from '@angular/router';
import { AuthenticatedComponent } from '../../../authenticated/auth-menus/authenticated/authenticated.component';



@Component({
  selector: 'app-login',
    standalone: true,
    imports: [FormsModule],
    templateUrl: './login.component.html',
    styleUrl: './login.component.css',


})
export class LoginComponent {
    constructor(private auth: AuthService, private router: Router,private authenticated:AuthenticatedComponent) {
    }

    @Input() username: any = "";
    @Input() password: any = "";

     login() {
        console.log(this.username);
        console.log(this.password);

         return this.auth.login({
             username: this.username,
             password: this.password
         }).subscribe(() => { this.authenticated.loginUsername(); this.router.navigate(['/']); });
            ;

         //.then(async (value) => {
       //  console.log("loginawait+++++++++++++++++++++++++++++++++++++++++");
          
       // await this.authenticated.loginUsername();
     
       //  console.log("loginawait-----------------------------------------");
       //  console.log(this.authenticated.username$);
       //});
    
       // this.authenticated.loginUsername();

       // console.log(res);
       //  this.router.navigate(['/']);
      //  return res;
    }
}
      //  const result: any =
