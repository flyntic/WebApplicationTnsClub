import {  Component, OnInit } from '@angular/core';
import { Input } from '@angular/core';

@Component({
    selector: 'spa-header',
    templateUrl: './spa-header.component.html',
    styleUrls: ['./spa-header.component.css'],
 
})

export class SpaHeaderComponent implements OnInit {
   
    @Input() username$ : any;
    constructor( ) { }

    ngOnInit() {        console.log("headeer:" + this.username$);    }


  
}
