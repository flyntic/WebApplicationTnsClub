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
        route: '/news/list',
        submenu: null
    },
    {
        text: 'Расписания',
        icon: 'images/imgs/shedule.png',
        route: null,
        submenu: [
            {
                text: 'Сеансы',
                icon: 'images/imgs/price.png',
                route: '/session/list',
                submenu: null
            },
            {
                text: 'Расписания в клубах',
                icon: 'images/imgs/price.png',
                route:'/sheduleclub/list',
                submenu: null
            },
        ]
    },
    {
        text: 'Тарифы',
        icon: 'images/imgs/price.png',
        route: '/price/list',
        submenu: null
    },
    {
        text: 'Абонементы',
        icon: 'images/imgs/tickets.png',
        route: null,
        submenu: [
            {
                text: 'Групповые абоненты',
                icon: 'images/imgs/tickets.png',
                route: '/groupabonent/list',
                submenu: null
            },
            {
                text: 'Индивидуальные абоненты',
                icon: 'images/imgs/tickets.png',
                route: '/individualabonent/list',
                submenu: null
            },
        ]
    },
    {
        text: 'Пользователи',
        icon: 'images/imgs/players.png',
        route: null,
        submenu: [
            {
             text: 'Все',
             icon: 'images/imgs/players.png',
             route: '/user/list',
             submenu: null
            },
            {
             text: 'Игроки',
             icon: 'images/imgs/players.png',
             route: '/player/list',
             submenu: null
            },
            {
             text: 'Тренеры',
             icon: 'images/imgs/coach.png',
             route: '/coach/list',
             submenu: null
            },
            {
             text: 'Родители',
             icon: 'images/imgs/players.png',
             route: '/parent/list',
             submenu: null
            },
            {
                text: 'Менеджеры',
                icon: 'images/imgs/players.png',
                route: '/manager/list',
                submenu: null
            },
            {
                text: 'Админы',
                icon: 'images/imgs/coach.png',
                route: '/admin/list',
                submenu: null
            },
            {
                text: 'Игроки',
                icon: 'images/imgs/players.png',
                route: '/parent/list',
                submenu: null
            }]
        },
    {
        text: 'Группы',
        icon: 'images/imgs/groups.png',
        route: '/group/list',
        submenu: null
    },
    {
        text: 'Детские группы',
        icon: 'images/imgs/childrengroups.png',
        route: '/childrengroup/list',
        submenu: null
    },
    {
        text: 'Данные аутентикации',
        icon: 'images/imgs/auths.png',
        route: '/auth/list',
        submenu: null
    }
   
    
];
