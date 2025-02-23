import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { GroupAbonementDetailComponent } from './groupabonement-detail/groupabonement-detail.component';
import { GroupAbonementEditComponent }   from   './groupabonement-edit/groupabonement-edit.component';
import { GroupAbonementFormComponent }   from   './groupabonement-form/groupabonement-form.component';
import { GroupAbonementListComponent }   from   './groupabonement-list/groupabonement-list.component';
import { GroupAbonementCreateComponent } from './groupabonement-create/groupabonement-create.component';



import { GroupAbonementDataService } from './../../../shared/data.services/abonement.data.services/groupabonement.data.service';
import { FileService } from './../../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule,
              ReactiveFormsModule, RouterLink,
              GroupAbonementFormComponent],
    declarations: [
        GroupAbonementCreateComponent,
        GroupAbonementListComponent,
        GroupAbonementDetailComponent,
        GroupAbonementEditComponent,
      //  AbonementFormComponent

    ],
    exports: [
        GroupAbonementListComponent,
        GroupAbonementEditComponent,
        GroupAbonementCreateComponent,
       // AbonementFormComponent
    ],
    providers: [GroupAbonementDataService, FileService]
})
export class GroupAbonementModule { }

