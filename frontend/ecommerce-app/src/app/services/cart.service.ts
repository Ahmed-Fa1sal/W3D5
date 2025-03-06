import { Injectable } from '@angular/core';
import { Product } from './product.service';  // Import the Product model

@Injectable({
  providedIn: 'root'
})
export class CartService {
  private cartItems: Product[] = [];

  // Add product to cart
  addToCart(product: Product): void {
    this.cartItems.push(product);
    console.log(`Added to cart: ${product.name}`);
  }

  // Get all items in the cart
  getCartItems(): Product[] {
    return this.cartItems;
  }

  // Get the number of items in the cart
  getCartCount(): number {
    return this.cartItems.length;
  }
}
