export class Device {
    id: number;
    name: string;
    status: string;
    type: string;
    info: string;
    temperature: number;
    relatedDevices: Device[];
}