import { Order } from './order.model';
export class Customer {
  CustomerId!: number;
  FirstName!: string;
  LastName!: string;
  Phone!: string;
  Email!: string;
  Street!: string;
  City!: string;
  State!: string;
  ZipCode!: string;
  Orders!: Order[];

  constructor(init?: Partial<Customer>) {
    Object.assign(this, init);
  }
}
