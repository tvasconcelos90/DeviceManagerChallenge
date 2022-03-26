using DeviceManager_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManager_WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        async Task<Device> IRepository.GetDeviceByIdAsync(int id)
        {
            IQueryable<Device> query = _context.Devices;  

            query = query.AsNoTracking()
                         .Where(device => device.Id == id);
            
            return await query.FirstOrDefaultAsync();
        }

        async Task<Device[]> IRepository.GetDevicesAsync()
        {
            IQueryable<Device> query = _context.Devices;

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }

        async Task<Device[]> IRepository.GetRelatedDevicesAsync(int id)
        {
            IQueryable<Device> query = _context.Devices;

            query = query.AsNoTracking()
                         .Where(device => device.Id != id);
            
            return await query.ToArrayAsync();
        }
    }
}