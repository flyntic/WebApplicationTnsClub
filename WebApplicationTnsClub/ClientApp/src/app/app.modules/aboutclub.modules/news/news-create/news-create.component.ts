import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { NewsDataService } from './../../../../shared/data.services/aboutclub.data.services/news.data.service';
import { News } from './../news';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './news-create.component.html',
    styleUrl: './news-create.component.css',

})
export class NewsCreateComponent implements OnInit {

    item: News = new News();    // добавляемый объект

    constructor(private dataService: NewsDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createNews(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}
