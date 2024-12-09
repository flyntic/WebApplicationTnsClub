import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Group } from './../group';
import { GroupDataService } from './../../../shared/data.services/group.data.service';


@Component({
    selector: "group-form",
    styleUrl: './group-form.component.css',
    templateUrl: './group-form.component.html'
})

export class GroupFormComponent {
    @Input() item: Group;
    constructor(public dataService: GroupDataService, private http: HttpClient) { console.log(http); }

}

