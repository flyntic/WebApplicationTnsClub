import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthorDataService } from './../../../shared/data.services/author.data.service';
import { Author } from './../author';

@Component({
    templateUrl: './author-detail.component.html',
    styleUrl: './author-detail.component.css',
})

export class AuthorDetailComponent implements OnInit {

    id: string;
    item: Author;
    loaded: boolean = false;

    constructor(private dataService: AuthorDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAuthor(this.id)
                .subscribe((data: Author) => { this.item = data; this.loaded = true; });
    }
}
