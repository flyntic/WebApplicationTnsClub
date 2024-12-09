import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { AbonementDataService } from './../../../shared/data.services/abonement.data.service';
import { FileService } from './../../../file.service';
import { Abonement } from './../abonement';


@Component({

    styleUrl: './abonement-list.component.css',
    templateUrl: './abonement-list.component.html'
})
export class AbonementListComponent implements OnInit {

    items: Abonement[];


    constructor(private dataService: AbonementDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getAbonements().subscribe((data: Abonement[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteAbonement(id).subscribe(data => this.load());
    }
}


