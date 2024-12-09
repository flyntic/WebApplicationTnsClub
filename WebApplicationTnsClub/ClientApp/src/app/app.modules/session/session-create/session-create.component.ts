import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SessionDataService } from './../../../shared/data.services/session.data.service';
import { Session } from './../session';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './session-create.component.html',
    styleUrl: './session-create.component.css',

})
export class SessionCreateComponent implements OnInit {

    item: Session = new Session();    // добавляемый объект

    constructor(private dataService: SessionDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createSession(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}