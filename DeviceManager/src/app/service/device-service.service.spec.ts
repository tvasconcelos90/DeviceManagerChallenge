import { HttpClientModule } from '@angular/common/http';
import { TestBed } from '@angular/core/testing';
import { Device } from '../models/Device';

import { DeviceService } from './device-service.service';

const expectedDevices = [
  {
    id: 1,     
    name: "Personal Phone",
    status: "Available",
    type: "smartphone",
    info: "Personal smartphone",
    temperature: 28
  },
  {
    id: 2,     
    name: "Work Tablet",
    status: "Offline",
    type: "tablet",
    info: "Samsung Tablet",
    temperature: 33
  },
  {
    id: 3,      
    name: "Work Computer",
    status: "Available",
    type: "computer", 
    info:  "Company's Computer",
    temperature: 48
  }
  
] as Device[];

describe('DeviceService', () => {
  let service: DeviceService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule],
      providers: [DeviceService]
    });
    service = TestBed.inject(DeviceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should return all devices to list on home page', () => {
    expect(service.getAll().then((result) => {
      expect(result).toEqual(expectedDevices)
    }));
  });
});
