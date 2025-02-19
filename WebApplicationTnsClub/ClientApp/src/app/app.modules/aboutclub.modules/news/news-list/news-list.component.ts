import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { NewsDataService } from './../../../../shared/data.services/aboutclub.data.services/news.data.service';
import { FileService } from './../../../../file.service';
import { News } from './../news';


@Component({
    styleUrl: './news-list.component.css',
    templateUrl: './news-list.component.html'
})

export class NewsListComponent implements OnInit {

    items: News[];

    constructor(private dataService: NewsDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }

    load() {
        this.dataService.getNewses().subscribe((data: News[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteNews(id).subscribe(data => this.load());
    }
}
