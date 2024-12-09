import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ManagerDataService } from './../../../shared/data.services/manager.data.service';
import { Manager } from './../manager';


@Component({

    styleUrl: './manager-edit.component.css',
    templateUrl: './manager-edit.component.html',

})
export class ManagerEditComponent implements OnInit {

    id: string;
    item: Manager;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: ManagerDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getManager(this.id)
                .subscribe((data: Manager) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateManager(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

