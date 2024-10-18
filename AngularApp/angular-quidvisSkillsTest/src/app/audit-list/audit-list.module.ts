import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuditListRoutingModule } from './audit-list-routing.module';
import { AuditListComponent } from './audit-list.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AuditListComponent
  ],
  imports: [
    CommonModule,
    AuditListRoutingModule,
    FormsModule
  ]
})
export class AuditListModule { }
