import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

    constructor(private http: HttpClient) {//,context:HttpContext
    //  this.user=  this.loadUser();
    }

    user: any = { user_id: "1", username: "anna" };
;
    username: string = null;
    loadUser() { return  this.http.get<any>('/api/user'); }//this.user }.toPromise()
    /*
    {
        const user = 
             .subscribe(user => {
                this.user = user;
                this.username = user['username'];
                 console.log(this.user);
                 console.log(this.username);
            });
        return this.user;

    }
    */
   // getUser()=> user;
      /* const user = await this.http.get<any>("/api/user");//

       if ('user_id' in user)
       {
           this.user = user;console.log(user);
        }
       else console.log("NO --"+user);
        
        return user;
    }*/

    login(loginForm: any) {
        return this.http.post<any>("/api/login", loginForm, {withCredentials:true})
            .subscribe(async _ => {
                await this.loadUser();
            });

    }
    register(registerForm: any) {
        return this.http.post<any>("/api/register", registerForm, { withCredentials: true })
            .subscribe(_ => { this.loadUser(); });
    }

    logout() {
        return this.http.get("/api/logout")
            .subscribe(_ => this.user = null);
    }
    
}
