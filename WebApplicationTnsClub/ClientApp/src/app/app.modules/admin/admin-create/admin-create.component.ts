import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AdminDataService } from './../../../shared/data.services/admin.data.service';
import { Admin } from './../admin';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './admin-create.component.html',
    styleUrl: './admin-create.component.css',

})
export class AdminCreateComponent implements OnInit {

    item: Admin = new Admin();    // добавляемый объект

    constructor(private dataService: AdminDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createAdmin(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}

