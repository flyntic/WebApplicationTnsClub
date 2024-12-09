import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { Player } from '../../app.modules/player/player';

@Injectable()
export class PlayerDataService {

    private url = "/api/players";

    constructor(private http: HttpClient) {
        console.log("Http client");
    }

    getPlayers() {
        return this.http.get(this.url);
    }

    getPlayer(id: string) {
        return this.http.get(this.url + '/' + id); 
    }
    createPlayer(player: Player) {
        return this.http.post(this.url, player);
    }

    updatePlayer(player: Player) {
        return this.http.put(this.url, player);
    }

    deletePlayer(id: any) {
        return this.http.delete(this.url + '/' + id);
    }

 
}