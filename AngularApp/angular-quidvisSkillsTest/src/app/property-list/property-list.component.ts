import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrl: './property-list.component.scss'
})
export class PropertyListComponent {
  properties: any []= [];
  filteredProperties: any []= [];
  clients: any []= [];
  clientId = "";

  constructor(
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute,
  ){

  }

  ngOnInit() {
    this.route.params
      .subscribe(params => {
        this.clientId = params['clientId']  ?? "";
        this.http.get<any>("https://localhost:7047/Test/GetProperties").subscribe(
          result => {
            this.properties = result;
            this.applyFilter();
          }
        );
      });

    this.http.get<any>("https://localhost:7047/Test/GetClients").subscribe(
      result => this.clients = result
    );
    
  }

  applyFilter() {
    this.filteredProperties = this.clientId == "" ? this.properties : this.properties.filter(property => property.clientId == this.clientId)
  }
}
