import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { OmgstoreComponent } from './omgstore/omgstore.component';
import { StoreFormComponent } from './omgstore/store-form/store-form.component';

@NgModule({
  declarations: [
    AppComponent,
    OmgstoreComponent,
    StoreFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
