import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduleEditComponent } from './shedule-edit.component';

describe('SheduleEditComponent', () => {
  let component: SheduleEditComponent;
  let fixture: ComponentFixture<SheduleEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SheduleEditComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SheduleEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
