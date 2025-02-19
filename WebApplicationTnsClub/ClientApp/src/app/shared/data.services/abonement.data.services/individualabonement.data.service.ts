import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { IndividualAbonement } from '../../../app.modules/abonement.modules/individualabonement/individualabonement';

@Injectable()
export class IndividualAbonementDataService {

    private url = "/api/individualabonement";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getAbonements() {
        return this.http.get(this.url);
    }

    getAbonement(id: any) {
        return this.http.get(this.url + '/' + id); 
    }
    createAbonement(abonement: IndividualAbonement) {
        return this.http.post(this.url, abonement);
    }

    updateAbonement(abonement: IndividualAbonement) {
        return this.http.put(this.url, abonement);
    }

    deleteAbonement(id: any) {
         return this.http.delete(this.url + '/' + id);
    }

 
}