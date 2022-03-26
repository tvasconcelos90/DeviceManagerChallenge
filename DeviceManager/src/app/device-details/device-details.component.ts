import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Device } from '../models/Device';
import { DeviceService } from '../service/device-service.service';

@Component({
  selector: 'app-device-details',
  templateUrl: './device-details.component.html',
  styleUrls: ['./device-details.component.css']
})
export class DeviceDetailsComponent implements OnInit {

  id: number = 0;
  public device: Device;
  public relatedDevices: Device[] = [];
  
  constructor(private route:ActivatedRoute,
              private deviceService: DeviceService ) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      if(params['id'])
        this.id = params['id'];     
      
    });
    this.loadDevice(this.id);
    this.loadRelatedDevices(this.id);
  }

  loadDevice(id: number): void {
    this.deviceService.getById(this.id).subscribe(device => this.device = device);
  }

  loadRelatedDevices(id: number): void {
    this.deviceService.getRelatedDevices(this.id).subscribe(devices => this.relatedDevices = devices);
  }

}
