import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {Router,Routes, RouterModule} from '@angular/router'
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http'
@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
