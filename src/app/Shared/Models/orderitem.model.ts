import { Product } from './product.model';
import { Order } from './order.model';
export class OrderItem {
  orderId!: number;
  itemId!: number;
  productId!: number;
  quantity!: number;
  listPrice!: number;
  discount!: number;
  order!: Order;
  product!: Product;

  constructor(init?: Partial<OrderItem>) {
    Object.assign(this, init);
  }
}
