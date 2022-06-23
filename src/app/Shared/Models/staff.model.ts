import { Product } from './product.model';
export class Staff {
  StaffId!: number;
  FirstName!: string;
  LastName!: string;
  Email!: string;
  Phone!: string;
  Active!: boolean;
  StoreId!: number;
  ManagerId!: number;
  products!: Product[];

  constructor(init?: Partial<Staff>) {
    Object.assign(this, init);
  }
}
