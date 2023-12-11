using GatewayManagementRestApi.GatewayManagment.core.Dtos;
using GatewayManagementRestApi.GatewayManagment.core.Services;
using Microsoft.AspNetCore.Mvc;

namespace GatewayManagementRestApi.Controllers
{
    [ApiController]
    [Route("api/gateways")]
    public class GatewayController : Controller
    {   
            private readonly GatewayServices _gatewayService;

            public GatewayController(GatewayServices gatewayService)
            {
                _gatewayService = gatewayService;
            }

            [HttpGet]
            public ActionResult<List<GatewayModel>> GetGateways()
            {
                return _gatewayService.GetGateways();
            }

            [HttpGet("{serialNumber}")]
            public ActionResult<GatewayModel> GetGateway(string serialNumber)
            {
                var gateway = _gatewayService.GetGatewayBySerialNumber(serialNumber);
                if (gateway == null)
                {
                    return NotFound();
                }

                return gateway;
            }

            [HttpPost]
            public ActionResult AddGateway(GatewayModel gateway)
            {
                _gatewayService.AddGateway(gateway);
                return Ok();
            }

            [HttpPost("{serialNumber}/devices")]
            public ActionResult AddPeripheralDevice(string serialNumber, PeripheralDeviceModel device)
            {
                _gatewayService.AddPeripheralDevice(serialNumber, device);
                return Ok();
            }

            [HttpDelete("{serialNumber}/devices/{uid}")]
            public ActionResult RemovePeripheralDevice(string serialNumber, int uid)
            {
                _gatewayService.RemovePeripheralDevice(serialNumber, uid);
                return Ok();
            }
    }
}
