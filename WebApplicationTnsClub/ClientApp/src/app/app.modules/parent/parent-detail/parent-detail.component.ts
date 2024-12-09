import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ParentDataService } from './../../../shared/data.services/parent.data.service';
import { Parent } from './../parent';

@Component({
    templateUrl: './parent-detail.component.html',
    styleUrl: './parent-detail.component.css',
})

export class ParentDetailComponent implements OnInit {

    id: string;
    item: Parent;
    loaded: boolean = false;

    constructor(private dataService: ParentDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getParent(this.id)
                .subscribe((data: Parent) => { this.item = data; this.loaded = true; });
    }
}
