import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PriceDetailComponent } from './price-detail/price-detail.component';
import { PriceEditComponent }   from './price-edit/price-edit.component';
import { PriceFormComponent }   from './price-form/price-form.component';
import { PriceListComponent }   from './price-list/price-list.component';
import { PriceCreateComponent } from './price-create/price-create.component';


import { PriceDataService } from './../../shared/data.services/price.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [
        PriceCreateComponent,
        PriceListComponent,
        PriceDetailComponent,
        PriceEditComponent,
        PriceFormComponent
    ],
    exports: [
        PriceListComponent,
        PriceEditComponent,
        PriceCreateComponent],
    providers: [PriceDataService, FileService]
})
export class PriceModule { }
