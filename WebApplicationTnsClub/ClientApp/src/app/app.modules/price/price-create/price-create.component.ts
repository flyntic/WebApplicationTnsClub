import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { PriceDataService } from './../../../shared/data.services/price.data.service';
import { Price } from './../price';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './price-create.component.html',
    styleUrl: './price-create.component.css',

})
export class PriceCreateComponent implements OnInit {

    item: Price = new Price();    // добавляемый объект

    constructor(private dataService: PriceDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createPrice(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}