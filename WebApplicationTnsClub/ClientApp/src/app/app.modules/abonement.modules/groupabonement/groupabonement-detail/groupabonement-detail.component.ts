import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GroupAbonementDataService } from '../../../../shared/data.services/abonement.data.services/groupabonement.data.service';
import { GroupAbonement } from './../groupabonement';

@Component({
    templateUrl: './groupabonement-detail.component.html',
    styleUrl: './groupabonement-detail.component.css',
})

export class GroupAbonementDetailComponent implements OnInit {

    id: string;
    abonement: GroupAbonement;
    loaded: boolean = false;

    constructor(private dataService: GroupAbonementDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getAbonement(this.id)
                .subscribe((data: GroupAbonement) => { this.abonement = data; this.loaded = true; });
    }
}

