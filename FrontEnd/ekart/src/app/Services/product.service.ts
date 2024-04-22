import { Injectable } from '@angular/core';
import { ApiBaseService } from './api-base.service';
import { Product } from '../interfaces/product';
import { Observable } from 'rxjs';
import { ApiEndpointService } from './api-endpoint.service';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
  constructor(private _apiService: ApiBaseService<Product>, private apiEndpoints: ApiEndpointService) { }
  //Get Product Method Call
  public getProducts(): Observable<Product> {
    return this._apiService.get(`${this.apiEndpoints.productUrl}/api/Product/GetAll/Product`);
  }
  public getProductsById(productId:number): Observable<Product> {
    return this._apiService.get(`${this.apiEndpoints.productUrl}/api/Product/GetById/${productId}`);
  }
}
