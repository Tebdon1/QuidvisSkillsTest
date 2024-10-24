import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-client-list',
  templateUrl: './client-list.component.html',
  styleUrl: './client-list.component.scss'
})
export class ClientListComponent implements OnInit {

  clients: any []= [];

  constructor(
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute,
  ){

  }

  ngOnInit() {
    this.http.get<any>("https://localhost:7047/Test/GetClients").subscribe(
      result => this.clients = result
    );
  }
  showProperties(clientId: string){
    this.router.navigate(['../property-list', { clientId: clientId}], { relativeTo: this.route });
  }
}
