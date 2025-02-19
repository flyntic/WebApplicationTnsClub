import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Parent } from './../parent';
import { ParentDataService } from './../../../../shared/data.services/user.data.services/parent.data.service';


@Component({
    selector: "parent-form",
    styleUrl: './parent-form.component.css',
    templateUrl: './parent-form.component.html'
})

export class ParentFormComponent {
    @Input() item: Parent;
    constructor(public dataService: ParentDataService, private http: HttpClient) { console.log(http); }

}
