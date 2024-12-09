import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { AuthorDataService } from './../../../shared/data.services/author.data.service';
import { Author } from './../author';


@Component({

    styleUrl: './author-edit.component.css',
    templateUrl: './author-edit.component.html',

})
export class AuthorEditComponent implements OnInit {

    id: string;
    item: Author;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: AuthorDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAuthor(this.id)
                .subscribe((data: Author) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateAuthor(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

