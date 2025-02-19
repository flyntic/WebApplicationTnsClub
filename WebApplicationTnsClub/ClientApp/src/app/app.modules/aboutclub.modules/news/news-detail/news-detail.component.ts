import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NewsDataService } from './../../../../shared/data.services/aboutclub.data.services/news.data.service';
import { News } from './../news';

@Component({
    templateUrl: './news-detail.component.html',
    styleUrl: './news-detail.component.css',
})

export class NewsDetailComponent implements OnInit {

    id: string;
    item: News;
    loaded: boolean = false;

    constructor(private dataService: NewsDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getNews(this.id)
                .subscribe((data: News) => { this.item = data; this.loaded = true; });
    }
}
