import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { GroupAbonementDataService } from '../../../../shared/data.services/abonement.data.services/groupabonement.data.service';
import { GroupAbonement } from './../groupabonement';


@Component({

    styleUrl: './groupabonement-edit.component.css',
    templateUrl: './groupabonement-edit.component.html',

})
export class GroupAbonementEditComponent implements OnInit {

    id: string;
    abonement: GroupAbonement;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: GroupAbonementDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAbonement(this.id)
                .subscribe((data: GroupAbonement) => {
                    this.abonement = data;
                    if (this.abonement != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateAbonement(this.abonement).subscribe(data => this.router.navigateByUrl("/"));
    }
}

