import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-audit-list',
  templateUrl: './audit-list.component.html',
  styleUrl: './audit-list.component.scss'
})
export class AuditListComponent {
  audits: any [] = [];
  properties: any[] = [];
  filteredAudits: any []= [];
  propertyId = "";


  constructor(
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute,
  ){

  }

  ngOnInit() {
    this.route.params
      .subscribe(params => {
        this.propertyId = params['propertyId']  ?? "";
        this.http.get<any>("https://localhost:7047/Test/GetAudits").subscribe(
          result => {
            this.audits = result;
            this.applyFilter();
          }
        );
      });

    this.http.get<any>("https://localhost:7047/Test/GetProperties").subscribe(
      result => this.properties = result
    );
    
  }

  // For speed I'm just doing the filtering locally, in a production env it would be better to do this server side via API calls
  applyFilter() {
    this.filteredAudits = this.propertyId == "" ? this.audits : this.audits.filter(audit => audit.propertyId == this.propertyId)
  }
}
