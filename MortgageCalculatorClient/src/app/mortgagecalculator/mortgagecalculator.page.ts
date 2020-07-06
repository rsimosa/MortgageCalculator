import { Component, OnInit } from '@angular/core';
import { MortgageService } from '../services/mortgage.service';

@Component({
  selector: 'app-mortgagecalculator',
  templateUrl: './mortgagecalculator.page.html',
  styleUrls: ['./mortgagecalculator.page.scss'],
})
export class MortgagecalculatorPage implements OnInit {

  L = 100000;
  R = 0.05;
  N = 40;
  finalResult = 0;

  constructor(private calculator: MortgageService) { }

  async Calculate() {
    this.finalResult = await this.calculator.calculate(this.L,this.R,this.N);
  }

  ngOnInit() {
  }

}
