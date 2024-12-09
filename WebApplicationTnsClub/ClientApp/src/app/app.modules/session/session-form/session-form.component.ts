import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Session } from './../session';
import { SessionDataService } from './../../../shared/data.services/session.data.service';


@Component({
    selector: "session-form",
    styleUrl: './session-form.component.css',
    templateUrl: './session-form.component.html'
})

export class SessionFormComponent {
    @Input() item: Session;
    constructor(public dataService: SessionDataService, private http: HttpClient) { console.log(http); }

}
