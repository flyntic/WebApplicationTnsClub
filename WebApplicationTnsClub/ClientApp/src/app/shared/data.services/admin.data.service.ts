import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Admin } from '../../app.modules/admin/admin';

@Injectable()
export class AdminDataService {

    private url = "/api/admins";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getAdmins() {
        return this.http.get(this.url);
    }

    getAdmin(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createAdmin(admin: Admin) {
        return this.http.post(this.url, admin);
   }

    updateAdmin(admin: Admin) {
        return this.http.put(this.url, admin);
    }

    deleteAdmin(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}