import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GroupDataService } from './../../../../shared/data.services/group.data.services/group.data.service';
import { Group } from './../group';

@Component({
    templateUrl: './group-detail.component.html',
    styleUrl: './group-detail.component.css',
})

export class GroupDetailComponent implements OnInit {

    id: string;
    item: Group;
    loaded: boolean = false;

    constructor(private dataService: GroupDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getGroup(this.id)
                .subscribe((data: Group) => { this.item = data; this.loaded = true; });
    }
}
