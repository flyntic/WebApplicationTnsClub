import { MenuItem } from '../spa/services/menu.service';
export const AppMenuItems: Array<MenuItem> = [
    {
        text: 'Профиль',
        icon: 'images/imgs/home.png',
        route: '/home',
        submenu: null
    },
    {
        text: 'Бронирования',
        icon: 'images/imgs/bookings.png',
        route: '/booking/list',
        submenu: null
    },
    {   text: 'Клубы',
        icon: 'images/imgs/clubs.png',
        route: '/club/list',
        submenu: null
    },
    {
        text: 'Игроки',
        icon: 'images/imgs/players.png',
        route: '/user/list',
        submenu: null
    }
   
    
];
