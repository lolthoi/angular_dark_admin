import { Order } from './order.model';
import { Stock } from './stock.model';
export class Store {
  storeId!: number;
  storeName!: string;
  phone!: string | null;
  email!: string | null;
  street!: string | null;
  city!: string | null;
  state!: string | null;
  zipCode!: string | null;
  orders!: Order[];
  stocks!: Stock[];

  constructor(init?: Partial<Store>) {
    Object.assign(this, init);
  }
}
