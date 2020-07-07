import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MortgageService {

  constructor(private httpClient: HttpClient) { }

  public async calculate(L: number, R: number, N: number): Promise<number> {
    return this.httpClient.get<number>(
      //'http://nedlrafael.azurewebsites.net/api/function1/house/calculatemortgage?L=' + L + "&R=" + R + "&N=" + N)
      //.toPromise();

      'https://studenttestapps-rafael2.azurewebsites.net/house/calculatemortgage?L=' + L + "&R=" + R + "&N=" + N)
      .toPromise();
  }

  

}

