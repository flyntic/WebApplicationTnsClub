import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SpaHeaderComponent } from './spa-header.component';

describe('SpaHeaderComponent', () => {
  let component: SpaHeaderComponent;
  let fixture: ComponentFixture<SpaHeaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SpaHeaderComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SpaHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
