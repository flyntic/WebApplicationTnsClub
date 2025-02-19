import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { PriceDataService } from './../../../../shared/data.services/aboutclub.data.services/price.data.service';
import { FileService } from './../../../../file.service';
import { Price } from './../price';


@Component({

    styleUrl: './price-list.component.css',
    templateUrl: './price-list.component.html'
})
export class PriceListComponent implements OnInit {

    prices: Price[];


    constructor(private dataService: PriceDataService, private fileService: FileService,
        private router: Router) {  }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getPrices().subscribe((data: Price[]) => {

            this.prices = data;
        });


    }

    delete(id: any) {

        this.dataService.deletePrice(id).subscribe(data => this.load());
    }
}

