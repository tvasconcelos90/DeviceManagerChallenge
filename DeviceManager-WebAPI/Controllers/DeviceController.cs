using DeviceManager_WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManager_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IRepository _repo;
        public DeviceController(IRepository repo)
        {   
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDevices() {
            try 
            {   
                var result = await _repo.GetDevicesAsync();            
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            } 
        }

        [HttpGet]
        [Route("{deviceId}")]
        public async Task<IActionResult> GetDeviceById(int deviceId)
        {
            try
            {
                var result = await _repo.GetDeviceByIdAsync(deviceId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("relatedDevices/{deviceId}")]
        public async Task<IActionResult> GetRelatedDevicesAsync(int deviceId) 
        {
            try 
            {
                var result = await _repo.GetRelatedDevicesAsync(deviceId);
                return Ok(result);
            }
            catch (Exception ex)
            {   
                return BadRequest($"Error: {ex.Message}");
            }
        }       
    }
}