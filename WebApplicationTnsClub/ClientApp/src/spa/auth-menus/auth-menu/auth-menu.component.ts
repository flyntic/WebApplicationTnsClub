import { Component, OnInit } from '@angular/core';
import { AuthMenuService } from '../../services/auth.menu.service';
//import { AuthMenuComponent } from '../../auth-menus/auth-menu/auth-menu.component';
//import { MenuComponent } from '../../menus/menu/menu.component';

@Component({
    selector: 'spa-auth-menu',
    templateUrl: './auth-menu.component.html',
    styleUrl: './auth-menu.component.css'
})
export class AuthMenuComponent implements OnInit {
    
    constructor(public authMenuService: AuthMenuService) {
        
    }

    ngOnInit() {
    }

}

