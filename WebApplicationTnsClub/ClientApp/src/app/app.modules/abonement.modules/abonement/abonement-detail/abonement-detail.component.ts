import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AbonementDataService } from '../../../../shared/data.services/abonement.data.services/abonement.data.service';
import { Abonement } from './../abonement';

@Component({
    templateUrl: './abonement-detail.component.html',
    styleUrl: './abonement-detail.component.css',
})

export class AbonementDetailComponent implements OnInit {

    id: string;
    abonement: Abonement;
    loaded: boolean = false;

    constructor(private dataService: AbonementDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAbonement(this.id)
                .subscribe((data: Abonement) => { this.abonement = data; this.loaded = true; });
    }
}

