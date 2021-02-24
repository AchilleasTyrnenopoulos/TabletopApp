import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'The Tabletop App';
  users: any;

  constructor(private http: HttpClient) {}
  
  ngOnInit() {
    this.getUsers();
  }

  //get the users we have on our database from our api and assign them to the property users of the AppComponent
  getUsers()
  {
    this.http.get('https://localhost:5001/api/users').subscribe(response => {
      this.users = response;
    }, error => {
      console.log(error);
    })
  }
}
