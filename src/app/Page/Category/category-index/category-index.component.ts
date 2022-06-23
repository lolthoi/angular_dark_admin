import { CategoryService } from './../../../Shared/Services/category.service';
import { Category } from './../../../Shared/Models/category.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-category-index',
  templateUrl: './category-index.component.html',
  styleUrls: ['./category-index.component.scss'],
})
export class CategoryIndexComponent implements OnInit {
  category!: Category[];
  constructor(private categoryService: CategoryService) {}

  ngOnInit(): void {
    this.InitData();
  }

  InitData() {
    this.categoryService.getAllCategory().subscribe((res: any) => {
      this.category = res;
    });
  }

  onDelete(id: number) {
    var answer = window.confirm('Delete data?');
    if (answer) {
      this.categoryService.deleteCategory(id).subscribe((res: any) => {
        this.category = this.category.filter(
          (category) => category.categoryId !== id
        );
      });
    } else {
    }
  }
}
