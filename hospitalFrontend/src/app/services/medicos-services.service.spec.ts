import { TestBed } from '@angular/core/testing';

import { MedicosServicesService } from './medicos-services.service';

describe('MedicosServicesService', () => {
  let service: MedicosServicesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MedicosServicesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
