import { Component } from '@angular/core';

@Component({
    selector: 'app',
    templateUrl: './app.component.html'
})
export class AppComponent { }

/*import { Component } from '@angular/core';

@Component({
    selector: 'app',
    template: `<label>Введите имя:</label>
                 <input [(ngModel)]="name" placeholder="name">
                 <h2>Добро пожаловать {{name}}!</h2>`
})
export class AppComponent {
    name = '';
}
*/
/*
import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Product } from './product';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    providers: [DataService]
})
export class AppComponent implements OnInit {

    product: Product = new Product();   // изменяемый товар
    products: Product[];                // массив товаров
    tableMode: boolean = true;          // табличный режим

    constructor(private dataService: DataService) { }

    ngOnInit() {
        this.loadProducts();    // загрузка данных при старте компонента  
    }
    // получаем данные через сервис
    loadProducts() {
        this.dataService.getProducts()
            .subscribe((data: Product[]) => this.products = data);
    }
    // сохранение данных
    save() {
        if (this.product.id == null) {
            this.dataService.createProduct(this.product)
                .subscribe((data: Product) => this.products.push(data));
        } else {
            this.dataService.updateProduct(this.product)
                .subscribe(data => this.loadProducts());
        }
        this.cancel();
    }
    editProduct(p: Product) {
        this.product = p;
    }
    cancel() {
        this.product = new Product();
        this.tableMode = true;
    }
    delete(p: Product) {
        this.dataService.deleteProduct(p.id)
            .subscribe(data => this.loadProducts());
    }
    add() {
        this.cancel();
        this.tableMode = false;
    }
}

import { Component } from '@angular/core';

@Component({
    selector: 'app',
    templateUrl: './app.component.html'
})
export class AppComponent { }*/
/*
import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Product } from './product';

import { HttpResponse } from '@angular/common/http';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    providers: [DataService]
})
export class AppComponent implements OnInit {

    product: Product = new Product();   // изменяемый товар
    products: Product[];                // массив товаров
    tableMode: boolean = true;          // табличный режим

    constructor(private dataService: DataService) { }

    ngOnInit() {
        this.loadProducts();
    }

    loadProducts() {
        this.dataService.getProducts()
            .subscribe((data: Product[]) => this.products = data);
    }

    save() {
        if (this.product.id == null) {
            this.dataService.createProduct(this.product)
                .subscribe((data: HttpResponse<Product>) => {
                    console.log(data);
                    this.products.push(data.body);
                });
        } else {
            this.dataService.updateProduct(this.product)
                .subscribe(data => this.loadProducts());
        }
        this.cancel();
    }
    editProduct(p: Product) {
        this.product = p;
    }
    cancel() {
        this.product = new Product();
        this.tableMode = true;
    }
    delete(p: Product) {
        this.dataService.deleteProduct(p.id)
            .subscribe(data => this.loadProducts());
    }
    add() {
        this.cancel();
        this.tableMode = false;
    }
}
*/