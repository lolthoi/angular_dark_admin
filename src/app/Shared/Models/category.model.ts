import { Product } from './product.model';
export class Category {
  categoryId!: number;
  categoryName!: string;
  products?: Product[];

  constructor(init?: Partial<Category>) {
    Object.assign(this, init);
  }
}
