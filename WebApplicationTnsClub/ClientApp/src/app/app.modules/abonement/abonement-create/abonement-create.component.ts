import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AbonementDataService } from './../../../shared/data.services/abonement.data.service';
import { Abonement } from './../abonement';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './abonement-create.component.html',
    styleUrl: './abonement-create.component.css',

})
export class AbonementCreateComponent implements OnInit {

    item: Abonement = new Abonement();    // добавляемый объект

    constructor(private dataService: AbonementDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createAbonement(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}
