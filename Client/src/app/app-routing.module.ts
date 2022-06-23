import { CategoryDetailComponent } from './Page/Category/category-detail/category-detail.component';
import { CategoryIndexComponent } from './Page/Category/category-index/category-index.component';
import { BrandIndexComponent } from './Page/Brand/brand-index/brand-index.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BrandDetailComponent } from './Page/Brand/brand-detail/brand-detail.component';

const routes: Routes = [
  {
    path: 'brand',
    component: BrandIndexComponent,
  },
  {
    path: 'brand/:id',
    component: BrandDetailComponent,
  },
  {
    path: 'category',
    component: CategoryIndexComponent,
  },
  {
    path: 'category/:id',
    component: CategoryDetailComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
