import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Club } from './../../../app.modules/aboutclub.modules/club/club';

@Injectable()
export class ClubDataService {

    private url = "/api/clubs";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getClubs() {
        return this.http.get(this.url);
    }

    getClub(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createClub(club: Club) {
        return this.http.post(this.url, club);
    }

    updateClub(club: Club) {
        return this.http.put(this.url, club);
    }

    deleteClub(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}