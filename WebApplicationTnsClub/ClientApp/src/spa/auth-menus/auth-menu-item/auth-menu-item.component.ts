import { Component, OnInit, Input, ElementRef, Renderer2, HostListener, HostBinding } from '@angular/core';
import { MenuItem } from '../../services/menu.service';
import { AuthMenuService } from '../../services/auth.menu.service';
import { Router, NavigationEnd } from '@angular/router';
import { visibilityPopup } from '../../services/animations.service';

@Component({
    selector: 'spa-auth-menu-item',
    templateUrl: './auth-menu-item.component.html',
    styleUrls: ['./auth-menu-item.component.css'],
    animations: [visibilityPopup]
})

export class AuthMenuItemComponent implements OnInit {
    @Input() item: MenuItem;
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
        console.log("nginit auth-menu-item beg");
        this.checkingActiveRoute(this.router.url);
        console.log("nginit auth-menu-item med");
        this.router.events.subscribe((event) => {
            if (event instanceof NavigationEnd) {
                this.checkingActiveRoute(event.url);
            }
        });
        console.log("nginit auth-menu-item end");
    }
    checkingActiveRoute(route: string): void {
        this.isActiveRoute = (route === this.item.route);
          console.log(this.isActiveRoute);
  }
    onPopupMouseLeave(event: Event): void {
       // if (!this.authMenuService.isVertical) {
            this.mouseInPopup = false;
       // }
    }
    onPopupMouseEnter(event: Event): void {
      //  if (!this.authMenuService.isVertical) {
            this.mouseInPopup = true;
       // }
    }
    @HostListener('mouseleave', ['$event'])
    onMouseLeave(event): void {
       // if (!this.authMenuService.isVertical) {
            this.mouseInItem = false;
       // }
    }
    @HostListener('mouseenter')
    onMouseEnter(): void {
       // if (!this.authMenuService.isVertical) {
            if (this.item.submenu) {
                this.mouseInItem = true;
                if (this.parentIsPopup) {
                    this.popupLeft = 160;
                    this.popupTop = 0;
                }
            }
       // }
    }

    @HostListener('click', ['$event'])
    onClick(event: Event): void {
        console.log('click');
        event.stopPropagation();
      //  if (this.item.submenu) {
           // if (this.authMenuService.isVertical) {
           //     this.mouseInPopup = !this.mouseInPopup;
           // }
   // } else
        if (this.item.route) {
            console.log('route');
            const newEvent = new MouseEvent('mouseleave', { bubbles: true });
            console.log(this.item.route);
            //  this.renderer2.selectRootElement(this.el.nativeElement, 'dispatchEvent', [newEvent]);
            this.router.navigate([this.item.route]);
        }
    }
    
}
