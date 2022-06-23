import { Brand } from './../Models/brand.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';

const urlApi = 'https://localhost:7250/api/';
const currentData = 'brand';

@Injectable({
  providedIn: 'root',
})
export class BrandService {
  constructor(private http: HttpClient) {}

  /** GET ALL: select all brand */
  getAllBrand(): Observable<Brand[]> {
    return this.http.get<Brand[]>(`${urlApi}` + `${currentData}`).pipe();
  }
  /** GET ONE: find exactly brand by id */
  findBrandById(id: number): Observable<Brand> {
    return this.http
      .get<Brand>(`${urlApi}` + `${currentData}` + `/${id}`)
      .pipe();
  }
  /** CREATE: add a new brand */
  createBrand(newBrand: Brand): Observable<Brand> {
    return this.http
      .post<Brand>(`${urlApi}` + `${currentData}`, newBrand)
      .pipe();
  }
  /** UPDATE: edit brand by id */
  editBrand(brand: Brand): Observable<Brand> {
    return this.http.put<Brand>(`${urlApi}` + `${currentData}`, brand).pipe();
  }
  /** DELETE: delete brand from the server by id */
  deleteBrand(id: number): Observable<Brand> {
    return this.http
      .delete<Brand>(`${urlApi}` + `${currentData}` + `/${id}`)
      .pipe();
  }
}
