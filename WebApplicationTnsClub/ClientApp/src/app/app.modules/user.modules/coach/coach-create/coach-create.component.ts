import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { CoachDataService } from './../../../../shared/data.services/user.data.services/coach.data.service';
import { Coach } from './../coach';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './coach-create.component.html',
    styleUrl: './coach-create.component.css',

})
export class CoachCreateComponent implements OnInit {

    item: Coach = new Coach();    // добавляемый объект

    constructor(private dataService: CoachDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createCoach(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}