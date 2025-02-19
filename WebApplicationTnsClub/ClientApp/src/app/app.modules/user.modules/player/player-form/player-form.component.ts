import { Component, Input } from '@angular/core';
import { HttpClient, HttpEventType, HttpRequest } from '@angular/common/http';
import { Player } from './../player';
import { PlayerDataService } from './../../../../shared/data.services/user.data.services/player.data.service';
import { FormsModule } from '@angular/forms';
import { environment } from '../../../../../environments/environment';

@Component({
    selector: "player-form",
    styleUrl: './player-form.component.css',
    templateUrl: './player-form.component.html',
    standalone: true,
    imports: [FormsModule]



})

export class PlayerFormComponent {
    @Input() user: Player;
    constructor(public dataService: PlayerDataService, private http: HttpClient) { console.log(http); }

    working = false;
    uploadFile: File | null;
    uploadFileLabel: string | undefined = 'Choose an image to upload';

    handleFileInput(files: FileList) {
        if (files.length > 0) {
            this.uploadFile = files.item(0);
            this.uploadFileLabel = this.uploadFile?.name;
        }
    }

    upload() {
        if (!this.uploadFile) {
            alert('Choose a file to upload first');
            return;
        }
        console.log(this.uploadFile);
        const formData = new FormData();
        formData.append(this.uploadFile.name, this.uploadFile);

        const url = `${environment.apiUrl}/upload`;

        const uploadReq = new HttpRequest('POST', url, formData, {
            reportProgress: true,
        });

        this.user.avatarFile = '';
        //  this.uploadProgress = 0;
        this.working = true;

        this.http.request(uploadReq).subscribe((event: any) => {
            if (event.type === HttpEventType.UploadProgress) {
                // this.uploadProgress = Math.round((100 * event.loaded) / event.total);
            } else if (event.type === HttpEventType.Response) {
                this.user.avatarFile = event.body.url;
            }
        }, (error: any) => {
            console.error(error);
        }).add(() => {
            this.working = false;
        });

    }
}
