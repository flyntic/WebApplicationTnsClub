import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IndividualAbonementDataService } from '../../../../shared/data.services/abonement.data.services/individualabonement.data.service';
import { IndividualAbonement } from './../individualabonement';

@Component({
    templateUrl: './individualabonement-detail.component.html',
    styleUrl: './individualabonement-detail.component.css',
})

export class IndividualAbonementDetailComponent implements OnInit {

    id: string;
    abonement: IndividualAbonement;
    loaded: boolean = false;

    constructor(private dataService: IndividualAbonementDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAbonement(this.id)
                .subscribe((data: IndividualAbonement) => { this.abonement = data; this.loaded = true; });
    }
}

