import { HttpClient } from "@angular/common/http";
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductTypesService {

  constructor(private http: HttpClient) { }
  getAll() {
    this.http.get('http://localhost:55661/api/productTypes').subscribe(data => {
      console.log(data);
    });
  }
}
