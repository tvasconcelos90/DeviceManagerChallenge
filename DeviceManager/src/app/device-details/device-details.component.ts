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
  public devices: Device[] = [
    {id: 1, name: "Device 1", status: "Available", type: "smartphone", info: "Personal smartphone", temperature: 55, relatedDevices: []},
    {id: 2, name: "Device 2", status: "Offline", type: "tablet", info: "Samsung Tablet", temperature: 55, relatedDevices: []},
    {id: 3, name: "Device 3", status: "Available", type: "computer", info: "Company's Computer", temperature: 55, relatedDevices: []}
  ];
  constructor(private route:ActivatedRoute,
              private deviceService: DeviceService ) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      if(params['id'])
        this.id = params['id'];     
      
    });

    this.loadDevice(this.id);
  }

  loadDevice(id: number): void {
    this.deviceService.getById(this.id).subscribe(device => this.device = device);
  }

}
