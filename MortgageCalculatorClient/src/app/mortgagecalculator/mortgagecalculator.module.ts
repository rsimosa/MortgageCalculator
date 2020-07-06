import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { MortgagecalculatorPageRoutingModule } from './mortgagecalculator-routing.module';

import { MortgagecalculatorPage } from './mortgagecalculator.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    MortgagecalculatorPageRoutingModule
  ],
  declarations: [MortgagecalculatorPage]
})
export class MortgagecalculatorPageModule {}
