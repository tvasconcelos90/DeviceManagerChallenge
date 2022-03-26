using DeviceManager_WebAPI.Models;

namespace DeviceManager_WebAPI.Data
{
    public interface IRepository
    {
        Task<Device[]> GetDevicesAsync();
        Task<Device> GetDeviceByIdAsync(int id);
        Task<Device[]> GetRelatedDevicesAsync(int id);
    }
}