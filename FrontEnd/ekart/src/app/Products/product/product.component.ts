import { Component } from '@angular/core';
import { ProductService } from 'src/app/Services/product.service';
import { Product } from 'src/app/interfaces/product';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  addProduct:FormGroup;
  products: Product[] = [];
  currentProductId: number = 0;
  selectedProduct: Product = {
    productId: 0,
    name: '',
    description: '',
    price: 0,
    quantityAvailable: 0,
    categoryId: 0,
    category: { categoryId: 0, name: '', createdDate: new Date() }, // Include category object
    discount: 0,
    isInStock: false,
    createdDate: new Date(),
    imageUrl: '',
    priceAfterDiscount: 0
  };
  constructor(private _apiService: ProductService,private fb:FormBuilder) {
    this.getProducts();
    this.addProduct = this.fb.group({
      name: ['', Validators.required],
      description: [''],
      price: ['', Validators.required],
      quantityAvailable: [''],
      categoryId: ['', Validators.required],
      discount: [''],
      isInStock: ['', Validators.required],
      imageUrl: ['']
    });
  }
  getCurrentProductId(productId: number) {
    this.currentProductId = productId;
  }
  public getProducts() {
    this._apiService.getProducts().subscribe((response: any) => {
      if (response.status && response.result) {
        this.products = response.result as Product[];
        console.log(this.products)
      } else {
        console.error('Failed to fetch products.');
      }
    });
  }
  public currentProduct(){
this.getproductById(this.currentProductId);
  }
  //Get Product By Id
  public getproductById(productId: number) {
    this._apiService.getProductsById(productId).subscribe((response: any) => {
      if (response.status && response.result) {
        this.selectedProduct = response.result as Product;
        console.log(this.selectedProduct)
      } else {
        console.error('Failed to fetch products.');
      }
    });
  }


  //Submit form
  public onSubmit(){
    debugger;
    if (this.addProduct.valid) {
      // Form is valid, handle submission
      console.log(this.addProduct.value);
      // Reset the form after submission
      this.addProduct.reset();
    } else {
      // Form is invalid, display error messages or handle accordingly
      console.error("Form is invalid!");
    }
  
  }
}
