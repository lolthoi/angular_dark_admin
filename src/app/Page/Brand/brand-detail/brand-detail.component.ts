import { Brand } from './../../../Shared/Models/brand.model';
import { BrandService } from './../../../Shared/Services/brand.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-brand-detail',
  templateUrl: './brand-detail.component.html',
  styleUrls: ['./brand-detail.component.scss'],
})
export class BrandDetailComponent implements OnInit {
  constructor(
    private brandService: BrandService,
    private route: ActivatedRoute,
    private redirectRoute: Router
  ) {}

  brand = new Brand();
  name: string = '';
  currentId: number = 0;
  pName(event) {
    this.name = event.target.value;
  }

  ngOnInit(): void {
    this.InitData();
  }

  InitData() {
    debugger;
    var id = this.route.snapshot.params['id'];
    if (id > 0) {
      this.currentId = id;
      this.brandService.findBrandById(id).subscribe((res: any) => {
        this.brand = res;
        return;
      });
    }
    this.brand.brandId = 0;
    this.brand.brandName = '';
  }

  onSubmit() {
    debugger;
    this.brand = {
      brandId: this.currentId,
      brandName: this.name,
    };
    if (this.currentId == 0) {
      this.brandService.createBrand(this.brand).subscribe((res: any) => {
        alert('Create new Brand successfully');
      });
    } else {
      this.brandService.editBrand(this.brand).subscribe((res: any) => {
        alert('Edit Brand successfully');
      });
    }

    this.redirectRoute.navigate(['brand']);
  }
}
