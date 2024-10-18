import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { PropertyListRoutingModule } from './property-list-routing.module';
import { PropertyListComponent } from './property-list.component';


@NgModule({
  declarations: [
    PropertyListComponent
  ],
  imports: [
    CommonModule,
    PropertyListRoutingModule,
    FormsModule
  ]
})
export class PropertyListModule { }
