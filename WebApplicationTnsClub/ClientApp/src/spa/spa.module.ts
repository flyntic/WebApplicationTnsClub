import { ChangeDetectorRef, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { SpaBodyComponent } from '../spa/spa-body/spa-body.component'
import { SpaHeaderComponent } from '../spa/spa-header/spa-header.component'
import { SpaContentComponent } from '../spa/spa-content/spa-content.component'
import { SpaFooterComponent } from '../spa/spa-footer/spa-footer.component'
//import { IconBarComponent } from './icon-bar/icon-bar.component';
import { SpaConfigService } from './services/spa-config.service';
import { ScreenService } from './services/screen.service';
import { MenuService } from './services/menu.service';
import { MenuComponent } from './menus/menu/menu.component';
import { MenuItemComponent } from './menus/menu-item/menu-item.component';
import { AuthMenuService } from '../authenticated/auth.menu.service';
import { AuthMenuComponent } from '../authenticated/auth-menus/auth-menu/auth-menu.component';
import { AuthMenuItemComponent } from '../authenticated/auth-menus/auth-menu-item/auth-menu-item.component';
import { AuthenticatedComponent } from './../authenticated/auth-menus/authenticated/authenticated.component';

import { PopupMenuComponent } from './menus/popup-menu/popup-menu.component';



@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, AuthenticatedComponent],//
    declarations: [SpaBodyComponent, SpaContentComponent, SpaFooterComponent, SpaHeaderComponent,
     //   IconBarComponent, ScreenLargeDirective, ScreenSmallDirective,
        MenuComponent, MenuItemComponent, PopupMenuComponent,
        AuthMenuComponent, AuthMenuItemComponent
       // SignInComponent, RegistrationComponent,
    ],//
    exports: [SpaBodyComponent],
    providers: [/*ScreenService,*/ MenuService, AuthMenuService]//, AuthGuard],AuthService
})
export class SpaModule {

}

