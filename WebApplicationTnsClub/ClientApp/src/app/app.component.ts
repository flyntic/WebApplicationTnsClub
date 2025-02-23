import { ChangeDetectionStrategy, Component, importProvidersFrom } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { FileService } from './file.service';


import { AppMenuItems } from './app.menu';
import { AppAuthMenuItems } from './../authenticated/auth-menus/app.auth.menu';
import { UserDataService }                from './shared/data.services/user.data.services/user.data.service';
import { IndividualAbonementDataService } from './shared/data.services/abonement.data.services/individualabonement.data.service';
import { GroupAbonementDataService }      from './shared/data.services/abonement.data.services/groupabonement.data.service';
import { AbonementDataService }           from './shared/data.services/abonement.data.services/abonement.data.service';

import { MenuService } from '../spa/services/menu.service';

import { AuthMenuService }        from '../authenticated/auth.menu.service';
//import { AuthGuard }              from './../authenticated/auth-guard.service';
//import { AuthService }            from './../authenticated/auth.service';
import { AuthenticatedComponent } from './../authenticated/auth-menus/authenticated/authenticated.component';
import { OnInit } from '@angular/core';


@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
     providers: [
        UserDataService,
        AbonementDataService,
        IndividualAbonementDataService,
        AuthenticatedComponent,
        GroupAbonementDataService,
        FileService,
        //  AsyncPipe, ChangeDetectorRef as Provider
    ],

})

export class AppComponent implements OnInit {//
    title = 'client';

    constructor(private menuService: MenuService, private authMenuService: AuthMenuService,
                /*private auth: AuthService,*/private http: HttpClient) {
     
        console.log("app-component");
        menuService.items = AppMenuItems;
        authMenuService.items = AppAuthMenuItems;
    }

    username$: string="";
    user: any;


    async  ngOnInit() {
        console.log("appcomponent-onInit");

   //     this.user = await this.auth.getUser().toPromise(); //await
   //     this.username$ =     this.user['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'];

        console.log("appcomponent-onInit2" + this.username$);

        
    }

   
/*
    async loadData() {
        try {
            this.user = await this.fetchData();
            console.log(this.user);
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    }

    fetchData(): Promise<any> {
        return this.http.get('/api/user').toPromise();//  auth.loadUser();//.toPromise();  // Convert Observable to Promise
    }
   
    logout() {
        console.log(this.user['username']);
        return this.auth.logout();
    };*/
}

