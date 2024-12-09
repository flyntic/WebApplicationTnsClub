import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ParentDataService } from './../../../shared/data.services/parent.data.service';
import { Parent } from './../parent';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './parent-create.component.html',
    styleUrl: './parent-create.component.css',

})
export class ParentCreateComponent implements OnInit {

    item: Parent = new Parent();    // добавляемый объект

    constructor(private dataService: ParentDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createParent(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}
