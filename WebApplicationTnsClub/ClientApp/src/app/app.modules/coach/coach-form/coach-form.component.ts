import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Coach } from './../coach';
import { CoachDataService } from './../../../shared/data.services/coach.data.service';


@Component({
    selector: "coach-form",
    styleUrl: './coach-form.component.css',
    templateUrl: './coach-form.component.html'
})

export class CoachFormComponent {
    @Input() item: Coach;
    constructor(public dataService: CoachDataService, private http: HttpClient) { console.log(http); }

}

