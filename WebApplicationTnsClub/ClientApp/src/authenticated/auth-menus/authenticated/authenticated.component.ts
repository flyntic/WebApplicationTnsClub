import { ChangeDetectionStrategy, Component, OnInit, Provider } from '@angular/core';
//import { FormsModule } from '@angular/forms';
import { AsyncPipe } from "@angular/common";

import { AuthService } from '../../auth.service';
import { AppAuthLogoutItem, AppAuthHiItem } from './../app.auth.menu';

import { AuthGuard } from '../../auth-guard.service';
import { Observable,Observer,of,from } from 'rxjs';

import { ChangeDetectorRef } from '@angular/core';

import { map } from 'rxjs/internal/operators/map';
import { Input } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { clearInterval } from 'timers';
import { setTimeout } from 'timers';

@Component({
    selector: 'app-authenticated',
    imports:[AsyncPipe],
    templateUrl: './authenticated.component.html',
    styleUrls: ['./authenticated.component.css'],
    providers: [ AuthGuard,  ChangeDetectorRef as Provider],
    standalone: true,
    changeDetection: ChangeDetectionStrategy.OnPush
})

export class AuthenticatedComponent implements OnInit {//

    constructor(private authService: AuthService,
                private ref: ChangeDetectorRef)//, private _ngZone: NgZone
    {     }
    user$: Observable<any>;
    isAuthenticated$: Observable<boolean>;

   @Input()  username$: any;
    username1$: Observable<string>;
    username3$: Observable<string>;

    logouttext = AppAuthLogoutItem['text'];
    hitext = AppAuthHiItem['text'];
    logoutpng = AppAuthLogoutItem['icon'];
    username2$ = new BehaviorSubject<string>(null);
    user1: any;

    i$: Observable<number>;


     async ngOnInit() {
         console.log("auth_comp ngOnInint-begin");
         this.username3$ = this.username2$.asObservable();



        // this.user$ = await this.authService.getUser(); //

         this.user1 = await this.authService.getUser().toPromise(); //

         this.username$ = this.user1['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'];

         this.username2$.next(this.username$);//.asObservable();

         this.i$ = Observable.create((observer) => {
             let value = 0;
             setInterval(()=>observer.next(value++),1000);
          //   return () => clearInterval(interval);
         })

            console.log("auth_comp ngOnInint-end " + this.username$);

  
     }

    async loginUsername() {
        console.log("loginUser begin");

        this.user$ = await this.authService.getUser(); //

         this.user1 = await this.authService.getUser().toPromise(); //

        this.username$ =  this.user1['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'];

      //  setInterval(() => { console.log("authehn2!!!" + this.i$);  this.ref.detectChanges(); }, 1000);



        this.username2$.next(this.username$);//.asObservable();
        this.username1$ = of(this.username$);
        this.username1$.subscribe(res => { console.log("LoginUser username1$ " + res);this.ref .detectChanges(); });// = of(this.username$);


        this.username2$.subscribe(res => { console.log("LoginUser username2 " + res);; this.ref.detectChanges(); });
        this.username3$ = this.username2$.asObservable();//
        this.username3$.subscribe(res => { console.log("LoginUser username3 " + res); this.ref.detectChanges();  });
        this.ref.detectChanges();
        console.log("LoginUser end +" + this.username$);
   
     }

    logout() {
        return this.authService.logout();
    };
}
