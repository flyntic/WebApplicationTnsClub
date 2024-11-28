import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduleListComponent } from './shedule-list.component';

describe('SheduleListComponent', () => {
  let component: SheduleListComponent;
  let fixture: ComponentFixture<SheduleListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SheduleListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SheduleListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
