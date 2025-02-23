import { Component, OnInit, Input, ElementRef, Renderer2, HostListener, HostBinding } from '@angular/core';

import { Router, NavigationEnd } from '@angular/router';

import { AuthMenuService,AuthMenuItem } from '../../auth.menu.service';

import { visibilityPopup } from '../../../spa/services/animations.service';

@Component({
    selector: 'spa-auth-menu-item',
    templateUrl: './auth-menu-item.component.html',
    styleUrls: ['./auth-menu-item.component.css'],
    animations: [visibilityPopup]
})

export class AuthMenuItemComponent implements OnInit {
    @Input() item: AuthMenuItem;
    @HostBinding('class.parent-for-popup')
    @Input() parentIsPopup = true;
    mouseInPopup = false;
    mouseInItem = false;
    popupLeft = 0;
    popupTop = 42;
    isActiveRoute = false;
   constructor(public authMenuService: AuthMenuService,
        private router: Router,
        private el: ElementRef,
        private renderer: Renderer2) { }

    ngOnInit() {
      //  console.log("nginit auth-menu-item beg");
        this.checkingActiveRoute(this.router.url);
     //   console.log("nginit auth-menu-item med");
        this.router.events.subscribe((event) => {
            if (event instanceof NavigationEnd) {
                this.checkingActiveRoute(event.url);
            }
        });
       
      //  console.log("nginit auth-menu-item end");
    }
    checkingActiveRoute(route: string): void {
        this.isActiveRoute = (route === this.item.route);
       //   console.log(this.isActiveRoute);
  }
    onPopupMouseLeave(event: Event): void {

        this.mouseInPopup = false;

    }
    onPopupMouseEnter(event: Event): void {
    
            this.mouseInPopup = true;

    }
    @HostListener('mouseleave', ['$event'])
    onMouseLeave(event): void {

        this.mouseInItem = false;

    }

    @HostListener('mouseenter')
    onMouseEnter(): void {
            if (this.item.submenu) {
                this.mouseInItem = true;
                if (this.parentIsPopup) {
                    this.popupLeft = 160;
                    this.popupTop = 0;
                }
            }

    }

    @HostListener('click', ['$event'])
    onClick(event: Event): void {
      //  console.log('click');
        event.stopPropagation();
        if (this.item.route) {
            const newEvent = new MouseEvent('mouseleave', { bubbles: true });
            this.router.navigate([this.item.route]);
        }
    }
    
}
