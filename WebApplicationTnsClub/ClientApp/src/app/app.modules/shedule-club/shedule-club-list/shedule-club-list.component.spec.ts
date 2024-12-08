import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduleClubListComponent } from './shedule-club-list.component';

describe('SheduleClubListComponent', () => {
  let component: SheduleClubListComponent;
  let fixture: ComponentFixture<SheduleClubListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SheduleClubListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SheduleClubListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
