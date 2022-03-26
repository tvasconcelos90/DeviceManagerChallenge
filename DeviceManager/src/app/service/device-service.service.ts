import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { first, lastValueFrom, Observable, tap } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Device } from '../models/Device';

@Injectable({
  providedIn: 'root'
})
export class DeviceService {

  baseUrl = `${environment.baseUrl}/api/Device`;

  constructor(private http: HttpClient) {}
  
  async getAll() {
    return await lastValueFrom(this.http.get<Device[]>(this.baseUrl));    
  }

  getById(deviceId: number): Observable<Device> {
    return this.http.get<Device>(`${this.baseUrl}/${deviceId}`);
  }

  getRelatedDevices(deviceId: number): Observable<Device[]> {
    return this.http.get<Device[]>(`${this.baseUrl}/relatedDevices/${deviceId}`);
  }

}
