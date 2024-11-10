import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { User } from './user.component/user';

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
    getUser(login: string) {
        return this.http.get(this.url + '/' + login);
    }
    createUser(user: User) {
       
        return this.http.post(this.url, user);

    }

    updateUser(user: User) {
        return this.http.put(this.url, user);
    }

    deleteUser(id: number) {
        return this.http.delete(this.url + '/' + id);
    }

 
}