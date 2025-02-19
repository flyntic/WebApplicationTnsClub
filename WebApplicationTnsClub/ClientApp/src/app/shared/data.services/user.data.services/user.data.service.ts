import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { User } from './../../../app.modules/user.modules/user/user';

@Injectable()
export class UserDataService {

    private url = "/api/users";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getUsers() {
        return this.http.get(this.url);
    }

    getUser(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createUser(user: User) {
        return this.http.post(this.url,  user);
    }

    updateUser(user: User) {   
        return this.http.put(this.url, user);
    }

    deleteUser(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}