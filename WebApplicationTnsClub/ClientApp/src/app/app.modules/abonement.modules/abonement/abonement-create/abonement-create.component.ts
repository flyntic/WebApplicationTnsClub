
import { Component } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { AbonementDataService } from '../../../../shared/data.services/abonement.data.services/abonement.data.service';
import { AbonementFormComponent } from './../abonement-form/abonement-form.component';

import { Abonement } from './../abonement';
import { OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';


@Component({

    templateUrl: './abonement-create.component.html',
    styleUrl: './abonement-create.component.css',
    imports: [AbonementFormComponent, FormsModule],
    standalone:true
})

export class AbonementCreateComponent implements OnInit {

    
    abonement: Abonement = new Abonement();
   

    constructor(private dataService: AbonementDataService, private router: Router, activeRoute: ActivatedRoute) {

       

    }

    ngOnInit() {
        
    }

    save() {

        this.dataService.createAbonement(this.abonement).subscribe(data => this.router.navigateByUrl("/"));
   }
}
/*
export class AbonementCreateComponent implements OnInit {

    abonement: Abonement = new Abonement();;   // добавляемый объект

    constructor(private dataService: AbonementDataService, private router: Router, activeRoute: ActivatedRoute) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createAbonement(this.abonement).subscribe(data => this.router.navigateByUrl("/"));
    }

}*/
/*
import { Component } from '@angular/core';

@Component({
  selector: 'abonement-create',
  standalone: true,
  imports: [],
  templateUrl: './abonement-create.component.html',
  styleUrl: './abonement-create.component.css'
})
export class AbonementCreateComponent {

}*/
