import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AbonementEditComponent } from './abonement-edit.component';

describe('AbonementEditComponent', () => {
  let component: AbonementEditComponent;
  let fixture: ComponentFixture<AbonementEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AbonementEditComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AbonementEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
