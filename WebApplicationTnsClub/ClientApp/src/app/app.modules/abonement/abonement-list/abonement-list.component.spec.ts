import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AbonementListComponent } from './abonement-list.component';

describe('AbonementListComponent', () => {
  let component: AbonementListComponent;
  let fixture: ComponentFixture<AbonementListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AbonementListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AbonementListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
