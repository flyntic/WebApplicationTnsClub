import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { SheduleClubDataService } from './../../../shared/data.services/shedule-club.data.service';
import { FileService } from './../../../file.service';
import { SheduleClub } from './../shedule-club';


@Component({
    styleUrl: './shedule-club-list.component.css',
    templateUrl: './shedule-club-list.component.html'
})

export class SheduleClubListComponent implements OnInit {

    items: SheduleClub[];

    constructor(private dataService: SheduleClubDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }

    load() {
        this.dataService.getSheduleClubs().subscribe((data: SheduleClub[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteSheduleClub(id).subscribe(data => this.load());
    }
}
