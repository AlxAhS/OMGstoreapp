import { Injectable } from '@angular/core';
import { Client } from './client.model';
import { Invoice } from './invoice.model';
import { Product } from './product.model';
import {HttpClient} from "@angular/common/http"

@Injectable({
  providedIn: 'root'
})
export class OmgstoreService {

  constructor() { }

  formClientData: Client = new Client();
  formInvoiceData: Invoice = new Invoice();
  formProductData: Product = new Product();

}
