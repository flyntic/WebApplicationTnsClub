import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class FileService {

    private baseUrl = 'https://localhost:7094/api/'; // Adjust base URL as per your ASP.NET Core server

    constructor(private http: HttpClient) { }

    downloadFile(fileName: string): Observable<Blob> {
        const url = `${this.baseUrl}download/${fileName}`;
        return this.http.get(url, { responseType: 'blob' });
    }
}