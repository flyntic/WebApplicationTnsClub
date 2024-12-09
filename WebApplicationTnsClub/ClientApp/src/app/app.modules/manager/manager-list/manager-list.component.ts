import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { ManagerDataService } from './../../../shared/data.services/manager.data.service';
import { FileService } from './../../../file.service';
import { Manager } from './../manager';


@Component({

    styleUrl: './manager-list.component.css',
    templateUrl: './manager-list.component.html'
})
export class ManagerListComponent implements OnInit {

    items: Manager[];


    constructor(private dataService: ManagerDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getManagers().subscribe((data: Manager[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteManager(id).subscribe(data => this.load());
    }
}

