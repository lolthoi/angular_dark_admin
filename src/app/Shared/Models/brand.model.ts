import { Product } from './product.model';
export class Brand {
  brandId!: number;
  brandName!: string;
  products?: Product[];

  constructor(init?: Partial<Brand>) {
    Object.assign(this, init);
  }
}
