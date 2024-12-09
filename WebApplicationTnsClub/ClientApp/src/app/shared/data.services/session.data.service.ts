import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Session } from '../../app.modules/session/session';

@Injectable()
export class SessionDataService {

    private url = "/api/sessions";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getSessions() {
        return this.http.get(this.url);
    }

    getSession(id: string) {
        return this.http.get(this.url + '/' + id); 
    }

    createSession(session: Session) {
        return this.http.post(this.url, session);
    }

    updateSession(session: Session) {
        return this.http.put(this.url, session);
    }

    deleteSession(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}