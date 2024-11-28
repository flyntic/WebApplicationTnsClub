import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduleClubEditComponent } from './shedule-club-edit.component';

describe('SheduleClubEditComponent', () => {
  let component: SheduleClubEditComponent;
  let fixture: ComponentFixture<SheduleClubEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SheduleClubEditComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SheduleClubEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
