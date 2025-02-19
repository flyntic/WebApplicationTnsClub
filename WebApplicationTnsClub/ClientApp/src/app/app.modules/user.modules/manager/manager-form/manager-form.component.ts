import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Manager } from './../manager';
import { ManagerDataService } from './../../../../shared/data.services/user.data.services/manager.data.service';


@Component({
    selector: "manager-form",
    styleUrl: './manager-form.component.css',
    templateUrl: './manager-form.component.html'
})

export class ManagerFormComponent {
    @Input() item: Manager;
    constructor(public dataService: ManagerDataService, private http: HttpClient) { console.log(http); }

}
