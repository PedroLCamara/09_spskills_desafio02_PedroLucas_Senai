import { Component, OnInit, NgModule } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})


export class AppComponent implements OnInit {
  title = 'vitahealth';
  emailValue = '';
  senhaValue = '';
  falhouLogin = false;
  constructor(private http: HttpClient) { }

  Logar = (form): void => {
    form.preventDefault();
    this.http.post<any>('http://192.168.15.123:5000/api/Login', { email: this.emailValue, senha: this.senhaValue }).subscribe({
      next: data => {
          alert('Sucesso!' + data.token);
          this.falhouLogin = false;
      },
      error: error => {
          alert('Houve um erro!' + error.message);
          this.falhouLogin = true;
      }
  })
  }

  AlterarSenha = (valor): void => {
    this.senhaValue = valor;
  }

  AlterarEmail = (valor): void => {
    this.emailValue = valor;
  }

  ngOnInit(): void {
  }

}