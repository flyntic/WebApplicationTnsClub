import { MenuItem } from '../spa/services/menu.service';

export const AppAuthLogoutItem: MenuItem = {
    text: 'Выход',
    icon: 'images/imgs/logout.png',
    route: '/logout',
    submenu: null
}

export const AppAuthHiItem: MenuItem = {
    text: 'Привет, ',
    icon: null,//'images/imgs/login.png',
    route: null,
    submenu: null
}


export const AppAuthMenuItems: Array<MenuItem> = [
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
