import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Admin } from './../admin';
import { AdminDataService } from './../../../../shared/data.services/user.data.services/admin.data.service';


@Component({
    selector: "admin-form",
    styleUrl: './admin-form.component.css',
    templateUrl: './admin-form.component.html'
})

export class AdminFormComponent {
    @Input() item: Admin;
    constructor(public dataService: AdminDataService, private http: HttpClient) { console.log(http); }

}

