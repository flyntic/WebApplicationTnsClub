import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { PlayerDataService } from './../../../../shared/data.services/user.data.services/player.data.service';
import { Player } from './../player';


@Component({

    styleUrl: './player-edit.component.css',
    templateUrl: './player-edit.component.html',

})
export class PlayerEditComponent implements OnInit {

    id: string;
    item: Player;    // טחלוםÿולûי מבתוךע
    loaded: boolean = false;

    constructor(private dataService: PlayerDataService, private router: Router, activeRoute: ActivatedRoute) {

        this.id = String(activeRoute.snapshot.params["id"]);

    }

    ngOnInit() {
        if (this.id)
            this.dataService.getPlayer(this.id)
                .subscribe((data: Player) => {
                    this.item = data;
                    if (this.item != null) this.loaded = true;
                });

    }

    save() {

        this.dataService.updatePlayer(this.item).subscribe(data => this.router.navigateByUrl("/"));
    }
}

