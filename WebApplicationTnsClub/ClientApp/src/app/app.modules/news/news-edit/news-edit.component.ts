import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { NewsDataService } from './../../../shared/data.services/news.data.service';
import { News } from './../news';


@Component({

    styleUrl: './news-edit.component.css',
    templateUrl: './news-edit.component.html',

})
export class NewsEditComponent implements OnInit {

    id: string;
    item: News;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: NewsDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getNews(this.id)
                .subscribe((data: News) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateNews(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

