import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Price } from './../price';
import { PriceDataService } from './../../../shared/data.services/price.data.service';


@Component({
    selector: "price-form",
    styleUrl: './price-form.component.css',
    templateUrl: './price-form.component.html'
})

export class PriceFormComponent {
    @Input() item: Price;
    constructor(public dataService: PriceDataService, private http: HttpClient) { console.log(http); }

}
