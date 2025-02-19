
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable,of,from } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
    user: any;// = { user_id: "1", username: "anna" };
    public username: string;
    private number: any; 
    constructor(private http: HttpClient) {
        this.number = Math.random() * 1000;

    }

    isAuthenticated$ = new Observable<any>();

    getUser() {
        console.log("getuser auth service" + this.number);
        return this.http.get('/api/user');
  
    }

    public isAuthenticated(): Observable<boolean> {
        return this.isAuthenticated$;
    }


     login(loginForm: any) {
         return this.http.post<any>("/api/login", loginForm, { withCredentials: false });
         //  .subscribe(() => {
         //      console.log("LOADUSER end " + this.number);
        //   });

    }
    register(registerForm: any) {
        return this.http.post<any>("/api/register", registerForm, { withCredentials: true });
          //  .subscribe(_ => { this.loadUser(); });
    }

    logout() {
      
        return this.http.get("/api/logout")
            .subscribe(_ => this.user = null);
    }
    
}
