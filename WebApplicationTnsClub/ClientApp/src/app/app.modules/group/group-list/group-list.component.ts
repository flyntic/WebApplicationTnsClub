import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { GroupDataService } from './../../../shared/data.services/group.data.service';
import { FileService } from './../../../file.service';
import { Group } from './../group';


@Component({

    styleUrl: './group-list.component.css',
    templateUrl: './group-list.component.html'
})
export class GroupListComponent implements OnInit {

    items: Group[];


    constructor(private dataService: GroupDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getGroups().subscribe((data: Group[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteGroup(id).subscribe(data => this.load());
    }
}


