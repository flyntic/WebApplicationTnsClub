import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SpaContentComponent } from './spa-content.component';

describe('SpaContentComponent', () => {
  let component: SpaContentComponent;
  let fixture: ComponentFixture<SpaContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SpaContentComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SpaContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
