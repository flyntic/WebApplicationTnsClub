import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { IndividualAbonement } from './../individualabonement';
import { IndividualAbonementDataService } from '../../../../shared/data.services/abonement.data.services/individualabonement.data.service';
import { FormsModule } from '@angular/forms';

@Component({
    selector: "individualabonement-form",
    styleUrl: './individualabonement-form.component.css',
    templateUrl: './individualabonement-form.component.html',
    standalone: true,
    imports:[FormsModule]
  
})

export class IndividualAbonementFormComponent {
    @Input('abonement') abonement: IndividualAbonement;
    constructor(public dataService: IndividualAbonementDataService, private http: HttpClient) {  }

}

