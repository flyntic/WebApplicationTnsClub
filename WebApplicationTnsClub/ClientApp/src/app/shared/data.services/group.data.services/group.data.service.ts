import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Group } from './../../../app.modules/group.modules/group/group';

@Injectable()
export class GroupDataService {

    private url = "/api/groups";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getGroups() {
        return this.http.get(this.url);
    }

    getGroup(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createGroup(group: Group) {
        return this.http.post(this.url, group);
   }

    updateGroup(group: Group) {
        return this.http.put(this.url, group);
    }

    deleteGroup(id: any) {
       return this.http.delete(this.url + '/' + id);
    }

 
}