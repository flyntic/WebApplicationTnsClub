import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { PriceDataService } from './../../../../shared/data.services/aboutclub.data.services/price.data.service';
import { Price } from './../price';


@Component({

    styleUrl: './price-edit.component.css',
    templateUrl: './price-edit.component.html',

})
export class PriceEditComponent implements OnInit {

    id: string;
    item: Price;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: PriceDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getPrice(this.id)
                .subscribe((data: Price) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updatePrice(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}
