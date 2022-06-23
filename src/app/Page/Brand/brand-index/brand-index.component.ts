import { BrandService } from './../../../Shared/Services/brand.service';
import { Brand } from './../../../Shared/Models/brand.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-brand-index',
  templateUrl: './brand-index.component.html',
  styleUrls: ['./brand-index.component.scss'],
})
export class BrandIndexComponent implements OnInit {
  brand!: Brand[];
  constructor(private brandService: BrandService) {}

  ngOnInit(): void {
    this.InitData();
  }

  InitData() {
    this.brandService.getAllBrand().subscribe((res: any) => {
      this.brand = res;
    });
  }

  onDelete(id: number) {
    var answer = window.confirm('Delete data?');
    if (answer) {
      this.brandService.deleteBrand(id).subscribe((res: any) => {
        this.brand = this.brand.filter((brand) => brand.brandId !== id);
      });
    } else {
    }
  }
}
