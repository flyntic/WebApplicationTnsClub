import { Component, importProvidersFrom } from '@angular/core';
import { DataService } from './data.service';
import { FileService } from './file.service';
import { AuthService } from "./auth.service";
//import { OnInit } from '@angular/core';
//import { of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
//import { ProjectsComponent } from './projects/projects.component'
import { AppMenuItems } from './app.menu';
import { AppAuthMenuItems } from './app.auth.menu';

import { MenuService } from '../spa/services/menu.service';
import { AuthMenuService } from '../spa/services/auth.menu.service';
//import { SpaConfigService, SpaConfigSettings, Icons } from '../spa/services/spa-config.service';
import { AuthGuard } from './services/auth-guard.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    providers: [DataService, FileService, AuthService,AuthGuard]
   // imports:[HttpClient]
})

export class AppComponent  {//implements OnInit
    title = 'client';

    constructor(/*private spaConfigService: SpaConfigService,*/ private menuService: MenuService, private authMenuService: AuthMenuService, private auth: AuthService, private http: HttpClient) {
     /*   const config: SpaConfigSettings = {
            socialIcons: [
                { imageFile: '/images/imgs/telegram.png', alt: 'Telegram', url: 'http://telegram.com' },
                { imageFile: '/images/imgs/vk.png', alt: 'Vkontakte', url: 'http://www.vkontakte.com' },
                { imageFile: '/images/imgs/vk.png', alt: 'Vkontakte', url: 'http://www.vkontakte.com' },
                { imageFile: '/images/imgs/whatsapp.png', alt: 'WhatsApp', url: 'http://www.whatsapp.com' }
            ],
            showUserControls: true
        };
        spaConfigService.configure(config);*/
        console.log("app-component");
        menuService.items = AppMenuItems;
        authMenuService.items = AppAuthMenuItems;
    }

   // username: string;
   // user: any;


    async ngOnInit() {
        console.log("appcomponent-onInit");
   //     this.user = await this.auth.loadUser().toPromise();
   //     this.username = this.user['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'];

        
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
*/

/*
    async ngOnInit() {
        console.log("NGINIT0 ");
        of(this.auth.loadUser()).to .subscribe(user => { this.user = user; this.username = user['username']; console.log(this.username); });
        
        //this.username = user['username'];
       // console.log("NGINIT1 ");// console.log(this.user);
        console.log("NGINIT2 ");
    }
   
    logout() {
        console.log(this.user['username']);
        return this.auth.logout();
    };*/
}

