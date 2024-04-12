import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductSupplierComponent } from './ProductSupplier/ProductSupplier.component';
import { QuotationSupplierComponent } from './QuotationSupplier/QuotationSupplier.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [		
    AppComponent,
      ProductSupplierComponent,
      QuotationSupplierComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
