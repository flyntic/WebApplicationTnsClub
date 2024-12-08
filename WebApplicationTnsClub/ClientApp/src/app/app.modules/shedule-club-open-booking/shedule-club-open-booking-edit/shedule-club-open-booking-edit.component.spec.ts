import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduleClubOpenBookingEditComponent } from './shedule-club-open-booking-edit.component';

describe('SheduleClubOpenBookingEditComponent', () => {
  let component: SheduleClubOpenBookingEditComponent;
  let fixture: ComponentFixture<SheduleClubOpenBookingEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SheduleClubOpenBookingEditComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SheduleClubOpenBookingEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
