import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, RouterLink } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PlayerDetailComponent } from './player-detail/player-detail.component';
import { PlayerEditComponent } from './player-edit/player-edit.component';
import { PlayerFormComponent } from './player-form/player-form.component';
import { PlayerListComponent } from './player-list/player-list.component';
import { PlayerCreateComponent } from './player-create/player-create.component';


import { PlayerDataService } from './../../shared/data.services/player.data.service';
import { FileService } from './../../file.service';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterLink,],
    declarations: [PlayerCreateComponent,
        PlayerListComponent,
        PlayerDetailComponent,
        PlayerEditComponent,
        PlayerFormComponent
    ],
    exports: [PlayerListComponent, PlayerEditComponent, PlayerCreateComponent],
    providers: [PlayerDataService, FileService]
})
export class PlayerModule { }
