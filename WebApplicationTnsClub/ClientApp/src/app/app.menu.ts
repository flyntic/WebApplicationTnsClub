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
        text: 'Новости',
        icon: 'images/imgs/news.png',
        route: '/user/list',
        submenu: null
    },
    {
        text: 'Расписания',
        icon: 'images/imgs/shedule.png',
        route: '/user/list',
        submenu: null
    },
    {
        text: 'Тарифы',
        icon: 'images/imgs/price.png',
        route: '/user/list',
        submenu: null
    },
    {
        text: 'Абонементы',
        icon: 'images/imgs/tickets.png',
        route: '/user/list',
        submenu: null
    },
    {
        text: 'Игроки',
        icon: 'images/imgs/players.png',
        route: '/user/list',
        submenu: null
    },
    {
        text: 'Тренеры',
        icon: 'images/imgs/coach.png',
        route: '/user/list',
        submenu: null
    },
    {
        text: 'Группы',
        icon: 'images/imgs/groups.png',
        route: '/user/list',
        submenu: null
    },
    {
        text: 'Детские группы',
        icon: 'images/imgs/childrengroups.png',
        route: '/user/list',
        submenu: null
    },
    {
        text: 'Данные аутентикации',
        icon: 'images/imgs/auths.png',
        route: '/user/list',
        submenu: null
    }
   
    
];
