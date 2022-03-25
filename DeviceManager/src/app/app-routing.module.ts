import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DeviceDetailsComponent } from './device-details/device-details.component';
import { DeviceComponent } from './device/device.component';

const routes: Routes = [
  { path: '',  component: DeviceComponent},
  { path: 'device',  component: DeviceComponent},
  { path: 'device-details/:id', component: DeviceDetailsComponent},
  { path: 'search/:searchTerm', component: DeviceComponent}  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
