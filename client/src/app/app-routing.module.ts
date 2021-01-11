import { NotFoundComponent } from './core/not-found/not-found.component';
import { ServerErrorComponent } from './core/server-error/server-error.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TestErrorComponent } from './core/test-error/test-error.component';


const routes: Routes = [
  { path: '', component: HomeComponent, data: {breadcrumb: 'Home'}},
  { path: 'test-error', component: TestErrorComponent, data: {breadcrumb: 'Test Errors'}},
  { path: 'server-error', component: ServerErrorComponent, data: {breadcrumb: 'Server Errors'}},
  { path: 'not-found', component: NotFoundComponent},
  // tslint:disable-next-line: max-line-length
  { path: 'shop', loadChildren: () => import('./shop/shop.module').then((mod) => mod.ShopModule), data: {breadcrumb: 'Shop'}}, // Lazy loading
  { path: '**', redirectTo: 'not-found', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
