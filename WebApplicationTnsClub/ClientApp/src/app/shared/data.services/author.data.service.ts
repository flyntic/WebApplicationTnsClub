import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Author } from '../../app.modules/author/author';

@Injectable()
export class AuthorDataService {

    private url = "/api/authors";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getAuthors() {
        return this.http.get(this.url);
    }

    getAuthor(id: string) {
       return this.http.get(this.url + '/' + id); 
    }

    createAuthor(author: Author) {
        return this.http.post(this.url, author);
    }

    updateAuthor(author: Author) {
        return this.http.put(this.url, author);
    }

    deleteAuthor(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}