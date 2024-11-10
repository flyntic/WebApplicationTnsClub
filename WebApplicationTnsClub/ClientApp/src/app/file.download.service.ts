import { Component } from '@angular/core';
import { FileService } from './file.service';

@Component({
    selector: 'app-file-download',
    template: `
    <button (click)="downloadFile()">Download File</button>
  `
})
export class FileDownloadComponent {

    constructor(private fileService: FileService) { }

    downloadFile() {
        const fileName = 'example.pdf'; // Replace with the actual file name
        this.fileService.downloadFile(fileName)
            .subscribe(blob => {
                const url = window.URL.createObjectURL(blob);
                const a = document.createElement('a');
                a.style.display = 'none';
                a.href = url;
                a.download = fileName;
                document.body.appendChild(a);
                a.click();
                window.URL.revokeObjectURL(url);
            }, error => {
                console.error('Error downloading the file', error);
                // Handle error as needed
            });
    }
}