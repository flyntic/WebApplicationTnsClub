import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AbonementDetailComponent } from './individualabonement-detail/individualabonement-detail.component';
import { AbonementEditComponent }   from   './individualabonement-edit/individualabonement-edit.component';
import { AbonementFormComponent }   from   './individualabonement-form/individualabonement-form.component';
import { AbonementListComponent }   from   './individualabonement-list/individualabonement-list.component';
import { AbonementCreateComponent } from './individualabonement-create/individualabonement-create.component';



import { AbonementDataService } from './../../shared/data.services/individualabonement.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule,
              ReactiveFormsModule, RouterLink,
              AbonementFormComponent],
    declarations: [
        AbonementCreateComponent,
        AbonementListComponent,
        AbonementDetailComponent,
        AbonementEditComponent,
      //  AbonementFormComponent

    ],
    exports: [
        AbonementListComponent,
        AbonementEditComponent,
        AbonementCreateComponent,
       // AbonementFormComponent
    ],
    providers: [AbonementDataService, FileService]
})
export class AbonementModule { }

