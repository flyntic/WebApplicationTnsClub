import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { AdminDataService } from './../../../../shared/data.services/user.data.services/admin.data.service';
import { FileService } from './../../../../file.service';
import { Admin } from './../admin';


@Component({

    styleUrl: './admin-list.component.css',
    templateUrl: './admin-list.component.html'
})
export class AdminListComponent implements OnInit {

    items: Admin[];


    constructor(private dataService: AdminDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getAdmins().subscribe((data: Admin[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deleteAdmin(id).subscribe(data => this.load());
    }
}

