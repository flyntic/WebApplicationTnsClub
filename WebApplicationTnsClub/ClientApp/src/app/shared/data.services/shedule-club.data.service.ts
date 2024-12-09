import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { SheduleClub } from '../../app.modules/shedule-club/shedule-club';

@Injectable()
export class SheduleClubDataService {

    private url = "/api/shedule-club";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getSheduleClubs() {
        return this.http.get(this.url);
    }

    getSheduleClub(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createSheduleClub(sheduleClub: SheduleClub) {
        return this.http.post(this.url, sheduleClub);
     }

    updateSheduleClub(sheduleClub: SheduleClub) {
        return this.http.put(this.url, sheduleClub);
    }

    deleteSheduleClub(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}