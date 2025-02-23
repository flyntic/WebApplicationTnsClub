import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ParentDataService } from './../../../../shared/data.services/user.data.services/parent.data.service';
import { Parent } from './../parent';


@Component({

    styleUrl: './parent-edit.component.css',
    templateUrl: './parent-edit.component.html',

})
export class ParentEditComponent implements OnInit {

    id: string;
    item: Parent;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: ParentDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getParent(this.id)
                .subscribe((data: Parent) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateParent(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

