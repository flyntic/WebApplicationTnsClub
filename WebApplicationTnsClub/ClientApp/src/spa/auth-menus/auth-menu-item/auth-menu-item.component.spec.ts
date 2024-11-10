import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthMenuItemComponent } from './auth-menu-item.component';

describe('AuthMenuItemComponent', () => {
  let component: AuthMenuItemComponent;
  let fixture: ComponentFixture<AuthMenuItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AuthMenuItemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AuthMenuItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
