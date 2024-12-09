import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { PlayerDataService } from './../../../shared/data.services/player.data.service';
import { FileService } from './../../../file.service';
import { Player } from './../player';


@Component({

    styleUrl: './player-list.component.css',
    templateUrl: './player-list.component.html'
})
export class PlayerListComponent implements OnInit {

    items: Player[];


    constructor(private dataService: PlayerDataService, private fileService: FileService,
        private router: Router) { }

    ngOnInit() {

        this.load();

    }
    load() {
        this.dataService.getPlayers().subscribe((data: Player[]) => {

            this.items = data;
        });


    }

    delete(id: any) {

        this.dataService.deletePlayer(id).subscribe(data => this.load());
    }
}

