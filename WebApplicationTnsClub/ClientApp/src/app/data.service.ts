import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { User } from './app.modules/user/user';

@Injectable()
export class DataService {

    private url = "/api/users";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getUsers() {
        return this.http.get(this.url);
    }

 //   getUser(id: number) {
 //       return this.http.get(this.url + '/' + id);
 //   }
    getUser(id: string) {
        console.log("create user:");
        return this.http.get(this.url + '/' + id); 
    }
    createUser(user: User) {
        console.log("create user:" + JSON.stringify(user));
        const result: any = this.http.post(this.url, user);
        console.log("do create"+result );
        return result;
    }

    updateUser(user: User) {
        console.log("create user:" );
        return this.http.put(this.url, user);
    }

    deleteUser(id: any) {
        console.log("delete "+id)
        return this.http.delete(this.url + '/' + id);
    }

 
}