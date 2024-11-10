import { Component, OnInit } from '@angular/core';
import { ScreenService } from '../services/screen.service';
import { MenuService } from '../services/menu.service';
import { AuthMenuService } from '../services/auth.menu.service';
import { AuthService } from '../../app/auth.service';
import { AuthenticatedComponent } from '../auth-menus/authenticated/authenticated.component';



@Component({
    selector: 'spa-header',
    templateUrl: './spa-header.component.html',
    styleUrls: ['./spa-header.component.css']
})
export class SpaHeaderComponent implements OnInit {
   // isAuth = false;
    constructor(private screenService: ScreenService,
                public menuService: MenuService,
               public authMenuService: AuthMenuService
      //  private authenticated: AuthenticatedComponent
        ) { }  //PUBLICpublic auth:AuthService,

    ngOnInit() {
       // this.isAuth = this.authenticated.username.length!=0;
    }

}
