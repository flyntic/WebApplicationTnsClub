import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { News } from './../news';
import { NewsDataService } from './../../../shared/data.services/news.data.service';


@Component({
    selector: "news-form",
    styleUrl: './news-form.component.css',
    templateUrl: './news-form.component.html'
})

export class NewsFormComponent {
    @Input() item: News;
    constructor(public dataService: NewsDataService, private http: HttpClient) { console.log(http); }

}
