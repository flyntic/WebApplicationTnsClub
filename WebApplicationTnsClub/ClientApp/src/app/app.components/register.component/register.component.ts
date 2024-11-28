import { Component } from '@angular/core';
import { AuthService } from './../../auth.service';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
    constructor(private auth: AuthService) {

    }

    username: any="";
    password: any="";
    confirmPassword: any = "";

    login() {
        return this.auth.register({
            username: this.username,
            password: this.password,
            confirmPassword: this.confirmPassword
        }
        );
    }

}
