import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MortgageService {

  constructor(private httpClient: HttpClient) { }

  public async calculate(L: number, R: number, N: number): Promise<number> {
    return this.httpClient.get<number>(
      'https://localhost:44303/House/CalculateMortgage?L=' + L + "&R=" + R + "&N=" + N).toPromise();
  }

}
