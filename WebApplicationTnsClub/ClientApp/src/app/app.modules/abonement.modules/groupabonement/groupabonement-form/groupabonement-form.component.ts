import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { GroupAbonement } from './../groupabonement';
import { GroupAbonementDataService } from '../../../../shared/data.services/abonement.data.services/groupabonement.data.service';
import { FormsModule } from '@angular/forms';

@Component({
    selector: "groupabonement-form",
    styleUrl: './groupabonement-form.component.css',
    templateUrl: './groupabonement-form.component.html',
    standalone: true,
    imports:[FormsModule]
  
})

export class GroupAbonementFormComponent {
    @Input('abonement') abonement: GroupAbonement;
    constructor(public dataService: GroupAbonementDataService, private http: HttpClient) {  }

}

