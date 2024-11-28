import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduleCreateComponent } from './shedule-create.component';

describe('SheduleCreateComponent', () => {
  let component: SheduleCreateComponent;
  let fixture: ComponentFixture<SheduleCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SheduleCreateComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SheduleCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
