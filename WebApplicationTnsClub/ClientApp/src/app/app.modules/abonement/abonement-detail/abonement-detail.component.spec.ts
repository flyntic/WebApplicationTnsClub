import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AbonementDetailComponent } from './abonement-detail.component';

describe('AbonementDetailComponent', () => {
  let component: AbonementDetailComponent;
  let fixture: ComponentFixture<AbonementDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AbonementDetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AbonementDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
