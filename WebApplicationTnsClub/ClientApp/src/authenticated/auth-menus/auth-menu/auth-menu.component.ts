import { Component, OnInit } from '@angular/core';
import { AuthMenuService } from '../../auth.menu.service';

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

