import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { CreateOrderComponent } from './features/order/create-order/create-order.component';
import { DisplayOrdersComponent } from './features/order/display-orders/display-orders.component';

@NgModule({
  declarations: [
    AppComponent,
    CreateOrderComponent,
    DisplayOrdersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
