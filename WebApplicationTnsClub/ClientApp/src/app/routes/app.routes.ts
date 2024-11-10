import { Routes } from '@angular/router';
//import { AppHomeComponent } from './app-home/app-home.component';
//import { SettingsComponent } from './settings/settings.component';
//import { CarListComponent } from './car-list/car-list.component';
//import { CarDetailComponent } from './car-detail/car-detail.component';
//import { CarMaintComponent } from './car-maint/car-maint.component';
//import { AuthenticatedComponent } from './authenticated/authenticated.component';
//import { SignInComponent } from '../../spa/users/sign-in/sign-in.component';
//import { RegistrationComponent } from '../../spa/users/registration/registration.component';
//import { AuthGuard } from '../services/auth-guard.service';



import { AppComponent } from './../app.component';
import { UserModule } from './../user.component/user.module';

//import { UserListComponent } from './../user.component/user-list.component';
//import { UserFormComponent } from './../user.component/user-form.component';
//import { UserCreateComponent } from './../user.component/user-create.component';
//import { UserEditComponent } from './../user.component/user-edit.component';
//import { NotFoundComponent } from './../not-found.component';
//import { RegisterUserComponent } from './authentication/register-user/register-user.component'
//import { DataService } from './../data.service';
import { UserListComponent } from '../user.component/user-list/user-list.component';
import { UserCreateComponent } from '../user.component/user-create/user-create.component';
import { UserEditComponent } from '../user.component/user-edit/user-edit.component';

import { BookingListComponent }   from '../booking.component/booking-list/booking-list.component';
import { BookingCreateComponent } from '../booking.component/booking-create/booking-create.component';
import { BookingEditComponent }   from '../booking.component/booking-edit/booking-edit.component';

import { ClubListComponent } from   '../club.component/club-list/club-list.component';
import { ClubCreateComponent } from '../club.component/club-create/club-create.component';
import { ClubEditComponent } from   '../club.component/club-edit/club-edit.component';

import { HomeComponent } from '../home.component/home/home.component';


// определение маршрутов
export const appRoutes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },

    { path: 'user/list',        component: UserListComponent },
    { path: 'user/create',      component: UserCreateComponent },
    { path: 'user/edit/:login', component: UserEditComponent },

    { path: 'booking/list', component: BookingListComponent },
    { path: 'booking/create', component: BookingCreateComponent },
    { path: 'booking/edit/:login', component: BookingEditComponent },

    { path: 'club/list', component: ClubListComponent },
    { path: 'club/create', component: ClubCreateComponent },
    { path: 'club/edit/:login', component: ClubEditComponent }

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
