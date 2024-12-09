import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ManagerDataService } from './../../../shared/data.services/manager.data.service';
import { Manager } from './../manager';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './manager-create.component.html',
    styleUrl: './manager-create.component.css',

})
export class ManagerCreateComponent implements OnInit {

    item: Manager = new Manager();    // добавляемый объект

    constructor(private dataService: ManagerDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createManager(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}
