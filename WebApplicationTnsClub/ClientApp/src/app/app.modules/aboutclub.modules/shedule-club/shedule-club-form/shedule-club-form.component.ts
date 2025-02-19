import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { SheduleClub } from './../shedule-club';
import { SheduleClubDataService } from './../../../../shared/data.services/aboutclub.data.services/shedule-club.data.service';


@Component({
    selector: "shedule-club-form",
    styleUrl: './shedule-club-form.component.css',
    templateUrl: './shedule-club-form.component.html'
})

export class SheduleClubFormComponent {
    @Input() item: SheduleClub;
    constructor(public dataService: SheduleClubDataService, private http: HttpClient) { console.log(http); }

}