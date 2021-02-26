import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {Router,Routes, RouterModule} from '@angular/router'
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http'
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    HttpClientModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
