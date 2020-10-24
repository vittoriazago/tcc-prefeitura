import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/core/services/auth.service';

@Component({
  selector: 'app-autenticacao',
  templateUrl: './autenticacao.component.html',
  styleUrls: ['./autenticacao.component.css']
})
export class AutenticacaoComponent {

  constructor(
    private auth: AuthService,
    private router: Router,
    ) {
  }

  login() {
    this.auth.login();
    this.router.navigateByUrl('', {skipLocationChange: true}).then(
      () => this.router.navigate(['/'])
    );
  }

}
