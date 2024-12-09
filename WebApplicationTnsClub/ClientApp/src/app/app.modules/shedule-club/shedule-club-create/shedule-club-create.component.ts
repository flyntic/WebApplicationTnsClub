import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SheduleClubDataService } from './../../../shared/data.services/shedule-club.data.service';
import { SheduleClub } from './../shedule-club';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './shedule-club-create.component.html',
    styleUrl: './shedule-club-create.component.css',

})
export class SheduleClubCreateComponent implements OnInit {

    item: SheduleClub = new SheduleClub();    // добавляемый объект

    constructor(private dataService: SheduleClubDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createSheduleClub(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}
