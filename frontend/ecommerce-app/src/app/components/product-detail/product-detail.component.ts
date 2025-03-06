import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductService, Product } from '../../services/product.service';
import { Location } from '@angular/common';  // Import Location to handle "Go Back" functionality

@Component({
  selector: 'app-product-detail',
  standalone: true,
  imports: [], // Add necessary imports here
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {
  product: Product | undefined;

  constructor(
    private route: ActivatedRoute,
    private productService: ProductService,
    private location: Location  // Inject Location service
  ) { }

  ngOnInit(): void {
    this.fetchProductDetails();
  }

  fetchProductDetails(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));  // Get the product ID from the route
    this.productService.getProductById(id).subscribe(
      (data: Product) => {
        this.product = data;
      },
      (error) => {
        console.error('Error fetching product details:', error);
      }
    );
  }

  // Go back to the previous page
  goBack(): void {
    this.location.back();
  }
}
