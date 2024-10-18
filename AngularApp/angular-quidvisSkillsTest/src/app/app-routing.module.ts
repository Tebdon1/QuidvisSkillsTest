import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'client-list',
    loadChildren: () => import('./client-list/client-list.module').then(m => m.ClientListModule),
  },
  {
    path: 'property-list',
    loadChildren: () => import('./property-list/property-list.module').then(m => m.PropertyListModule),
  },
  {
    path: 'audit-list',
    loadChildren: () => import('./audit-list/audit-list.module').then(m => m.AuditListModule),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
