import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { CoachDataService } from './../../../../shared/data.services/user.data.services/coach.data.service';
import { FileService } from './../../../../file.service';
import { Coach } from './../coach';


@Component({

    styleUrl: './coach-list.component.css',
    templateUrl: './coach-list.component.html'
})
export class CoachListComponent implements OnInit {

    items: Coach[];


    constructor(private dataService: CoachDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getCoachs().subscribe((data: Coach[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteCoach(id).subscribe(data => this.load());
    }
}
