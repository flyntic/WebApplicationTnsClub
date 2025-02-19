import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Parent } from './../../../app.modules/user.modules/parent/parent';

@Injectable()
export class ParentDataService {

    private url = "/api/parents";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getParents() {
        return this.http.get(this.url);
    }

    getParent(id: string) {
        return this.http.get(this.url + '/' + id); 
    }

    createParent(parent: Parent) {
        return this.http.post(this.url, parent);
    }

    updateParent(parent: Parent) {
        return this.http.put(this.url, parent);
    }

    deleteParent(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}