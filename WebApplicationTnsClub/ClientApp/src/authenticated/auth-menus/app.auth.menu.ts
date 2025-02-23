import { AuthMenuItem } from '../auth.menu.service';

export const AppAuthLogoutItem: AuthMenuItem = {
    text: 'Выход',
    icon: 'images/imgs/logout.png',
    route: '/logout',
    submenu: null
}

export const AppAuthHiItem: AuthMenuItem = {
    text: 'Привет, ',
    icon: null,//'images/imgs/login.png',
    route: null,
    submenu: null
}


export const AppAuthMenuItems: Array<AuthMenuItem> = [
    {
        text: 'Вход',
        icon: 'images/imgs/login.png',
        route: '/login',
        submenu: null
    },
    {
        text: 'Регистрация',
        icon: 'images/imgs/register.png',
        route: '/register',
        submenu: null
    }
 /*   ,
    {   text: 'Выход',
        icon: 'images/imgs/logout.png',
        route: '/logout',
        submenu: null
    }
  */ 
    
];
