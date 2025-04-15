import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerMedicosComponent } from './ver-medicos.component';

describe('VerMedicosComponent', () => {
  let component: VerMedicosComponent;
  let fixture: ComponentFixture<VerMedicosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [VerMedicosComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VerMedicosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
