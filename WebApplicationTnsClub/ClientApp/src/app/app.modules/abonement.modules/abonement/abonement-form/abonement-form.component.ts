import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Abonement } from './../abonement';
import { AbonementDataService } from '../../../../shared/data.services/abonement.data.services/abonement.data.service';
import { FormsModule } from '@angular/forms';

@Component({
    selector: "abonement-form",
    styleUrl: './abonement-form.component.css',
    templateUrl: './abonement-form.component.html',
    standalone: true,
    imports:[FormsModule]
  
})

export class AbonementFormComponent {
    @Input('abonement') abonement: Abonement;
    constructor(public dataService: AbonementDataService, private http: HttpClient) {  }

}

