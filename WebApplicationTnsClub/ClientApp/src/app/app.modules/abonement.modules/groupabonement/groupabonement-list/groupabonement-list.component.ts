import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { GroupAbonementDataService } from '../../../../shared/data.services/abonement.data.services/groupabonement.data.service';
import { FileService } from './../../../../file.service';
import { GroupAbonement } from './../groupabonement';


@Component({

    styleUrl: './groupabonement-list.component.css',
    templateUrl: './groupabonement-list.component.html'
})

export class GroupAbonementListComponent implements OnInit {

    items: GroupAbonement[];


    constructor(private dataService: GroupAbonementDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getAbonements().subscribe((data: GroupAbonement[]) => {
      
            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteAbonement(id).subscribe(data => this.load());
    }
}


