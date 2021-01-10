import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { ShopRoutingModule } from '../shop/shop-routing.module';



@NgModule({
  declarations: [NavBarComponent],
  imports: [CommonModule, RouterModule],
  exports: [NavBarComponent],
})
export class CoreModule {}
