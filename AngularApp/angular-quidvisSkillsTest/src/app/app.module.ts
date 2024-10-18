import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClientListModule } from './client-list/client-list.module';
import { PropertyListModule } from './property-list/property-list.module';
import { AuditListModule } from './audit-list/audit-list.module';
import { provideHttpClient } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ClientListModule,
    PropertyListModule,
    AuditListModule,
  ],
  providers: [provideHttpClient()],
  bootstrap: [AppComponent]
})
export class AppModule { }
