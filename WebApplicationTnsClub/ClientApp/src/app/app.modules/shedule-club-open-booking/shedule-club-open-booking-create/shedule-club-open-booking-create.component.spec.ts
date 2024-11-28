import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduleClubOpenBookingCreateComponent } from './shedule-club-open-booking-create.component';

describe('SheduleClubOpenBookingCreateComponent', () => {
  let component: SheduleClubOpenBookingCreateComponent;
  let fixture: ComponentFixture<SheduleClubOpenBookingCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SheduleClubOpenBookingCreateComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SheduleClubOpenBookingCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
