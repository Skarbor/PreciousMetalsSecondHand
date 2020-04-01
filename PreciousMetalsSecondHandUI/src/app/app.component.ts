import { OrdersService } from "./services/orders.service";
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})
export class AppComponent implements OnInit {
  title = 'PreciousMetalsSecondHandUI';

  constructor(private ordersService: OrdersService) {
    
  }
  ngOnInit() {
    // this.ordersService.getProductTypes();
  }
}
