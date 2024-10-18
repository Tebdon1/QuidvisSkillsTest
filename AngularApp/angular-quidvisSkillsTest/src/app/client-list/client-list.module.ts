import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClientListRoutingModule } from './client-list-routing.module';
import { ClientListComponent } from './client-list.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    ClientListComponent
  ],
  imports: [
    CommonModule,
    ClientListRoutingModule,
    FormsModule
  ]
})
export class ClientListModule { }
