import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Club } from './../club';
import { ClubDataService } from './../../../shared/data.services/club.data.service';


@Component({
    selector: "club-form",
    styleUrl: './club-form.component.css',
    templateUrl: './club-form.component.html'
})

export class ClubFormComponent {
    @Input() item: Club;
    constructor(public dataService: ClubDataService, private http: HttpClient) { console.log(http); }

}