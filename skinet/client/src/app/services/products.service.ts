import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {ProductResponse} from "../models/ProductResponse";

const baseUrl: string = "http://localhost:5238/api/Products";
@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private http: HttpClient) { }

  public getProducts(productTypeId?: string): Observable<ProductResponse> {
    return this.http.get<ProductResponse>(`${baseUrl}?TypeId=${productTypeId}`);
  }
}
