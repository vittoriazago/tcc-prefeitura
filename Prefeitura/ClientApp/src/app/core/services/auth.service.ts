import { Injectable } from '@angular/core';

export const LOGADO = 'logado';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(
  ) {
   }

  logout() {
    localStorage.removeItem(LOGADO);
  }

  login() {
    localStorage.setItem(LOGADO, 'true');
  }

  isLoggedIn(): boolean {
    return !!localStorage.getItem(LOGADO);
  }

}
