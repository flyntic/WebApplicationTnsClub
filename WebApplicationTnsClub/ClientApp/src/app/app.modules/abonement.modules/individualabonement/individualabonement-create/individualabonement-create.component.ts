
import { Component } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { IndividualAbonementDataService } from '../../../../shared/data.services/abonement.data.services/individualabonement.data.service';
import { IndividualAbonementFormComponent } from './../individualabonement-form/individualabonement-form.component';

import { IndividualAbonement } from './../individualabonement';
import { OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';


@Component({

    templateUrl: './individualabonement-create.component.html',
    styleUrl: './individualabonement-create.component.css',
    imports: [IndividualAbonementFormComponent, FormsModule],
    standalone:true
})

export class IndividualAbonementCreateComponent implements OnInit {

    
    abonement: IndividualAbonement = new IndividualAbonement();
   

    constructor(private dataService: IndividualAbonementDataService, private router: Router, activeRoute: ActivatedRoute) {

       

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
