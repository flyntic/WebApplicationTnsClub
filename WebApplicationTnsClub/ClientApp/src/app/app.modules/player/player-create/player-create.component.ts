import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { PlayerDataService } from './../../../shared/data.services/player.data.service';
import { Player } from './../player';
import { OnInit } from '@angular/core';


@Component({

    templateUrl: './player-create.component.html',
    styleUrl: './player-create.component.css',

})
export class PlayerCreateComponent implements OnInit {

    item: Player = new Player();    // добавляемый объект

    constructor(private dataService: PlayerDataService, private router: Router) { }

    ngOnInit() {

    }

    save() {

        this.dataService.createPlayer(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }

}