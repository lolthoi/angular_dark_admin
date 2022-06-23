import { Store } from './store.model';
import { Product } from './product.model';
export class Stock {
  storeId!: number;
  productId!: number;
  quantity!: number | null;
  product!: Product;
  store!: Store;

  constructor(init?: Partial<Stock>) {
    Object.assign(this, init);
  }
}
