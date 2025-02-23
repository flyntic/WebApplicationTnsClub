import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { PlayerDataService } from './../../../../shared/data.services/user.data.services/player.data.service';
import { Player } from './../player';
import { OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { PlayerFormComponent } from './../player-form/player-form.component'

@Component({

    templateUrl: './player-create.component.html',
    styleUrl: './player-create.component.css',
    imports: [PlayerFormComponent, FormsModule],
    standalone: true


})
export class PlayerCreateComponent implements OnInit {

    user: Player = new Player();    // добавляемый объект

    constructor(private dataService: PlayerDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createPlayer(this.user).subscribe(data => this.router.navigateByUrl("/"));
    }

}