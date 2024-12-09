import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { AuthorDataService } from './../../../shared/data.services/author.data.service';
import { FileService } from './../../../file.service';
import { Author } from './../author';


@Component({

    styleUrl: './author-list.component.css',
    templateUrl: './author-list.component.html'
})
export class AuthorListComponent implements OnInit {

    items: Author[];


    constructor(private dataService: AuthorDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getAuthors().subscribe((data: Author[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteAuthor(id).subscribe(data => this.load());
    }
}

