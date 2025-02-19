import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthorDataService } from './../../../../shared/data.services/user.data.services/author.data.service';
import { Author } from './../author';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './author-create.component.html',
    styleUrl: './author-create.component.css',

})
export class AuthorCreateComponent implements OnInit {

    item: Author = new Author();    // добавляемый объект

    constructor(private dataService: AuthorDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createAuthor(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}
