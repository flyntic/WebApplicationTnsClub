import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AbonementCreateComponent } from './abonement-create.component';

describe('AbonementCreateComponent', () => {
  let component: AbonementCreateComponent;
  let fixture: ComponentFixture<AbonementCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AbonementCreateComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AbonementCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
