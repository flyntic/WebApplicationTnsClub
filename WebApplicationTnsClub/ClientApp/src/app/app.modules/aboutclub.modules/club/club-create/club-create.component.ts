import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ClubDataService } from '../../../../shared/data.services/aboutclub.data.services/club.data.service';
import { Club } from '../club';
import { ClubFormComponent } from '../club-form/club-form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Input } from '@angular/core';

@Component({

    styleUrl: './club-create.component.css',
    templateUrl: './club-create.component.html',
    imports: [FormsModule, ClubFormComponent],
    standalone:true

})

export class ClubCreateComponent implements OnInit {

   // id: string;
   @Input() item!: Club;    // טחלוםÿולûי מבתוךע
   // loaded: boolean = false;

    constructor(private dataService: ClubDataService, private router: Router, activeRoute: ActivatedRoute) {
        this.item = new Club();
     //   this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
       /* if (this.id)
            this.dataService.getClub(this.id)
                .subscribe((data: Club) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });
*/
    }

    save() {
        this.dataService.createClub(this.item).subscribe(data => this.router.navigateByUrl("/"));

       // this.dataService.updateClub(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}


