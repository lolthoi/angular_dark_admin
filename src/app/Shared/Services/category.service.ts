import { Observable } from 'rxjs/internal/Observable';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from '../Models/category.model';

const urlApi = 'https://localhost:7250/api/';
const currentData = 'category';

@Injectable({
  providedIn: 'root',
})
export class CategoryService {
  constructor(private http: HttpClient) {}

  /** GET ALL: select all category */
  getAllCategory(): Observable<Category[]> {
    return this.http.get<Category[]>(`${urlApi}` + `${currentData}`).pipe();
  }
  /** GET ONE: find exactly category by id */
  findCategoryById(id: number): Observable<Category> {
    return this.http
      .get<Category>(`${urlApi}` + `${currentData}` + `/${id}`)
      .pipe();
  }
  /** CREATE: add a new category */
  createCategory(newCategory: Category): Observable<Category> {
    return this.http
      .post<Category>(`${urlApi}` + `${currentData}`, newCategory)
      .pipe();
  }
  /** UPDATE: edit category by id */
  editCategory(category: Category): Observable<Category> {
    return this.http
      .put<Category>(`${urlApi}` + `${currentData}`, category)
      .pipe();
  }
  /** DELETE: delete category from the server by id */
  deleteCategory(id: number): Observable<Category> {
    return this.http
      .delete<Category>(`${urlApi}` + `${currentData}` + `/${id}`)
      .pipe();
  }
}
