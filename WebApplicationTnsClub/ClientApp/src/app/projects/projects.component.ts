import { Component } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { FormsModule } from '@angular/forms';
import { Input } from '@angular/core';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-projects',
  standalone: true,
    imports: [FormsModule,NgFor],
  templateUrl: './projects.component.html',
  styleUrl: './projects.component.css'
})
export class ProjectsComponent {
    constructor(private htpp: HttpClient) {

    }
    @Input() projects: any = [];
    @Input() userId: any = "";
    async ngOnInit() {
        console.log("Proj_begin");
        this.projects = await this.htpp.get("/api/projects").toPromise();
        console.log(this.projects[0].id);
        console.log("Proj_end");
    }

    promote() {
        return this.htpp.post('/api/promote/${this.userId}', null).toPromise();
    }

    addUser(projectId:any) {
        return this.htpp.post('/api/projects/${projectId}/add-user/${this.userId}', null).toPromise();

    }
}
