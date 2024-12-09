import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Price } from '../../app.modules/price/price';

@Injectable()
export class PriceDataService {

    private url = "/api/prices";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getPrices() {
        return this.http.get(this.url);
    }

    getPrice(id: string) {
        console.log("create user:");
        return this.http.get(this.url + '/' + id); 
    }

    createPrice(price: Price) {
        return this.http.post(this.url, price);
     }

    updatePrice(price: Price) {
        return this.http.put(this.url, price);
    }

    deletePrice(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}