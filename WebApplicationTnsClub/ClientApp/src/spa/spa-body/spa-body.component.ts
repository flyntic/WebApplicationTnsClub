import { Component, OnInit } from '@angular/core';
import { Input } from '@angular/core';

@Component({
    selector: 'spa-body',
    templateUrl: './spa-body.component.html',
    styleUrls: ['./spa-body.component.css'],
})
export class SpaBodyComponent implements OnInit {

    constructor() { }
    @Input() username$: any;
    ngOnInit() {    }

}

