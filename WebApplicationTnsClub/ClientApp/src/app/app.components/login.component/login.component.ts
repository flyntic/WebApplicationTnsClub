import { Component, Input, NgModule } from '@angular/core';
import { AuthService } from './../../auth.service';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-login',
    standalone: true,
    imports: [FormsModule],
    templateUrl: './login.component.html',
    styleUrl: './login.component.css',
 

})
export class LoginComponent {
    constructor(private auth: AuthService) {
    }

    @Input() username: any = "";
    @Input() password: any = "";

    login() {
        console.log(this.username);
        console.log(this.password);
    /*    return */
       const result:any = this.auth.login({
            username: this.username,
            password: this.password
        });
        console.log(result);
    }
}
