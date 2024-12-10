import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AbonementDetailComponent } from './abonement-detail/abonement-detail.component';
import { AbonementEditComponent }   from './abonement-edit/abonement-edit.component';
import { AbonementFormComponent }   from './abonement-form/abonement-form.component';
import { AbonementListComponent }   from './abonement-list/abonement-list.component';
import { AbonementCreateComponent } from './abonement-create/abonement-create.component';



import { AbonementDataService } from './../../shared/data.services/abonement.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        AbonementCreateComponent,
        AbonementListComponent,
        AbonementDetailComponent,
        AbonementEditComponent,
        AbonementFormComponent

    ],
    exports: [
        AbonementListComponent,
        AbonementEditComponent,
        AbonementCreateComponent
    ],
    providers: [AbonementDataService, FileService]
})
export class AbonementModule { }
