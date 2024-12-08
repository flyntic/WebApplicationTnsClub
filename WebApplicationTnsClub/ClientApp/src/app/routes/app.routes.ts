import { Routes } from '@angular/router';
//import { AppHomeComponent } from './app-home/app-home.component';
//import { SettingsComponent } from './settings/settings.component';

import { AppComponent } from './../app.component';
import { UserModule } from './../app.modules/user/user.module';

//import { NotFoundComponent } from './../not-found.component';
//import { RegisterUserComponent } from './authentication/register-user/register-user.component'
//import { DataService } from './../data.service';
import { UserListComponent } from   '../app.modules/user/user-list/user-list.component';
import { UserCreateComponent } from '../app.modules/user/user-create/user-create.component';
import { UserEditComponent } from   '../app.modules/user/user-edit/user-edit.component';

import { CoachListComponent }   from '../app.modules/coach/coach-list/coach-list.component';
import { CoachCreateComponent } from '../app.modules/coach/coach-create/coach-create.component';
import { CoachEditComponent }   from '../app.modules/coach/coach-edit/coach-edit.component';

import { AdminListComponent }   from '../app.modules/admin/admin-list/admin-list.component';
import { AdminCreateComponent } from '../app.modules/admin/admin-create/admin-create.component';
import { AdminEditComponent }   from '../app.modules/admin/admin-edit/admin-edit.component';

import { PlayerListComponent }   from '../app.modules/player/player-list/player-list.component';
import { PlayerCreateComponent } from '../app.modules/player/player-create/player-create.component';
import { PlayerEditComponent }   from '../app.modules/player/player-edit/player-edit.component';

import { ParentListComponent }   from '../app.modules/parent/parent-list/parent-list.component';
import { ParentCreateComponent } from '../app.modules/parent/parent-create/parent-create.component';
import { ParentEditComponent }   from '../app.modules/parent/parent-edit/parent-edit.component';

import { AuthorListComponent }   from '../app.modules/author/author-list/author-list.component';
import { AuthorCreateComponent } from '../app.modules/author/author-create/author-create.component';
import { AuthorEditComponent }   from '../app.modules/author/author-edit/author-edit.component';

import { ManagerListComponent }   from '../app.modules/manager/manager-list/manager-list.component';
import { ManagerCreateComponent } from '../app.modules/manager/manager-create/manager-create.component';
import { ManagerEditComponent }   from '../app.modules/manager/manager-edit/manager-edit.component';



import { BookingListComponent } from   '../app.modules/booking/booking-list/booking-list.component';
import { BookingCreateComponent } from '../app.modules/booking/booking-create/booking-create.component';
import { BookingEditComponent } from   '../app.modules/booking/booking-edit/booking-edit.component';

import { ClubListComponent } from   '../app.modules/club/club-list/club-list.component';
import { ClubCreateComponent } from '../app.modules/club/club-create/club-create.component';
import { ClubEditComponent } from   '../app.modules/club/club-edit/club-edit.component';

import { GroupListComponent } from   '../app.modules/group/group-list/group-list.component';
import { GroupCreateComponent } from '../app.modules/group/group-create/group-create.component';
import { GroupEditComponent } from   '../app.modules/group/group-edit/group-edit.component';

import { NewsListComponent } from   '../app.modules/news/news-list/news-list.component';
import { NewsCreateComponent } from '../app.modules/news/news-create/news-create.component';
import { NewsEditComponent } from   '../app.modules/news/news-edit/news-edit.component';

import { AbonementListComponent } from   '../app.modules/abonement/abonement-list/abonement-list.component';
import { AbonementCreateComponent } from '../app.modules/abonement/abonement-create/abonement-create.component';
import { AbonementEditComponent } from   '../app.modules/abonement/abonement-edit/abonement-edit.component';

import { SessionListComponent } from   '../app.modules/session/session-list/session-list.component';
import { SessionCreateComponent } from '../app.modules/session/session-create/session-create.component';
import { SessionEditComponent } from   '../app.modules/session/session-edit/session-edit.component';

import { PriceListComponent } from   '../app.modules/price/price-list/price-list.component';
import { PriceCreateComponent } from '../app.modules/price/price-create/price-create.component';
import { PriceEditComponent } from   '../app.modules/price/price-edit/price-edit.component';

import { SheduleClubListComponent } from   '../app.modules/shedule-club/shedule-club-list/shedule-club-list.component';
import { SheduleClubCreateComponent } from '../app.modules/shedule-club/shedule-club-create/shedule-club-create.component';
import { SheduleClubEditComponent } from   '../app.modules/shedule-club/shedule-club-edit/shedule-club-edit.component';

import { SheduleClubOpenBookingListComponent } from   '../app.modules/shedule-club-open-booking/shedule-club-open-booking-list/shedule-club-open-booking-list.component';
import { SheduleClubOpenBookingCreateComponent } from '../app.modules/shedule-club-open-booking/shedule-club-open-booking-create/shedule-club-open-booking-create.component';
import { SheduleClubOpenBookingEditComponent } from   '../app.modules/shedule-club-open-booking/shedule-club-open-booking-edit/shedule-club-open-booking-edit.component';


import { HomeComponent } from '../app.components/home.component/home/home.component';
import { SignInComponent } from './../../spa/users/sign-in/sign-in.component'
import { RegistrationComponent } from './../../spa/users/registration/registration.component'
//import { AuthenticatedComponent } from './authenticated/authenticated.component';
import { AuthGuard } from '../services/auth-guard.service';

import { LoginComponent } from './../app.components/login.component/login.component'
import { RegisterComponent } from './../app.components/register.component/register.component'


// определение маршрутов
export const appRoutes: Routes = [
    //{ path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },
 //   { path: 'sign-in', component: SignInComponent },
 //   { path: 'register', component: RegistrationComponent },

    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    //{ path: 'logout', redirectTo: 'home' },

   // {
      //  path: 'authenticated', component: AuthenticatedComponent, canActivate: [AuthGuard], children: [

            { path: 'user/list',   component: UserListComponent },
            { path: 'user/create', component: UserCreateComponent },
            { path: 'user/edit/:id', component: UserEditComponent },

            { path: 'player/list',     component: PlayerListComponent },
            { path: 'player/create',   component: PlayerCreateComponent },
            { path: 'player/edit/:id', component: PlayerEditComponent },

            { path: 'parent/list',     component: ParentListComponent },
            { path: 'parent/create',   component: ParentCreateComponent },
            { path: 'parent/edit/:id', component: ParentEditComponent },

            { path: 'coach/list',     component: CoachListComponent },
            { path: 'coach/create',   component: CoachCreateComponent },
            { path: 'coach/edit/:id', component: CoachEditComponent },

            { path: 'admin/list',     component: AdminListComponent },
            { path: 'admin/create',   component: AdminCreateComponent },
            { path: 'admin/edit/:id', component: AdminEditComponent },
            
            { path: 'author/list',     component: AuthorListComponent },
            { path: 'author/create',   component: AuthorCreateComponent },
            { path: 'author/edit/:id', component: AuthorEditComponent },

            { path: 'manager/list',     component: ManagerListComponent },
            { path: 'manager/create',   component: ManagerCreateComponent },
            { path: 'manager/edit/:id', component: ManagerEditComponent },


            { path: 'booking/list', component: BookingListComponent },
            { path: 'booking/create', component: BookingCreateComponent },
            { path: 'booking/edit/:id', component: BookingEditComponent },

            { path: 'club/list',     component: ClubListComponent },
            { path: 'club/create',   component: ClubCreateComponent },
            { path: 'club/edit/:id', component: ClubEditComponent },

            { path: 'session/list', component: SessionListComponent },
            { path: 'session/create',   component: SessionCreateComponent },
            { path: 'session/edit/:id', component: SessionEditComponent },

            { path: 'abonement/list',     component: AbonementListComponent },
            { path: 'abonement/create',   component: AbonementCreateComponent },
            { path: 'abonement/edit/:id', component: AbonementEditComponent },

            { path: 'group/list', component: GroupListComponent },
            { path: 'group/create', component: GroupCreateComponent },
            { path: 'group/edit/:id', component: GroupEditComponent },

            { path: 'news/list', component: NewsListComponent },
            { path: 'news/create', component: NewsCreateComponent },
            { path: 'news/edit/:id', component: NewsEditComponent },

            { path: 'price/list',     component: PriceListComponent },
            { path: 'price/create',   component: PriceCreateComponent },
            { path: 'price/edit/:id', component: PriceEditComponent },

            { path: 'sheduleclub/list', component: SheduleClubListComponent },
            { path: 'sheduleclub/create', component: SheduleClubCreateComponent },
            { path: 'sheduleclub/edit/:id', component: SheduleClubEditComponent },

            { path: 'sheduleclubopenbooking/list', component: SheduleClubOpenBookingListComponent },
            { path: 'sheduleclubopenbooking/create', component: SheduleClubOpenBookingCreateComponent },
            { path: 'sheduleclubopenbooking/edit/:id', component: SheduleClubOpenBookingEditComponent }, 

    //  ]
  //  },
      { path: '', redirectTo: 'login', pathMatch: 'full' },
      { path: '**', component: SignInComponent }

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
