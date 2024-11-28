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

import { TicketListComponent } from   '../app.modules/ticket/ticket-list/ticket-list.component';
import { TicketCreateComponent } from '../app.modules/ticket/ticket-create/ticket-create.component';
import { TicketEditComponent } from   '../app.modules/ticket/ticket-edit/ticket-edit.component';

import { SheduleListComponent } from   '../app.modules/shedule/shedule-list/shedule-list.component';
import { SheduleCreateComponent } from '../app.modules/shedule/shedule-create/shedule-create.component';
import { SheduleEditComponent } from   '../app.modules/shedule/shedule-edit/shedule-edit.component';

import { RateListComponent } from   '../app.modules/rate/rate-list/rate-list.component';
import { RateCreateComponent } from '../app.modules/rate/rate-create/rate-create.component';
import { RateEditComponent } from   '../app.modules/rate/rate-edit/rate-edit.component';

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

            { path: 'user/list', component: UserListComponent },
            { path: 'user/create', component: UserCreateComponent },
            { path: 'user/edit/:id', component: UserEditComponent },

            { path: 'booking/list', component: BookingListComponent },
            { path: 'booking/create', component: BookingCreateComponent },
            { path: 'booking/edit/:id', component: BookingEditComponent },

            { path: 'shedule/list', component: SheduleListComponent },
            { path: 'shedule/create', component: SheduleCreateComponent },
            { path: 'shedule/edit/:id', component: SheduleEditComponent },

            { path: 'ticket/list', component: TicketListComponent },
            { path: 'ticket/create', component: TicketCreateComponent },
            { path: 'ticket/edit/:id', component: TicketEditComponent },

            { path: 'group/list', component: GroupListComponent },
            { path: 'group/create', component: GroupCreateComponent },
            { path: 'group/edit/:id', component: GroupEditComponent },

            { path: 'news/list', component: NewsListComponent },
            { path: 'news/create', component: NewsCreateComponent },
            { path: 'news/edit/:id', component: NewsEditComponent },

            { path: 'rate/list', component: RateListComponent },
            { path: 'rate/create', component: RateCreateComponent },
            { path: 'rate/edit/:id', component: RateEditComponent },

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
