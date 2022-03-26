import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Device } from '../models/Device';
import { DeviceService } from '../service/device-service.service';

@Component({
  selector: 'app-device',
  templateUrl: './device.component.html',
  styleUrls: ['./device.component.css']
})
export class DeviceComponent implements OnInit {

  public devices: Device[] = [];

  constructor(private route:ActivatedRoute, 
              private router: Router,
              private deviceService: DeviceService ) {}

  ngOnInit(): void {
    this.getDevices();    
  }

  getDevices(): void {
    this.deviceService.getAll().then(
      res => {
        this.devices = res,
        this.route.params.subscribe(params => {
          if (params['searchTerm'] && params['searchTerm'].replace(/\s/g, "")){
            this.devices = res;
            this.devices = this.devices.filter(device => device.name.toLowerCase().includes(params['searchTerm'].toLowerCase().replace(/\s/g, "")));
          }
          else 
            this.devices = res;
        })
      },
      error => {
        console.log(error);
      }
    );
  }

  detail(id: number):void {
    this.router.navigateByUrl('/device-details/' + id);
  }
}
