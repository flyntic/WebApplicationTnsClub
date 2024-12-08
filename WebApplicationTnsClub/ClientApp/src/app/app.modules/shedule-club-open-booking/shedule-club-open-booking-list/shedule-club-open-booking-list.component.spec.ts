import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduleClubOpenBookingListComponent } from './shedule-club-open-booking-list.component';

describe('SheduleClubOpenBookingListComponent', () => {
  let component: SheduleClubOpenBookingListComponent;
  let fixture: ComponentFixture<SheduleClubOpenBookingListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SheduleClubOpenBookingListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SheduleClubOpenBookingListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
