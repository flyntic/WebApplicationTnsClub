import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { GroupDataService } from './../../../shared/data.services/group.data.service';
import { Group } from './../group';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './group-create.component.html',
    styleUrl: './group-create.component.css',

})
export class GroupCreateComponent implements OnInit {

    item: Group = new Group();    // добавляемый объект

    constructor(private dataService: GroupDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createGroup(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}

