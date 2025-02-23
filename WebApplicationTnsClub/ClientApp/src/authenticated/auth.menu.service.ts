import { Injectable } from '@angular/core';
export interface AuthMenuItem {
    text: string;
    icon: string;
    route: string;
    submenu: Array<AuthMenuItem>;
}

@Injectable()
export class AuthMenuService {
    items: Array<AuthMenuItem>;

}