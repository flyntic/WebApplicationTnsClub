import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DataService } from './data.service';
import { FileService } from './file.service';
import { AuthService } from './auth.service';
//import { RegisterComponent } from './register/register.component';
//import { LoginComponent } from './login/login.component';
//import { ProjectsComponent } from './projects/projects.component';

import { SpaModule } from '../spa/spa.module';
import { appRoutes } from './routes/app.routes';
import { AuthGuard } from './services/auth-guard.service';

@NgModule({
    imports: [BrowserModule, FormsModule, AppRoutingModule,/* LoginComponent,*/HttpClientModule, 
       /* RegisterComponent, ProjectsComponent,*/ SpaModule, RouterModule.forRoot(appRoutes),],
    declarations: [AppComponent],
    providers: [DataService,FileService,AuthService, AuthGuard,HttpClient],// регистрация сервисов
    bootstrap: [AppComponent]
})
export class AppModule {

}
/*
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
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
*/