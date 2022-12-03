import { Component, OnInit } from '@angular/core';
import { OmgstoreService } from 'src/app/shared/omgstore.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

import { Invoice } from 'src/app/shared/invoice.model';
import { Product } from 'src/app/shared/product.model';
import { Client} from 'src/app/shared/client.model';
import { HttpClientModule } from '@angular/common/http';

import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';


@Component({
  selector: 'app-store-form',
  templateUrl: './store-form.component.html',
  styles: [ ]
})
export class StoreFormComponent implements OnInit {

  constructor(public service: OmgstoreService) { }

  ngOnInit(): void {
  }

}
