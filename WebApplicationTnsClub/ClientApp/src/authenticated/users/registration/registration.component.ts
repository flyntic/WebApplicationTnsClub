import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';

import { visibility } from '../../../spa/services/animations.service';
import { UserService } from '../../user.service';


@Component({
    selector: 'spa-registration',
    templateUrl: './registration.component.html',
    styleUrls: ['./registration.component.css'],
    animations: [visibility]
})
export class RegistrationComponent implements OnInit {
    registering = false;
    hasAdded = false;
    formError: string;//anna
    constructor(private router: Router, private userService: UserService) { }
    onSubmit(registerForm: NgForm) {
        this.registering = true;
        this.formError = null;
        this.userService.registerUser(registerForm.value).subscribe(() => {
            setTimeout(() => { this.hasAdded = true; }, 1200);
            setTimeout(() => { this.router.navigate(['/sign-in']); }, 2000);
        });  //else?
    }

    ngOnInit() {
    }

}
