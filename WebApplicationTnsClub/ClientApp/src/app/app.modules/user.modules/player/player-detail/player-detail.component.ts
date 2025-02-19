import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PlayerDataService } from './../../../../shared/data.services/user.data.services/player.data.service';
import { Player } from './../player';

@Component({
    templateUrl: './player-detail.component.html',
    styleUrl: './player-detail.component.css',
})

export class PlayerDetailComponent implements OnInit {

    id: string;
    item: Player;
    loaded: boolean = false;

    constructor(private dataService: PlayerDataService, activeRoute: ActivatedRoute) {
        this.id = String(activeRoute.snapshot.params["id"]);


    }

    ngOnInit() {
        if (this.id)
            this.dataService.getPlayer(this.id)
                .subscribe((data: Player) => { this.item = data; this.loaded = true; });
    }
}