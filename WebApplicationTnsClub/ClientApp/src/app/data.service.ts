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
    getUser(id: number) {
        return this.http.get(this.url + '/' + id); 
    }
    createUser(user: User) {
        console.log("create user:"+user.toString());
        const result: any = this.http.post(this.url, user);
        console.log(result);
        return result;
    }

    updateUser(user: User) {
        return this.http.put(this.url, user);
    }

    deleteUser(id: number) {
        return this.http.delete(this.url + '/' + id);
    }

 
}