import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduleClubCreateComponent } from './shedule-club-create.component';

describe('SheduleClubCreateComponent', () => {
  let component: SheduleClubCreateComponent;
  let fixture: ComponentFixture<SheduleClubCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SheduleClubCreateComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SheduleClubCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
