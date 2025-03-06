import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';  // <-- Keep this import
import { RouterModule } from '@angular/router';  // <-- Keep this import for routerLink
import { ProductService, Product } from '../../services/product.service';
import { CartService } from '../../services/cart.service';  // <-- Import CartService

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule, RouterModule],  // <-- Make sure RouterModule is included for routerLink
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  products: Product[] = [];

  constructor(
    private productService: ProductService,
    private cartService: CartService  // <-- Inject CartService
  ) {}

  ngOnInit(): void {
    this.productService.getProducts().subscribe(
      (data: Product[]) => {
        this.products = data;
      },
      (error) => {
        console.error('Error fetching products:', error);
      }
    );
  }

  // Add to Cart functionality
  addToCart(product: Product): void {
    this.cartService.addToCart(product);  // <-- Add the product to the cart using CartService
  }
}
