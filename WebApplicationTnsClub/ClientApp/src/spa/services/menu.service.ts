import { Injectable } from '@angular/core';
export interface MenuItem {
    text: string;
    icon: string;
    route: string;
    submenu: Array<MenuItem>;
}

@Injectable()
export class MenuService {
    items: Array<MenuItem> ;
;
  //  isVertical = true;
  //  showVerticalMenu = true;
  //  toggleMenu(): void {
   //     this.isVertical = true;
   //     this.showVerticalMenu = !this.showVerticalMenu;
 //   }

  //  toggleOrientation(): void {
    //    this.isVertical = !this.isVertical;
  //  }
}