import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { IndividualAbonementDataService } from '../../../../shared/data.services/abonement.data.services/individualabonement.data.service';
import { FileService } from './../../../../file.service';
import { IndividualAbonement } from './../individualabonement';


@Component({

    styleUrl: './individualabonement-list.component.css',
    templateUrl: './individualabonement-list.component.html'
})

export class IndividualAbonementListComponent implements OnInit {

    items: IndividualAbonement[];


    constructor(private dataService: IndividualAbonementDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getAbonements().subscribe((data: IndividualAbonement[]) => {
      
            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteAbonement(id).subscribe(data => this.load());
    }
}


