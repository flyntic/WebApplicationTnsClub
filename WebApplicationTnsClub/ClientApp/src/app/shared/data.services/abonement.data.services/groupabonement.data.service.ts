import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { GroupAbonement } from './../../../app.modules/abonement.modules/groupabonement/groupabonement';

@Injectable()
export class GroupAbonementDataService {

    private url = "/api/groupabonement";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getAbonements() {
        return this.http.get(this.url);
    }

    getAbonement(id: any) {
        return this.http.get(this.url + '/' + id); 
    }
    createAbonement(abonement: GroupAbonement) {
        return this.http.post(this.url, abonement);
    }

    updateAbonement(abonement: GroupAbonement) {
        return this.http.put(this.url, abonement);
    }

    deleteAbonement(id: any) {
         return this.http.delete(this.url + '/' + id);
    }

 
}