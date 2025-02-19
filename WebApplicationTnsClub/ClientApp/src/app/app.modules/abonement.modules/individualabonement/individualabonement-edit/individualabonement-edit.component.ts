import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { IndividualAbonementDataService } from '../../../../shared/data.services/abonement.data.services/individualabonement.data.service';
import { IndividualAbonement } from './../individualabonement';


@Component({

    styleUrl: './individualabonement-edit.component.css',
    templateUrl: './individualabonement-edit.component.html',

})
export class IndividualAbonementEditComponent implements OnInit {

    id: string;
    abonement: IndividualAbonement;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: IndividualAbonementDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAbonement(this.id)
                .subscribe((data: IndividualAbonement) => {
                    this.abonement = data;
                    if (this.abonement != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updateAbonement(this.abonement).subscribe(data => this.router.navigateByUrl("/"));
    }
}

