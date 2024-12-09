import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Author } from './../author';
import { AuthorDataService } from './../../../shared/data.services/author.data.service';


@Component({
    selector: "author-form",
    styleUrl: './author-form.component.css',
    templateUrl: './author-form.component.html'
})

export class AuthorFormComponent {
    @Input() item: Author;
    constructor(public dataService: AuthorDataService, private http: HttpClient) { console.log(http); }

}
