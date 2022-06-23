import { OrderItem } from './orderitem.model';
import { Customer } from './customer.model';
import { Store } from './store.model';
import { Staff } from './staff.model';
export class Order {
  orderId!: number;
  customerId!: number | null;
  orderStatus!: number;
  orderDate!: string;
  requiredDate!: string;
  shippedDate!: string | null;
  storeId!: number;
  staffId!: number;
  customer!: Customer | null;
  staff!: Staff;
  store!: Store;
  orderItems!: OrderItem[];
}
