import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { AdminDataService } from './../../../../shared/data.services/user.data.services/admin.data.service';
import { Admin } from './../admin';


@Component({

    styleUrl: './admin-edit.component.css',
    templateUrl: './admin-edit.component.html',

})
export class AdminEditComponent implements OnInit {

    id: string;
    item: Admin;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: AdminDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAdmin(this.id)
                .subscribe((data: Admin) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateAdmin(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

