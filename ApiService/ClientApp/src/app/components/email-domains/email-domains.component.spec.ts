import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmailDomainsComponent } from './email-domains.component';

describe('EmailDomainsComponent', () => {
  let component: EmailDomainsComponent;
  let fixture: ComponentFixture<EmailDomainsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmailDomainsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmailDomainsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
