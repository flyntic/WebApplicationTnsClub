import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Manager } from '../../app.modules/manager/manager';

@Injectable()
export class ManagerDataService {

    private url = "/api/managers";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getManagers() {
        return this.http.get(this.url);
    }

    getManager(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createManager(manager: Manager) {
        return this.http.post(this.url, manager);
    }

    updateManager(manager: Manager) {
        return this.http.put(this.url, manager);
    }

    deleteManager(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}