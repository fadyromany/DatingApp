import { HttpClient, HttpClientModule } from '@angular/common/http';
import { OnInit } from '@angular/core';
import { Component } from '@angular/core';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Dating App';
  users: any;
  constructor(private accountService:AccountService) {

  }
  setCurrentUser(){
    const user = JSON.parse(localStorage.getItem("user"));
this.accountService=user;
  }
  ngOnInit() {
    this.setCurrentUser();
    
  }
}
