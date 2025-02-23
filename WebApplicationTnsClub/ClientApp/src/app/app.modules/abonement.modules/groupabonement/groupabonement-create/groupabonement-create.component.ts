
import { Component } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { GroupAbonementDataService } from '../../../../shared/data.services/abonement.data.services/groupabonement.data.service';
import { GroupAbonementFormComponent } from './../groupabonement-form/groupabonement-form.component';

import { GroupAbonement } from './../groupabonement';
import { OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';


@Component({

    templateUrl: './groupabonement-create.component.html',
    styleUrl: './groupabonement-create.component.css',
    imports: [GroupAbonementFormComponent, FormsModule],
    standalone:true
})

export class GroupAbonementCreateComponent implements OnInit {

    
    abonement: GroupAbonement = new GroupAbonement();
   

    constructor(private dataService: GroupAbonementDataService, private router: Router, activeRoute: ActivatedRoute) {

       

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
