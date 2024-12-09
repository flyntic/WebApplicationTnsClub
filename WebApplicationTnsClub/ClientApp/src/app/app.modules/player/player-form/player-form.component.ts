import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Player } from './../player';
import { PlayerDataService } from './../../../shared/data.services/player.data.service';


@Component({
    selector: "player-form",
    styleUrl: './player-form.component.css',
    templateUrl: './player-form.component.html'
})

export class PlayerFormComponent {
    @Input() item: Player;
    constructor(public dataService: PlayerDataService, private http: HttpClient) { console.log(http); }

}
