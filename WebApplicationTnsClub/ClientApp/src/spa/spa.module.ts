import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SpaBodyComponent } from '../spa/spa-body/spa-body.component'
import { SpaHeaderComponent } from '../spa/spa-header/spa-header.component'
import { SpaContentComponent } from '../spa/spa-content/spa-content.component'
import { SpaFooterComponent } from '../spa/spa-footer/spa-footer.component'
import { IconBarComponent } from './icon-bar/icon-bar.component';
import { SpaConfigService } from './services/spa-config.service';
import { ScreenService } from './services/screen.service';
import { MenuService } from './services/menu.service';
import { MenuComponent } from './menus/menu/menu.component';
import { MenuItemComponent } from './menus/menu-item/menu-item.component';
import { AuthMenuService } from './services/auth.menu.service';
import { AuthMenuComponent } from './auth-menus/auth-menu/auth-menu.component';
import { AuthMenuItemComponent } from './auth-menus/auth-menu-item/auth-menu-item.component';
import { RouterModule } from '@angular/router';
import { PopupMenuComponent } from './menus/popup-menu/popup-menu.component';
import { SignInComponent } from './users/sign-in/sign-in.component';
import { RegistrationComponent } from './users/registration/registration.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ScreenLargeDirective } from './directives/screen-large.directive';
import { AuthenticatedComponent } from './auth-menus/authenticated/authenticated.component';
import { ScreenSmallDirective } from './directives/screen-small.directive';

@NgModule({
    imports: [CommonModule,RouterModule, FormsModule, ReactiveFormsModule,],
    declarations: [SpaBodyComponent, SpaHeaderComponent, SpaContentComponent, SpaFooterComponent,
        IconBarComponent, ScreenLargeDirective, ScreenSmallDirective,
        MenuComponent, MenuItemComponent, PopupMenuComponent, AuthenticatedComponent,
        AuthMenuComponent, AuthMenuItemComponent, 
        SignInComponent, RegistrationComponent,
    ],
    exports: [SpaBodyComponent],
    providers: [ScreenService, MenuService, AuthMenuService]
})
export class SpaModule { }

//, AuthenticatedComponent
