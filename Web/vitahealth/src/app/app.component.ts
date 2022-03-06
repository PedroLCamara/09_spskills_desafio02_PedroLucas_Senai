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

  //Funcao de login. 
  Logar = (form): void => {
    form.preventDefault(); //Previne o recarregamento da pagina pelo comportamento padrao da tag form
    this.http.post<any>('http://192.168.15.123:5000/api/Login', { email: this.emailValue, senha: this.senhaValue }). //Manda a requisicao a API
    subscribe({ 
      next: data => { //Caso a requisicao retorne um status code 200, e exibida uma mensagem de sucesso com o token
          alert('Sucesso!' + data.token);
          this.falhouLogin = false;
      },
      error: error => { //Caso a requisicao retorne um status code de erro (400, 401, 403), e exibida uma mensagem de erro com o erro retornado
          alert('Houve um erro!' + error.message);
          this.falhouLogin = true;
      }
  })
  }

  // Funcao que altera a string de senha. Chamada conforme o valor do input de senha e alterado
  AlterarSenha = (valor): void => {
    this.senhaValue = valor;
  }

  // Funcao que altera a string de email. Chamada conforme o valor do input de email e alterado
  AlterarEmail = (valor): void => {
    this.emailValue = valor;
  }

  ngOnInit(): void {
  }

}