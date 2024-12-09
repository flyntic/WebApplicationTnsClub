import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Abonement } from './../abonement';
import { AbonementDataService } from './../../../shared/data.services/abonement.data.service';


@Component({
    selector: "abonement-form",
    styleUrl: './abonement-form.component.css',
    templateUrl: './abonement-form.component.html'
})

export class AbonementFormComponent {
    @Input() item: Abonement;
    constructor(public dataService: AbonementDataService, private http: HttpClient) { console.log(http); }

}

