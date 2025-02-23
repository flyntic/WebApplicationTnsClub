import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Booking } from './../../../app.modules/booking.modules/booking/booking';

@Injectable()
export class BookingDataService {

    private url = "/api/bookings";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getBookings() {
        return this.http.get(this.url);
    }

    getBooking(id: string) {
        return this.http.get(this.url + '/' + id); 
    }

    createBooking(booking: Booking) {
        return this.http.post(this.url, booking);
    }

    updateBooking(booking: Booking) {
        return this.http.put(this.url, booking);
    }

    deleteBooking(id: any) {
       return this.http.delete(this.url + '/' + id);
    }

 
}