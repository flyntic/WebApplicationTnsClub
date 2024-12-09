import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ClubDataService } from './../../../shared/data.services/club.data.service';
import { Club } from './../club';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './club-create.component.html',
    styleUrl: './club-create.component.css',

})
export class ClubCreateComponent implements OnInit {

    item: Club = new Club();    // добавляемый объект

    constructor(private dataService: ClubDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createClub(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}
