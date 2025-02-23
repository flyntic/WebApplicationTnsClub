import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { GroupDataService } from './../../../../shared/data.services/group.data.services/group.data.service';
import { Group } from './../group';


@Component({

    styleUrl: './group-edit.component.css',
    templateUrl: './group-edit.component.html',

})
export class GroupEditComponent implements OnInit {

    id: string;
    item: Group;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: GroupDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getGroup(this.id)
                .subscribe((data: Group) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateGroup(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}
