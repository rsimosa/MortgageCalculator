import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { MortgagecalculatorPage } from './mortgagecalculator.page';

describe('MortgagecalculatorPage', () => {
  let component: MortgagecalculatorPage;
  let fixture: ComponentFixture<MortgagecalculatorPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MortgagecalculatorPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(MortgagecalculatorPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
