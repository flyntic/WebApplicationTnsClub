import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { UserListComponent } from './user.component/user-list.component';
import { UserFormComponent } from './user.component/user-form.component';
import { UserCreateComponent } from './user.component/user-create.component';
import { UserEditComponent } from   './user.component/user-edit.component';
import { NotFoundComponent } from './not-found.component';
//import { RegisterUserComponent } from './authentication/register-user/register-user.component'
import { DataService } from './data.service';

// определение маршрутов
const appRoutes: Routes = [
    { path: '', component: UserListComponent },
    { path: 'create', component: UserCreateComponent },
    { path: 'edit/:login', component: UserEditComponent },
    { path: 'authentication', loadChildren: () => import('./authentication/authentication.module').then(m => m.AuthenticationModule) },

    // { path: 'authentication', component: RegisterUserComponent },// loadChildren: () => import('./authentication/authentication.module').then(m => m.AuthenticationModule) },
    { path: '**', component: NotFoundComponent }
];

@NgModule({
    imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, UserListComponent, UserCreateComponent, UserEditComponent,
        UserFormComponent, NotFoundComponent//, RegisterUserComponent
    ],
    providers: [DataService], // регистрация сервисов
    bootstrap: [AppComponent]
})
export class AppModule { }