import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { ParentDataService } from './../../../shared/data.services/parent.data.service';
import { FileService } from './../../../file.service';
import { Parent } from './../parent';


@Component({

    styleUrl: './parent-list.component.css',
    templateUrl: './parent-list.component.html'
})
export class ParentListComponent implements OnInit {

    items: Parent[];


    constructor(private dataService: ParentDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getParents().subscribe((data: Parent[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteParent(id).subscribe(data => this.load());
    }
}


