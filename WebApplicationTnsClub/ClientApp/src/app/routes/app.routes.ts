import { Routes } from '@angular/router';
import { UserListComponent } from   '../app.modules/user.modules/user/user-list/user-list.component';
import { UserCreateComponent } from '../app.modules/user.modules/user/user-create/user-create.component';
import { UserEditComponent } from   '../app.modules/user.modules/user/user-edit/user-edit.component';

import { CoachListComponent }   from '../app.modules/user.modules/coach/coach-list/coach-list.component';
import { CoachCreateComponent } from '../app.modules/user.modules/coach/coach-create/coach-create.component';
import { CoachEditComponent } from  '../app.modules/user.modules/coach/coach-edit/coach-edit.component';

import { AdminListComponent }   from '../app.modules/user.modules/admin/admin-list/admin-list.component';
import { AdminCreateComponent } from '../app.modules/user.modules/admin/admin-create/admin-create.component';
import { AdminEditComponent } from '../app.modules/user.modules/admin/admin-edit/admin-edit.component';

import { PlayerListComponent }   from '../app.modules/user.modules/player/player-list/player-list.component';
import { PlayerCreateComponent } from '../app.modules/user.modules/player/player-create/player-create.component';
import { PlayerEditComponent } from '../app.modules/user.modules/player/player-edit/player-edit.component';

import { ParentListComponent }   from '../app.modules/user.modules/parent/parent-list/parent-list.component';
import { ParentCreateComponent } from '../app.modules/user.modules/parent/parent-create/parent-create.component';
import { ParentEditComponent } from '../app.modules/user.modules/parent/parent-edit/parent-edit.component';

import { AuthorListComponent }   from '../app.modules/user.modules/author/author-list/author-list.component';
import { AuthorCreateComponent } from '../app.modules/user.modules/author/author-create/author-create.component';
import { AuthorEditComponent } from '../app.modules/user.modules/author/author-edit/author-edit.component';

import { ManagerListComponent }   from '../app.modules/user.modules/manager/manager-list/manager-list.component';
import { ManagerCreateComponent } from '../app.modules/user.modules/manager/manager-create/manager-create.component';
import { ManagerEditComponent } from '../app.modules/user.modules/manager/manager-edit/manager-edit.component';



import { BookingListComponent } from   '../app.modules/booking.modules/booking/booking-list/booking-list.component';
import { BookingCreateComponent } from '../app.modules/booking.modules/booking/booking-create/booking-create.component';
import { BookingEditComponent } from   '../app.modules/booking.modules/booking/booking-edit/booking-edit.component';

import { ClubListComponent } from   '../app.modules/aboutclub.modules/club/club-list/club-list.component';
import { ClubCreateComponent } from '../app.modules/aboutclub.modules/club/club-create/club-create.component';
import { ClubEditComponent } from   '../app.modules/aboutclub.modules/club/club-edit/club-edit.component';

import { GroupListComponent } from   '../app.modules/group.modules/group/group-list/group-list.component';
import { GroupCreateComponent } from '../app.modules/group.modules/group/group-create/group-create.component';
import { GroupEditComponent } from   '../app.modules/group.modules/group/group-edit/group-edit.component';

import { NewsListComponent } from   '../app.modules/aboutclub.modules/news/news-list/news-list.component';
import { NewsCreateComponent } from '../app.modules/aboutclub.modules/news/news-create/news-create.component';
import { NewsEditComponent } from   '../app.modules/aboutclub.modules/news/news-edit/news-edit.component';

import { GroupAbonementListComponent } from   '../app.modules/abonement.modules/groupabonement/groupabonement-list/groupabonement-list.component';
import { GroupAbonementCreateComponent } from '../app.modules/abonement.modules/groupabonement/groupabonement-create/groupabonement-create.component';
import { GroupAbonementEditComponent } from   '../app.modules/abonement.modules/groupabonement/groupabonement-edit/groupabonement-edit.component';

import { IndividualAbonementListComponent }     from '../app.modules/abonement.modules/individualabonement/individualabonement-list/individualabonement-list.component';
import { IndividualAbonementCreateComponent }   from '../app.modules/abonement.modules/individualabonement/individualabonement-create/individualabonement-create.component';
import { IndividualAbonementEditComponent }     from '../app.modules/abonement.modules/individualabonement/individualabonement-edit/individualabonement-edit.component';


import { SessionListComponent } from   '../app.modules/aboutclub.modules/session/session-list/session-list.component';
import { SessionCreateComponent } from '../app.modules/aboutclub.modules/session/session-create/session-create.component';
import { SessionEditComponent } from   '../app.modules/aboutclub.modules/session/session-edit/session-edit.component';

import { PriceListComponent } from   '../app.modules/aboutclub.modules/price/price-list/price-list.component';
import { PriceCreateComponent } from '../app.modules/aboutclub.modules/price/price-create/price-create.component';
import { PriceEditComponent } from   '../app.modules/aboutclub.modules/price/price-edit/price-edit.component';

import { SheduleClubListComponent } from   '../app.modules/aboutclub.modules/shedule-club/shedule-club-list/shedule-club-list.component';
import { SheduleClubCreateComponent } from '../app.modules/aboutclub.modules/shedule-club/shedule-club-create/shedule-club-create.component';
import { SheduleClubEditComponent } from   '../app.modules/aboutclub.modules/shedule-club/shedule-club-edit/shedule-club-edit.component';



import { HomeComponent } from '../app.components/home.component/home/home.component';

import { LoginComponent }      from './../app.components/login.component/login.component'
import { RegisterComponent }   from './../app.components/register.component/register.component'


// определение маршрутов
export const appRoutes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },
    //   { path: 'sign-in', component: SignInComponent },
    //   { path: 'register', component: RegistrationComponent },

    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    //{ path: 'logout', redirectTo: 'home' },

    // {
    //  path: 'authenticated', component: AuthenticatedComponent, canActivate: [AuthGuard], children: [

    { path: 'user/list', component: UserListComponent },
    { path: 'user/create', component: UserCreateComponent },
    { path: 'user/edit/:id', component: UserEditComponent },

    { path: 'groupabonement/list', component: GroupAbonementListComponent },
    { path: 'groupabonement/edit/:id', component: GroupAbonementEditComponent },
    { path: 'groupabonement/create', component: GroupAbonementCreateComponent },

    { path: 'individualabonement/list', component: IndividualAbonementListComponent },
    { path: 'individualabonement/edit/:id', component: IndividualAbonementEditComponent },
    { path: 'individualabonement/create', component: IndividualAbonementCreateComponent },

    { path: 'player/list', component: PlayerListComponent },
    { path: 'player/create', component: PlayerCreateComponent },
    { path: 'player/edit/:id', component: PlayerEditComponent },

    { path: 'parent/list', component: ParentListComponent },
    { path: 'parent/create', component: ParentCreateComponent },
    { path: 'parent/edit/:id', component: ParentEditComponent },

    { path: 'coach/list', component: CoachListComponent },
    { path: 'coach/create', component: CoachCreateComponent },
    { path: 'coach/edit/:id', component: CoachEditComponent },

    { path: 'admin/list', component: AdminListComponent },
    { path: 'admin/create', component: AdminCreateComponent },
    { path: 'admin/edit/:id', component: AdminEditComponent },

    { path: 'author/list', component: AuthorListComponent },
    { path: 'author/create', component: AuthorCreateComponent },
    { path: 'author/edit/:id', component: AuthorEditComponent },

    { path: 'manager/list', component: ManagerListComponent },
    { path: 'manager/create', component: ManagerCreateComponent },
    { path: 'manager/edit/:id', component: ManagerEditComponent },


    { path: 'booking/list', component: BookingListComponent },
    { path: 'booking/create', component: BookingCreateComponent },
    { path: 'booking/edit/:id', component: BookingEditComponent },

    { path: 'club/list', component: ClubListComponent },
    { path: 'club/create', component: ClubCreateComponent },
    { path: 'club/edit/:id', component: ClubEditComponent },

    { path: 'session/list', component: SessionListComponent },
    { path: 'session/create', component: SessionCreateComponent },
    { path: 'session/edit/:id', component: SessionEditComponent },

    { path: 'group/list', component: GroupListComponent },
    { path: 'group/create', component: GroupCreateComponent },
    { path: 'group/edit/:id', component: GroupEditComponent },

    { path: 'news/list', component: NewsListComponent },
    { path: 'news/create', component: NewsCreateComponent },
    { path: 'news/edit/:id', component: NewsEditComponent },

    { path: 'price/list', component: PriceListComponent },
    { path: 'price/create', component: PriceCreateComponent },
    { path: 'price/edit/:id', component: PriceEditComponent },

    { path: 'sheduleclub/list', component: SheduleClubListComponent },
    { path: 'sheduleclub/create', component: SheduleClubCreateComponent },
    { path: 'sheduleclub/edit/:id', component: SheduleClubEditComponent },
    //{ path: 'auth-spa-header', component: AuthenticatedComponent },
      
   

    //  ]
  //  },
      { path: '', redirectTo: 'login', pathMatch: 'full' },
    //  { path: '**', component: SignInComponent }

    //  { path: 'authentication', loadChildren: () => import('./authentication/authentication.module').then(m => m.AuthenticationModule) },

    // { path: 'authentication', component: RegisterUserComponent },// loadChildren: () => import('./authentication/authentication.module').then(m => m.AuthenticationModule) },
    //{ path: '**', component: NotFoundComponent }
];

//export const appRoutes: Routes = [
//    { path: '', component: UserListComponent },
//    { path: 'sign-in', component: SignInComponent },
//    { path: 'register', component: RegistrationComponent },
//    { path: 'authenticated', component: AuthenticatedComponent/*, canActivate: [AuthGuard]   , children: [
//          {
//                path: '', canActivateChild: [AuthGuard], children: [
//                   // { path: 'home', component: AppHomeComponent },
//                   // { path: 'settings', component: SettingsComponent },
//                   // { path: 'car-list/:count', component: CarListComponent },
//                   // { path: 'car-detail/:id/:operation', component: CarDetailComponent },
//                   // { path: 'car-maint', component: CarMaintComponent }
//                ]
//            }
//
//        ]*/
//    },
//    { path: '', redirectTo: 'sign-in', pathMatch: 'full' },
//    { path: '**', component: SignInComponent }
//];
