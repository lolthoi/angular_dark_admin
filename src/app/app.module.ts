import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './Shared/Components/footer/footer.component';
import { SidebarComponent } from './Shared/Components/sidebar/sidebar.component';
import { NavbarComponent } from './Shared/Components/navbar/navbar.component';
import { BrandDetailComponent } from './Page/Brand/brand-detail/brand-detail.component';
import { BrandIndexComponent } from './Page/Brand/brand-index/brand-index.component';
import { CategoryIndexComponent } from './Page/Category/category-index/category-index.component';
import { CategoryDetailComponent } from './Page/Category/category-detail/category-detail.component';
import { ProductDetailComponent } from './Page/Product/product-detail/product-detail.component';
import { ProductIndexComponent } from './Page/Product/product-index/product-index.component';
import { StoreIndexComponent } from './Page/Store/store-index/store-index.component';
import { StoreDetailComponent } from './Page/Store/store-detail/store-detail.component';
import { StaffDetailComponent } from './Page/Staff/staff-detail/staff-detail.component';
import { StaffIndexComponent } from './Page/Staff/staff-index/staff-index.component';
import { CustomerIndexComponent } from './Page/Customer/customer-index/customer-index.component';
import { CustomerDetailComponent } from './Page/Customer/customer-detail/customer-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    SidebarComponent,
    NavbarComponent,
    BrandDetailComponent,
    BrandIndexComponent,
    CategoryIndexComponent,
    CategoryDetailComponent,
    ProductDetailComponent,
    ProductIndexComponent,
    StoreIndexComponent,
    StoreDetailComponent,
    StaffDetailComponent,
    StaffIndexComponent,
    CustomerIndexComponent,
    CustomerDetailComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
