import { Component, OnInit, Input, ElementRef, Renderer2, HostListener, HostBinding } from '@angular/core';
import { MenuItem, MenuService } from '../../services/menu.service';
import { Router, NavigationEnd } from '@angular/router';
import { visibilityPopup } from '../../services/animations.service';

@Component({
    selector: 'spa-menu-item',
    templateUrl: './menu-item.component.html',
    styleUrls: ['./menu-item.component.css'],
    animations: [visibilityPopup]
})

export class MenuItemComponent implements OnInit {
    @Input() item: MenuItem;
    @HostBinding('class.parent-for-popup')
    @Input() parentIsPopup = true;
    mouseInPopup = false;
    mouseInItem = false;
    popupLeft = 0;
    popupTop = 42;
    isActiveRoute = false;
    constructor(public menuService: MenuService,
        private router: Router,
        private el: ElementRef,
        private renderer: Renderer2) { }

    ngOnInit() {
        this.checkingActiveRoute(this.router.url);
        this.router.events.subscribe((event) => {
            if (event instanceof NavigationEnd) {
                this.checkingActiveRoute(event.url);
            }
        });
    }
    checkingActiveRoute(route: string): void {
        this.isActiveRoute = (route === this.item.route);
    }
    onPopupMouseLeave(event: Event): void {
      //  if (!this.menuService.isVertical) {
            this.mouseInPopup = false;
      //  }
    }
    onPopupMouseEnter(event: Event): void {
       // if (!this.menuService.isVertical) {
            this.mouseInPopup = true;
      //  }
    }
    @HostListener('mouseleave', ['$event'])
    onMouseLeave(event): void {
       // if (!this.menuService.isVertical) {
            this.mouseInItem = false;
       // }
    }
    @HostListener('mouseenter')
    onMouseEnter(): void {
       // if (!this.menuService.isVertical) {
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
        event.stopPropagation();
        if (this.item.submenu) {
          //  if (this.menuService.isVertical) {
                this.mouseInPopup = !this.mouseInPopup;
          //  }
        } else if (this.item.route) {
            const newEvent = new MouseEvent('mouseleave', { bubbles: true });
         //   this.renderer.selectRootElement(this.el.nativeElement, 'dispatchEvent', [newEvent]);
            this.router.navigate([this.item.route]);
        }
    }

}
