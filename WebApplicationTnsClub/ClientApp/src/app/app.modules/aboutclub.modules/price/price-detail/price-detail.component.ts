import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PriceDataService } from './../../../../shared/data.services/aboutclub.data.services/price.data.service';
import { Price } from './../price';

@Component({
    templateUrl: './price-detail.component.html',
    styleUrl: './price-detail.component.css',
})

export class PriceDetailComponent implements OnInit {

    id: string;
    item: Price;
    loaded: boolean = false;

    constructor(private dataService: PriceDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getPrice(this.id)
                .subscribe((data: Price) => { this.item = data; this.loaded = true; });
    }
}
