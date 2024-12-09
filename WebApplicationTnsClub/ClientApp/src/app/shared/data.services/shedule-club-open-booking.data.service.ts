import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { SheduleClubOpenBooking } from '../../app.modules/shedule-club-open-booking/shedule-club-open-booking';

@Injectable()
export class SheduleClubOpenBookingDataService {

    private url = "/api/shedule-club-open-booking";

    constructor(private http: HttpClient) {
        //console.log("Http client");
    }

    getSheduleClubOpenBookings() {
        return this.http.get(this.url);
    }

    getSheduleClubOpenBooking(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createSheduleClubOpenBooking(sheduleClubOpenBooking: SheduleClubOpenBooking) {
        return this.http.post(this.url, sheduleClubOpenBooking);
    }

    updateSheduleClubOpenBooking(sheduleClubOpenBooking: SheduleClubOpenBooking) {
        return this.http.put(this.url, sheduleClubOpenBooking);
    }

    deleteSheduleClubOpenBooking(id: any) {
       return this.http.delete(this.url + '/' + id);
    }

 
}