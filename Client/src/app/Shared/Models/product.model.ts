import { OrderItem } from './orderitem.model';
import { Category } from './category.model';
import { Stock } from './stock.model';
import { Brand } from './brand.model';
export class Product {
  productId!: number;
  productName!: string;
  brandId!: number;
  categoryId!: number;
  modelYear!: number;
  listPrice!: number;
  brand!: Brand;
  category!: Category;
  orderItems!: OrderItem[];
  stocks!: Stock[];

  constructor(init?: Partial<Product>) {
    Object.assign(this, init);
  }
}
