import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../../app/auth.service';
import { AppAuthLogoutItem, AppAuthHiItem } from '../../../app/app.auth.menu';
//import { AuthGuard } from '../../auth.service';

@Component({
    selector: 'app-authenticated',
    templateUrl: './authenticated.component.html',
    styleUrls: ['./authenticated.component.css'],
    providers: [ AuthService]//, AuthGuard

})
export class AuthenticatedComponent implements OnInit {

    constructor(private auth:AuthService) { }
    username: string;
    user: any;

    logouttext = AppAuthLogoutItem['text'];
    hitext = AppAuthHiItem['text'];
    logoutpng = AppAuthLogoutItem['icon'];


    async ngOnInit() {
        this.user = await this.auth.loadUser().toPromise();
        this.username = this.user['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'];
    }

    logout() {
        console.log(this.user['username']);
        return this.auth.logout();
    };
}
