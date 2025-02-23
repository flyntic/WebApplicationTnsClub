import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { FileService } from './file.service';

import { SpaModule } from '../spa/spa.module';
import { appRoutes } from './routes/app.routes';
import { RegisterComponent } from './app.components/register.component/register.component';
import { LoginComponent } from './app.components/login.component/login.component';

@NgModule({
    imports: [BrowserModule, FormsModule, AppRoutingModule, LoginComponent,HttpClientModule, 
              RegisterComponent,  SpaModule, RouterModule.forRoot(appRoutes),],
    declarations: [AppComponent],
    providers: [FileService, HttpClient],// регистрация сервисов  AuthGuard, 
    bootstrap: [AppComponent]
})
export class AppModule {

}
