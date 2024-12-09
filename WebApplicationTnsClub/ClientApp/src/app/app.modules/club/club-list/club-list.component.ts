import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { ClubDataService } from './../../../shared/data.services/club.data.service';
import { FileService } from './../../../file.service';
import { Club } from './../club';


@Component({
    styleUrl: './club-list.component.css',
    templateUrl: './club-list.component.html'
})

export class ClubListComponent implements OnInit{

    items: Club[];

    constructor(private dataService: ClubDataService, private fileService: FileService,
        private router: Router) {  }

    ngOnInit() {

        this.load();

    }

    load() {
        this.dataService.getClubs().subscribe((data: Club[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteClub(id).subscribe(data => this.load());
    }
}
