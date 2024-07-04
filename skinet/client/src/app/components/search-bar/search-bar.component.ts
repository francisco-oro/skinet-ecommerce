import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormControl, FormGroup} from "@angular/forms";
import {ProductTypesService} from "../../services/product-types.service";
import {ProductsService} from "../../services/products.service";
import {ProductType} from "../../models/product-type.interface";
import {ProductResponseData} from "../../models/ProductResponse";
import {AutoCompleteCompleteEvent} from "primeng/autocomplete";

@Component({
  selector: 'app-search-bar',
  templateUrl: './search-bar.component.html',
  styleUrl: './search-bar.component.css'
})
export class SearchBarComponent implements OnInit {
  productTypes: ProductType[] | undefined;
  products: ProductResponseData[] | undefined;
  filteredProducts: any[] = [];

  public searchBarForm: FormGroup = this._formBuilder.group({
    selectedProductType: new FormControl<object | null>(null),
    selectedProduct: new FormControl<object | null>(null),
  });

  constructor(private _formBuilder: FormBuilder,
              private productTypesService: ProductTypesService,
              private productsService: ProductsService) {}

  ngOnInit(): void {
    this.productTypesService.getProductTypes().subscribe(productTypes => {
      this.productTypes = productTypes;
    });
  }

  filterProduct(event: AutoCompleteCompleteEvent) {
    let query = event.query;
    let productTypeId:string = this.searchBarForm.controls['selectedProductType'].value.id;

    let filtered = this.productsService.getProducts().subscribe(products => {

    });

    this.filteredProducts = filtered;
  }
}
