import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { News } from '../../app.modules/news/news';

@Injectable()
export class NewsDataService {

    private url = "/api/newses";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getNewses() {
        return this.http.get(this.url);
    }

    getNews(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createNews(news: News) {
        return this.http.post(this.url, news);
    }

    updateNews(news: News) {
        return this.http.put(this.url, news);
    }

    deleteNews(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}