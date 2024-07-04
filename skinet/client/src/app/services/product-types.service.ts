import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {Category} from "../models/category.interface";
import {ProductType} from "../models/product-type.interface";

const baseUrl = "http://localhost:5238/api/Products/types";

@Injectable({
  providedIn: 'root'
})
export class ProductTypesService {

  constructor(private http: HttpClient) { }

  getProductTypes(): Observable<ProductType[]> {
    return this.http.get<ProductType[]>(baseUrl);
  }
}
