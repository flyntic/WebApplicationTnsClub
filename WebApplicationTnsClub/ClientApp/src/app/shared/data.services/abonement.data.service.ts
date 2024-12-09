import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Abonement } from '../../app.modules/abonement/abonement';

@Injectable()
export class AbonementDataService {

    private url = "/api/abonements";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getAbonements() {
        return this.http.get(this.url);
    }

    getAbonement(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createAbonement(abonement: Abonement) {
        return this.http.post(this.url, abonement);
    }

    updateAbonement(abonement: Abonement) {
        return this.http.put(this.url, abonement);
    }

    deleteAbonement(id: any) {
         return this.http.delete(this.url + '/' + id);
    }

 
}