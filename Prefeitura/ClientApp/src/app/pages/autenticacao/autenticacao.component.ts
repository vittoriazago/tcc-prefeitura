import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/core/services/auth.service';

@Component({
  selector: 'app-autenticacao',
  templateUrl: './autenticacao.component.html',
  styleUrls: ['./autenticacao.component.css']
})
export class AutenticacaoComponent implements OnInit {
  loginForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private auth: AuthService,
    private router: Router,
    ) {
  }

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      email:  ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  login() {
    this.auth.login(this.loginForm.controls.email.value);
    this.router.navigateByUrl('', {skipLocationChange: true}).then(
      () => this.router.navigate(['/'])
    );
  }

}
