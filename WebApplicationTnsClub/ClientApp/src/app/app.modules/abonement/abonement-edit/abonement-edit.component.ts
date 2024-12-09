import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { AbonementDataService } from './../../../shared/data.services/abonement.data.service';
import { Abonement } from './../abonement';


@Component({

    styleUrl: './abonement-edit.component.css',
    templateUrl: './abonement-edit.component.html',

})
export class AbonementEditComponent implements OnInit {

    id: string;
    item: Abonement;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: AbonementDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAbonement(this.id)
                .subscribe((data: Abonement) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateAbonement(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

