import { Component, ViewChild, ElementRef } from '@angular/core';
import { ProductService } from 'src/app/Services/product.service';
import { Product } from 'src/app/interfaces/product';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  @ViewChild('deleteModal') deleteModal!: ElementRef;
  @ViewChild('addModal') addModal!: ElementRef;
  categories: any[] = [];
  addProduct: FormGroup;
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
  constructor(private _apiService: ProductService, private fb: FormBuilder) {
    this.getProducts();
    this.addProduct = this.fb.group({
      name: ['', Validators.required],
      description: [''],
      price: ['', Validators.required],
      quantityAvailable: [''],
      categoryId: ['', Validators.required],
      discount: ['', Validators.min(1)],
      isInStock: [true],
      imageUrl: ['']

    });
    this.loadCategories();
  }
  getCurrentProductId(productId: number) {
    this.currentProductId = productId;
  }
  loadCategories() {
    // Fetch categories from the service
    this._apiService.getCategories().subscribe((data: any) => {
      this.categories = data.result; // Assign fetched categories to the variable
      console.log(this.categories);
    });
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
  public currentProduct() {
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


  //Submit form AddProduct make Api Call
  public onSubmit() {
    debugger;
    // Mark all form controls as touched to trigger validation messages
    this.markFormGroupTouched(this.addProduct);

    if (this.addProduct.valid) {
      this.addNewProduct(this.addProduct.value);
    } else {
      console.error("Form is invalid!");
    }
  }
  private markFormGroupTouched(formGroup: FormGroup) {
    Object.values(formGroup.controls).forEach(control => {
      control.markAsTouched();

      if (control instanceof FormGroup) {
        this.markFormGroupTouched(control);
      }
    });
  }

  public addNewProduct(productobj: Product) {
    this._apiService.addProduct(productobj).subscribe((response: any) => {
      if (response.status && response.result) {
        this.addProduct.reset();
        this.closeAddModal();
        this.getProducts();
      } else {
        console.error('Failed to fetch products.');
      }
    });

  }

  public deleteProduct() {
    this._apiService.deleteProduct(this.currentProductId).subscribe((response: any) => {
      if (response.status && response.result) {
        this.closeModal();
        this.getProducts();
      } else {
        console.error('Failed to delete products.');
      }
    });
  }

  closeModal() {
    const modal: HTMLElement = this.deleteModal.nativeElement;
    modal.classList.remove('show');
    modal.style.display = 'none';
    const modalBackdrop: HTMLElement | null = document.querySelector('.modal-backdrop');
    if (modalBackdrop) {
      modalBackdrop.remove();
    }
  }
  closeAddModal() {
    const modal: HTMLElement = this.addModal.nativeElement;
    modal.classList.remove('show');
    modal.style.display = 'none';
    const modalBackdrop: HTMLElement | null = document.querySelector('.modal-backdrop');
    if (modalBackdrop) {
      modalBackdrop.remove();
    }
  }

}
