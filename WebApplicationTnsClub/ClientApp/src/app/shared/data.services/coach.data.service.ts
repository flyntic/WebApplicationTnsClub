import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Coach } from '../../app.modules/coach/coach';

@Injectable()
export class CoachDataService {

    private url = "/api/coachs";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getCoachs() {
        return this.http.get(this.url);
    }

    getCoach(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createCoach(coach: Coach) {
        return this.http.post(this.url, coach);
    }

    updateCoach(coach: Coach) {
        return this.http.put(this.url, coach);
    }

    deleteCoach(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}